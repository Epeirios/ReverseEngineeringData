using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUFS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            List<string> ReadFileTable(int StartIndex)
            {
                //list for storing Block location
                List<string> Blocks = new List<string>();
                //Add First Block to list
                Blocks.Add(String.Format("{0:X2}", StartIndex));
                //Load Dump.zufs
                BinaryReader br =
                    new BinaryReader(
                        File.OpenRead("C:/Repos/Reverse-Engineering-data/ZUFS/dumpFileData.zufs"));

                while (StartIndex != 0)
                {
                    StartIndex = StartIndex * 4;
                    br.BaseStream.Position = StartIndex;
                    string Temp = null;
                    for (int i = StartIndex; i < (StartIndex + 4); i++)
                    {
                        br.BaseStream.Position = i;
                        Temp += String.Format("{0:X2}", br.ReadByte());
                    }
                    Blocks.Add(Temp);
                    StartIndex = Convert.ToInt32(Temp, 16);
                }
                br.Close();

                return Blocks;
            }

            void CreateFile(List<string> Locations)
            {
                //Remove 0x00000000 element from list
                Locations.Remove(Locations.Last());

                BinaryReader br =
                    new BinaryReader(
                        File.OpenRead("C:/Repos/Reverse-Engineering-data/ZUFS/dump.zufs"));

                FileStream fs = new FileStream("C:/Repos/Reverse-Engineering-data/ZUFS/r1.jpg", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                foreach (string Location in Locations )
                {
                    string Temp = Location;
                    Temp += "000";
                    br.BaseStream.Position = Convert.ToInt32(Temp, 16);
                    bw.Write(br.ReadBytes(4096));
                }

                br.Close();
                fs.Close();
                bw.Close();


            }


            
            List<string> Results = new List<string>( ReadFileTable(0xEA));
            CreateFile(Results);




        }
    }
}
