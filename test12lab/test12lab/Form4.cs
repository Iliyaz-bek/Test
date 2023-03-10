using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test12lab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            Form3 f3 = new Form3();
            DialogResult dialogResult = f3.ShowDialog(); //окно 4
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
