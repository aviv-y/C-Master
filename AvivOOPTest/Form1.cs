using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvivOOPTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            Ans1 ans1 = new Ans1();
            ans1.Run();
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            Ans2 ans2 = new Ans2();
            ans2.Run();
        }

        private void btnAns3_Click(object sender, EventArgs e)
        {

        }
    }
}
