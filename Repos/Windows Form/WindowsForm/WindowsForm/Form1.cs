using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Did you see the icon? ";
            string title = "ok";
            MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        
        }
    }
}