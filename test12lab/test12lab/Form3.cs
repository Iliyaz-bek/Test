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
    public partial class Form3 : Form
    {
        bool key = false;
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "123";
            if (pass == textBox1.Text)
            {
                key = true;
                Form3.ActiveForm.Close();
            }
            else
                MessageBox.Show("Ошибка пароля");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (key == false)
            {
                int a = 0;
                Environment.Exit(a);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
