using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week6ZuStr
{
    public partial class FormZuStr : Form
    {
        private string _des = string.Empty;

        public FormZuStr()
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
                    FillTreeView(File.ReadAllBytes(fbd.FileName).ToList());
                }
            }
        }

        private void FillTreeView(List<byte> filesteam)
        {
            short filecounter = 0;

            var stream = new FileStream("C:\\Users\\Epeirios\\Desktop\\test\\file"+filecounter.ToString(), FileMode.Append);

            string currentID = BitConverter.ToString(filesteam.Take(4).ToArray());
            short counter = 0;
            bool zif1start = false;
            short zif1counter = 0;            

            while (filesteam.Count > 0)
            {
                string id = BitConverter.ToString(filesteam.Take(4).ToArray());

                filesteam.RemoveRange(0, 6);

                byte byte1 = filesteam[0];
                byte byte2 = filesteam[1];

                ushort lenght2 = (ushort)((byte1 << 8) + (byte2));

                filesteam.RemoveRange(0, 2);

                if (currentID != id || filesteam.Count <= lenght2)
                {
                    filecounter++;                                      

                    if (filesteam.Count <= lenght2)
                    {
                        counter++;
                    }
                    else
                    {
                        stream.Close();
                        stream = new FileStream("C:\\Users\\Epeirios\\Desktop\\test\\file" + filecounter.ToString(), FileMode.Append);
                    }

                    TreeNode node_counter = new TreeNode(counter.ToString());

                    TreeNode[] array;

                    if (zif1start)
                    {
                        array = new TreeNode[] { node_counter, new TreeNode("zif1"), new TreeNode(zif1counter.ToString()) };
                    }
                    else
                    {
                        array = new TreeNode[] { node_counter };
                    }

                    TreeNode node = new TreeNode(currentID, array);

                    treeView1.Nodes.Add(node);

                    currentID = id;
                    zif1start = false;
                    zif1counter = 0;
                    counter = 0;
                }

                counter++;

                if (BitConverter.ToString(filesteam.Take(4).ToArray()) == "5A-49-46-31")
                {
                    zif1start = true;
                    zif1counter++;
                }

                stream.Write(filesteam.Take(lenght2).ToArray(), 0, lenght2 );

                filesteam.RemoveRange(0, lenght2);
            }
        }
    }
}
