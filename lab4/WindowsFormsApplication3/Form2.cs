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
    public partial class Form2 : Form
    {
        string[] arr;
        int size = 0,Entered_Elements=0;
        public Form2()
        {
            InitializeComponent();
        }
        private void sizetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            addelemtxtbox.Enabled = false;
            addbutton.Enabled = false;
            showbutton.Enabled = false;
            deletebutton.Enabled = false;
            sumbutton.Enabled = false;
            sizetxtbox.KeyPress += sizetxtbox_KeyPress;
            addelemtxtbox.KeyPress += sizetxtbox_KeyPress;
            sizetxtbox.Leave += sizetxtbox_Leave;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
           
            if (addelemtxtbox.Text.Trim() != "")
                if (Entered_Elements < size)
                {

                    arr[Entered_Elements++] = addelemtxtbox.Text;/*ToString();*/
                    addelemtxtbox.Clear();
                    addelemtxtbox.Focus();
                }
                else
                    MessageBox.Show("Max Size!");
            else
            {
                MessageBox.Show("Enter Element!");
                addelemtxtbox.Focus();
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Entered_Elements > 0)
                for (int i = 0; i < Entered_Elements; i++)
                    listBox1.Items.Add(arr[i]);
            else
                MessageBox.Show("Array is Empty!");
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    listBox1.Items.Remove(listBox1.Items[0]);
                size = Entered_Elements = 0;
                arr = new string[0];
                addelemtxtbox.Text = sizetxtbox.Text = resulttxt.Text = "";
                Form2_Load(null, null);
            }
            else
                MessageBox.Show("List is Empty!");

        }
        private void sizetxtbox_Leave(object sender, EventArgs e)
        {
            if (sizetxtbox.Text.Trim() != "")
            {
                size = int.Parse(sizetxtbox.Text);
                arr = new string[size];Entered_Elements = 0;
            }
        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < Entered_Elements; i++)
                {
                    s += int.Parse(arr[i]);
                }
                resulttxt.Text = s.ToString();
            }
            else
                MessageBox.Show("List is Empty!");
        }

        private void sizetxtbox_TextChanged(object sender, EventArgs e)
        {
            bool f = sizetxtbox.Text != "";
            addelemtxtbox.Enabled = f;
            addbutton.Enabled = f;
            showbutton.Enabled = f;
            deletebutton.Enabled = f;
            sumbutton.Enabled = f;
            listBox1.Items.Clear();resulttxt.Text = "";
            
        }
    }
}
