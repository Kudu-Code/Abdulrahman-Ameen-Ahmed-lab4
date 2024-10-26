namespace WindowsFormsApplication3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sort_button = new System.Windows.Forms.Button();
            this.student_name = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.students_rate = new System.Windows.Forms.TextBox();
            this.students_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 212);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sort_button
            // 
            this.sort_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.sort_button.Location = new System.Drawing.Point(153, 315);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(123, 23);
            this.sort_button.TabIndex = 18;
            this.sort_button.Text = "Sort List";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // student_name
            // 
            this.student_name.Enabled = false;
            this.student_name.Location = new System.Drawing.Point(153, 33);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(144, 20);
            this.student_name.TabIndex = 17;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.addbutton.Location = new System.Drawing.Point(143, 64);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(167, 23);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Add to List";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Name";
            // 
            // students_rate
            // 
            this.students_rate.Location = new System.Drawing.Point(3, 33);
            this.students_rate.Name = "students_rate";
            this.students_rate.Size = new System.Drawing.Size(100, 20);
            this.students_rate.TabIndex = 11;
            // 
            // students_num
            // 
            this.students_num.Location = new System.Drawing.Point(331, 33);
            this.students_num.Name = "students_num";
            this.students_num.Size = new System.Drawing.Size(125, 20);
            this.students_num.TabIndex = 10;
            this.students_num.TextChanged += new System.EventHandler(this.students_num_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(336, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Students";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.students_rate);
            this.Controls.Add(this.students_num);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox students_rate;
        private System.Windows.Forms.TextBox students_num;
        private System.Windows.Forms.Label label3;
    }
}