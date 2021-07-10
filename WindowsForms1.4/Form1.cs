using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 750);
            int y = rnd.Next(0, 400);
            if (sender == label1)
            {
                label1.Location = new Point(x, y);
            }
        }
    }
}
