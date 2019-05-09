using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseDirectories_Click(object sender, EventArgs e)
        {
            dlgBrowseDirectories.SelectedPath = txtBaseDirectory.Text;
            if (dlgBrowseDirectories.ShowDialog(this) == DialogResult.OK)
                txtBaseDirectory.Text = dlgBrowseDirectories.SelectedPath;
        }
    }
}
