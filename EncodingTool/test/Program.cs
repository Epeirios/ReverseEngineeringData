using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.OutputEncoding = Encoding.GetEncoding(65001);

            string str1 = "TQBpAGcAdQBlAGwA";
            string str2 = "TWlndWVs";
            string str3 = "SmVyb2Vu";

            byte[] data1 = Convert.FromBase64String(str1);
            byte[] data2 = Convert.FromBase64String(str2);

            Console.WriteLine("utf8 \t\t\t hex\n");

            printString1(str1);
            printString1(str3);

            printString1(str2);

            //byte[] pileofpoo = new byte[] { 0xf0, 0x9f, 0x92, 0xa9 };
            //byte[] woman = new byte[] { 0xe2, 0x99, 0x80 };

            //Console.WriteLine(System.Text.Encoding.UTF8.GetString(pileofpoo));
            //Console.WriteLine(System.Text.Encoding.UTF8.GetString(woman));

            Console.Read();
        }

        static private void printString1(string input)
        {
            byte[] data = Convert.FromBase64String(input);

            Console.WriteLine("Encoded:{0,20} : {1, 20}\nDecoded:{2, 20} : {3, 20}"
                ,input 
                ,BitConverter.ToString(Encoding.UTF8.GetBytes(input.ToCharArray())) 
                ,Encoding.Default.GetString(data) 
                ,BitConverter.ToString(data));
        }
    }
}
