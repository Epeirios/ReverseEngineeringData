using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileSystem_Block_Lenght_Reader
{
    public partial class Form1 : Form
    {
        string[] _files;
        string _des = string.Empty;

        public Form1()
        {
            InitializeComponent();
            
            button1settext("C:\\Users\\Epeirios\\Desktop\\e_r split");
            button3settext("C:\\Users\\Epeirios\\Desktop\\e_r concat");
            

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

            foreach (var item in _files)
            {
                // TODO strip the dir name

                checkedListBox1.Items.Add(item, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> srcFileNames = new List<string>();

            int count = Directory.GetFiles(_des).Length;

            string destFileName = _des + "\\concat" + count + ".gif";

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                string s = "";
                for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                {

                    s = checkedListBox1.CheckedItems[x].ToString();
                    srcFileNames.Add(s);

                }
            }

            //srcFileNames.Reverse();

            pictureBox1.Image = null;

            using (Stream destStream = new FileStream(destFileName, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                foreach (string srcFileName in srcFileNames)
                {
                    using (Stream srcStream = File.OpenRead(srcFileName))
                    {
                        srcStream.CopyTo(destStream);
                    }
                }
            }

            try
            {
                pictureBox1.Image = Image.FromFile(destFileName);
            }
            catch (Exception)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    button3settext(fbd.SelectedPath);
                }
            }
        }

        private void button3settext(string path)
        {
            _des = path;
            textBox2.Text = _des;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
