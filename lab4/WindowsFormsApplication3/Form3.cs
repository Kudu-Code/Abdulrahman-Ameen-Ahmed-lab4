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
    public partial class Form3 : Form
    {
        int[] arr;
        int size = 0, Entered_Elements = 0;
        public Form3()
        {
            InitializeComponent();
        }
        private void Txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == students_rate || sender == students_num)//المعدل ادخال بصندوق خاص
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                    e.Handled = true;
            }
            if (sender == student_name)
            {
                if ((e.KeyChar < 65 || e.KeyChar > 122) && (e.KeyChar != 8))
                    e.Handled = true;
            }
        }
        private void stdnum_Leave(object sender, EventArgs e)
        {
            if (students_num.Text.Trim() != "")
            {
                size = int.Parse(students_num.Text);
                arr = new int[size]; Entered_Elements = 0;
            }
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            students_rate.Enabled = student_name.Enabled = addbutton.Enabled =
listBox1.Enabled = sort_button.Enabled = false;
            students_rate.KeyPress += Txtname_KeyPress;
            students_num.KeyPress += Txtname_KeyPress;
            students_rate.MouseLeave += stdnum_Leave;

        }

        private void students_num_TextChanged(object sender, EventArgs e)
        {
            students_rate.Enabled = student_name.Enabled=
            addbutton.Enabled = listBox1.Enabled =
            sort_button.Enabled = students_num.Text.Trim() != "";
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count, temp = arr[0]; string st = "";
            if (c > 0)
            {
                for (int k = 0; k < Entered_Elements; k++)
                {
                    for (int j = k + 1; j < Entered_Elements; j++)
                    {
                        // if (a[k] < a[j]) //تنازلي ترتيب
                        if (arr[k] > arr[j]) //تصاعدي ترتيب
                        {
                            temp = arr[k];
                            arr[k] = arr[j];
                            arr[j] = temp;
                            st = listBox1.Items[k].ToString();
                            listBox1.Items[k] = listBox1.Items[j].ToString();
                            listBox1.Items[j] = st.ToString();
                        }
                    }
                }
            }
            else
                MessageBox.Show("List is Empty!");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (students_rate.Text.Trim() != "" && student_name.Text.Trim() != "")
            {
                if (Entered_Elements < size)
                {
                    listBox1.Items.Add(student_name.Text + "\t" + students_rate.Text);
                    arr[Entered_Elements++] = int.Parse(students_rate.Text);
                    students_rate.Text = student_name.Text = "";
                    students_rate.Focus(); student_name.Focus();
                }
                else
                    MessageBox.Show("Max Size!");
            }
            else
                MessageBox.Show("TextBox Error!");
        }
    }
}
