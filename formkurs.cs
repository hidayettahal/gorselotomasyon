using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _202503024__Mercan_Esen_
{
    public partial class formkurs : Form
    {
        public formkurs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbasvurular fr2 = new formbasvurular();
            fr2.ShowDialog();

        }

    }
}
