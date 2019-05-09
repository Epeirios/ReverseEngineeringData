using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            void CreateFile()
            {
                int Blocksize = 2048;

                BinaryReader br =
                    new BinaryReader(
                        File.OpenRead("C: /Users/cedric/Source/Repos/Reverse-Engineering-data/Week 3/e_r.data"));

                FileStream fs = new FileStream("C: /Users/cedric/Source/Repos/Reverse-Engineering-data/Week 3/e_r.gif", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i <= (br.BaseStream.Length / Blocksize); i++)
                {
                    br.BaseStream.Position = (i * Blocksize);

                    if (br.ReadInt32() != 0)
                    {
                        br.BaseStream.Position = (i * Blocksize);
                        bw.Write(br.ReadBytes(Blocksize));
                    }
                }
                

                br.Close();
                fs.Close();
                bw.Close();


            }

            CreateFile();
        }
    }
}
