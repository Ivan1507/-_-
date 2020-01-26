using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "123";
            if (textBox1.Text == s)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                textBox1.Enabled = false;
            }
            else MessageBox.Show("Неправильно введен пароль");
        }

        private void ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11.Tables["Owner"]);
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11.Tables[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
