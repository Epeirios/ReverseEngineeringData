using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using io.parsingdata.metal;

namespace EncodingTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            io.parsingdata.metal.data.ByteStreamSource x = new io.parsingdata.metal.data.ByteStreamSource();
        }        
    }
}
