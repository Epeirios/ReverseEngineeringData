using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Zufs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1pressed();
        }

        private void button1pressed()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    button1settext(fbd.SelectedPath);
                }
            }
        }

        private void button1settext(string path)
        {
            textBox1.Text = path;

            _files = Directory.GetFiles(path);

            // read first block

            foreach (var item in _files)
            {
                // TODO strip the dir name

                checkedListBox1.Items.Add(item, false);
            }
        }
    }
}
