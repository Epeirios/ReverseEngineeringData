using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Week6Zif1
{
    public partial class Formzif1 : Form
    {
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
                    DrawPictureBitmap(File.ReadAllBytes(fbd.FileName).ToList(), fbd.FileName);
                }
            }
        }

        private void DrawPictureBitmap(List<byte> filedata, string filename)
        {
            filedata.RemoveRange(0, 4); // remove "ZIF1"

            byte[] temp = filedata.Take(12).ToArray();

            int width = BitConverter.ToInt32(temp, 0);
            int height = BitConverter.ToInt32(temp, 4);
            int remain = BitConverter.ToInt32(temp, 8);

            filedata.RemoveRange(0, 16); // width, height, remain, "COLR"

            Bitmap pic = new Bitmap(width, height);

            int palettesize = BitConverter.ToInt32(filedata.Take(4).ToArray(), 0);

            filedata.RemoveRange(0, 4); // PalleteSize

            byte[] pallete = filedata.Take(palettesize).ToArray();

            Bitmap ColorPic = new Bitmap(palettesize / 4 * 8, 23);

            List<Color> palleteColors = new List<Color>();

            for (int i = 0; i < palettesize / 4; i++)
            {
                Color kleur = Color.FromArgb(pallete[i * 4], pallete[i * 4], pallete[i * 4]);

                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 23; y++)
                    {
                        ColorPic.SetPixel(x + (i * 4), y, kleur);
                    }
                }

                palleteColors.Add(kleur);
            }

            pictureBoxPallete.Size = ColorPic.Size;
            pictureBoxPallete.Image = ColorPic;

            filedata.RemoveRange(0, palettesize + 4); // Pallete, DATA

            int dataSize = BitConverter.ToInt32(filedata.Take(4).ToArray(), 0);

            filedata.RemoveRange(0, 4); // Datasize

            int blackcounter = 0;

            Color black = Color.FromArgb(0, 0, 0);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color localcolor =
                        palleteColors[BitConverter.ToInt32(filedata.Skip(j * 4).Take(4).ToArray(), 0)];

                    if (localcolor == black)
                    {
                        blackcounter++;
                    }
                    pic.SetPixel(j, i, localcolor);
                }

                filedata.RemoveRange(0, width * 4);
            }

            lblBlackBlocks.Text = blackcounter.ToString();

            pictureBox1.Size = pic.Size;
            pictureBox1.Image = pic;

            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ZIF1Output");

            pictureBox1.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ZIF1Output\" + Path.GetFileNameWithoutExtension(filename) + ".jpg", ImageFormat.Jpeg);
        }
    }
}
