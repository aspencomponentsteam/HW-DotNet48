using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_DotNet48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.OpenFileDialog open = new System.Windows.Forms.OpenFileDialog();
            open.Title = "Pick a dangerous file to run (.NET 6 app)...";
            var dialogResult = open.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(open.FileName);
            }
        }
    }
}
