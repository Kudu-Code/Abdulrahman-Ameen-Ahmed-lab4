using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome","Click OK",MessageBoxButtons.OKCancel);
            this.CenterToParent();
            this.MouseClick += Form1_MouseClick;
            button1.MouseHover += mouse_hover;
            button1.MouseLeave += mouse_leave;
           // Random r = new Random();
           // this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
           //r.Next(0, 255));
        }
        private void mouse_hover(object sender,EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Red;
        }
        private void mouse_leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
           r.Next(0, 255));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.ForeColor = Color.Red;
            //button1.BackColor = Color.Yellow;
            if (textBox1.Text.Trim() != "" && !isnumber(textBox1.Text)) 
            {
                textBox4.Text += textBox1.Text + "\r\n";//.ToString();
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Textbox Error!");
                textBox1.Focus();
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
                textBox1.BackColor = Color.Yellow;
            else
                textBox1.BackColor = Color.White;
        }
        private bool isnumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 48 && s[i] <= 57)
                    return true;
            return false;
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
