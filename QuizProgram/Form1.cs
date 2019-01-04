using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int result = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Please enter informations!!");
            else
            {
                using (Form2 frm = new Form2())
                {
                    frm.ShowDialog();
                    this.Hide();
                    if (frm.Visible == false)
                    {
                        result += frm.TheValue;
                    }
                }
                using (Form3 frm = new Form3())
                {
                    frm.ShowDialog();
                    if (frm.Visible == false)
                    {
                        result += frm.TheValue;
                    }
                }
                using (Form4 frm = new Form4())
                {
                    frm.ShowDialog();
                    if (frm.Visible == false)
                    {
                        result += frm.TheValue;
                    }
                }
                using (Form5 frm = new Form5())
                {
                    frm.ShowDialog();
                    if (frm.Visible == false)
                    {
                        result += frm.TheValue;
                    }
                }
                using (Form6 frm = new Form6())
                {
                    frm.ShowDialog();
                    if (frm.Visible == false)
                    {
                        result += frm.TheValue;
                        label4.Visible = true;
                        label4.Text = "HEY YOU GOT " + result.ToString();
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;

                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;

                        button1.Visible = false;
                        this.Show();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string yourVar = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string yourVar = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string yourVar = textBox3.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                
                textBox2.Focus();
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
