namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.sizetxtbox = new System.Windows.Forms.TextBox();
            this.addelemtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.sumbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sizetxtbox
            // 
            this.sizetxtbox.Location = new System.Drawing.Point(205, 37);
            this.sizetxtbox.Name = "sizetxtbox";
            this.sizetxtbox.Size = new System.Drawing.Size(100, 20);
            this.sizetxtbox.TabIndex = 0;
            this.sizetxtbox.TextChanged += new System.EventHandler(this.sizetxtbox_TextChanged);
            // 
            // addelemtxtbox
            // 
            this.addelemtxtbox.Location = new System.Drawing.Point(12, 37);
            this.addelemtxtbox.Name = "addelemtxtbox";
            this.addelemtxtbox.Size = new System.Drawing.Size(100, 20);
            this.addelemtxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(175, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter number of Elements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Element";
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.addbutton.Location = new System.Drawing.Point(83, 68);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(167, 23);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Add to Array";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.deletebutton.Location = new System.Drawing.Point(196, 98);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(123, 23);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "Delete Elements";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // showbutton
            // 
            this.showbutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.showbutton.Location = new System.Drawing.Point(12, 98);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(123, 23);
            this.showbutton.TabIndex = 6;
            this.showbutton.Text = "Show Elements";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // resulttxt
            // 
            this.resulttxt.Enabled = false;
            this.resulttxt.Location = new System.Drawing.Point(12, 321);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(144, 20);
            this.resulttxt.TabIndex = 7;
            // 
            // sumbutton
            // 
            this.sumbutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.sumbutton.Location = new System.Drawing.Point(196, 321);
            this.sumbutton.Name = "sumbutton";
            this.sumbutton.Size = new System.Drawing.Size(123, 23);
            this.sumbutton.TabIndex = 8;
            this.sumbutton.Text = "Sum of Elements";
            this.sumbutton.UseVisualStyleBackColor = true;
            this.sumbutton.Click += new System.EventHandler(this.sumbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 186);
            this.listBox1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 369);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sumbutton);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addelemtxtbox);
            this.Controls.Add(this.sizetxtbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizetxtbox;
        private System.Windows.Forms.TextBox addelemtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Button sumbutton;
        private System.Windows.Forms.ListBox listBox1;
    }
}