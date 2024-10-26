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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buttonplayer.Text = Height.ToString();
            //buttonplayer.Text = buttonplayer.Top.ToString();
            buttonplayer.Top -= 5;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button_plus_up_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width, buttonplayer.Height + 5);
        }

        private void button_minus_down_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width, buttonplayer.Height - 5);
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            buttonplayer.Text = buttonplayer.Top.ToString();
            buttonplayer.Location = new Point(buttonplayer.Left, buttonplayer.Top + 5);
        }

        private void button_plus_right_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width + 5, buttonplayer.Height);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            buttonplayer.Location = new Point(buttonplayer.Left + 5, buttonplayer.Top);
        }

        private void button_minus_left_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width-5, buttonplayer.Height);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            buttonplayer.Location = new Point(buttonplayer.Left - 5, buttonplayer.Top);
        }

        private void buttonplayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            //buttonplayer.Text = buttonplayer.Top.ToString();
            //buttonplayer.Text = (this.Location.Y).ToString();
            if (radioButton_up.Checked)
                for (int i = 0; i < Top; i++)
                {
                    if (checkBox5.Checked)
                        buttonplayer.Top -= Convert.ToInt16(checkBox5.Text);
                    else if (checkBox10.Checked)
                        buttonplayer.Top -= Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        buttonplayer.Top -= Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        buttonplayer.Top -= Convert.ToInt32(checkBox20.Text);
                    else return;
                    for (int j = 0; j < 10000000; j++) ;
                    if (buttonplayer.Top <= 0)
                        break;


                }
            else if (radioButton_down.Checked)
                for (int i = 0; i < Top; i++)
                {
                    if (checkBox5.Checked)
                        buttonplayer.Top += Convert.ToInt32(checkBox5.Text);
                    else if (checkBox10.Checked)
                        buttonplayer.Top += Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        buttonplayer.Top += Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        buttonplayer.Top += Convert.ToInt32(checkBox20.Text);
                    else return;
                    for (int j = 0; j < 10000000; j++) ;
                    if (buttonplayer.Bottom >=this.Height-buttonplayer.Height)
                        break;
                }
            else
                return;
        }

        private void radioButton_up_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_down_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
