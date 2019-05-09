using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Week6Zif1
{
    public partial class Formzif1 : Form
    {
        private Graphics zif1pic;
        private Graphics palletepic;

        private Pen pen1 = new Pen(Color.Black);
        private SolidBrush brush = new SolidBrush(Color.Black);

        public Formzif1()
        {
            InitializeComponent();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DrawPicture(File.ReadAllBytes(fbd.FileName).ToList());
                }
            }
        }

        private void DrawPicture(List<byte> filedata)
        {
            filedata.RemoveRange(0, 4); // remove "ZIF1"

            byte[] temp = filedata.Take(12).ToArray();

            int width = BitConverter.ToInt32(temp, 0);
            int height = BitConverter.ToInt32(temp, 4);
            int remain = BitConverter.ToInt32(temp, 8);

            filedata.RemoveRange(0, 16); // width, height, remain, "COLR"

            pictureBox1.Width = width;
            pictureBox1.Height = height;

            zif1pic = pictureBox1.CreateGraphics();

            int palettesize = BitConverter.ToInt32(filedata.Take(4).ToArray(), 0);

            filedata.RemoveRange(0, 4); // PalleteSize

            byte[] pallete = filedata.Take(palettesize).ToArray();

            pictureBoxPallete.Width = palettesize / 4 * 8;
            pictureBoxPallete.Height = 23;

            palletepic = pictureBoxPallete.CreateGraphics();

            List<Color> palleteColors = new List<Color>();

            for (int i = 0; i < palettesize / 4; i++)
            {
                Color kleur = Color.FromArgb(pallete[i * 4], pallete[i * 4 + 1], pallete[i * 4 + 2]);

                brush.Color = kleur;

                palletepic.FillRectangle(brush, 0 + i * 8, 0, 8, 22);

                palleteColors.Add(kleur);
            }

            filedata.RemoveRange(0, palettesize + 4); // Pallete, DATA

            int dataSize = BitConverter.ToInt32(filedata.Take(4).ToArray(), 0);

            filedata.RemoveRange(0, 4); // Datasize

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    brush.Color = palleteColors[filedata[4*j]];
                    zif1pic.FillRectangle(brush, j, i, 1, 1);
                }

                filedata.RemoveRange(0, width);
            }
        }
    }
}
