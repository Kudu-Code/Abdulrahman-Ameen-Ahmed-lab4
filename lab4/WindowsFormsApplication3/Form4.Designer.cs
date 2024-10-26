namespace WindowsFormsApplication3
{
    partial class Form4
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
            this.button_up = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.radioButton_up = new System.Windows.Forms.RadioButton();
            this.buttonplay = new System.Windows.Forms.Button();
            this.buttonplayer = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_minus_left = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_minus_down = new System.Windows.Forms.Button();
            this.button_plus_right = new System.Windows.Forms.Button();
            this.button_plus_up = new System.Windows.Forms.Button();
            this.radioButton_down = new System.Windows.Forms.RadioButton();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_up
            // 
            this.button_up.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_up.Location = new System.Drawing.Point(435, 20);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(39, 23);
            this.button_up.TabIndex = 0;
            this.button_up.Text = "^";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 87);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton_up
            // 
            this.radioButton_up.AutoSize = true;
            this.radioButton_up.Location = new System.Drawing.Point(12, 26);
            this.radioButton_up.Name = "radioButton_up";
            this.radioButton_up.Size = new System.Drawing.Size(37, 17);
            this.radioButton_up.TabIndex = 2;
            this.radioButton_up.TabStop = true;
            this.radioButton_up.Text = "up";
            this.radioButton_up.UseVisualStyleBackColor = true;
            this.radioButton_up.CheckedChanged += new System.EventHandler(this.radioButton_up_CheckedChanged);
            // 
            // buttonplay
            // 
            this.buttonplay.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonplay.Location = new System.Drawing.Point(12, 237);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(88, 25);
            this.buttonplay.TabIndex = 3;
            this.buttonplay.Text = "play";
            this.buttonplay.UseVisualStyleBackColor = true;
            this.buttonplay.Click += new System.EventHandler(this.buttonplay_Click);
            // 
            // buttonplayer
            // 
            this.buttonplayer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonplayer.Location = new System.Drawing.Point(176, 74);
            this.buttonplayer.Name = "buttonplayer";
            this.buttonplayer.Size = new System.Drawing.Size(79, 40);
            this.buttonplayer.TabIndex = 4;
            this.buttonplayer.Text = "player";
            this.buttonplayer.UseVisualStyleBackColor = true;
            this.buttonplayer.Click += new System.EventHandler(this.buttonplayer_Click);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_left.Location = new System.Drawing.Point(319, 105);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(39, 23);
            this.button_left.TabIndex = 5;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_right.Location = new System.Drawing.Point(557, 104);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(39, 23);
            this.button_right.TabIndex = 6;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_minus_left
            // 
            this.button_minus_left.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_minus_left.Location = new System.Drawing.Point(374, 104);
            this.button_minus_left.Name = "button_minus_left";
            this.button_minus_left.Size = new System.Drawing.Size(39, 23);
            this.button_minus_left.TabIndex = 7;
            this.button_minus_left.Text = "-";
            this.button_minus_left.UseVisualStyleBackColor = true;
            this.button_minus_left.Click += new System.EventHandler(this.button_minus_left_Click);
            // 
            // button_down
            // 
            this.button_down.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_down.Location = new System.Drawing.Point(435, 202);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(39, 23);
            this.button_down.TabIndex = 8;
            this.button_down.Text = "v";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_minus_down
            // 
            this.button_minus_down.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_minus_down.Location = new System.Drawing.Point(435, 150);
            this.button_minus_down.Name = "button_minus_down";
            this.button_minus_down.Size = new System.Drawing.Size(39, 24);
            this.button_minus_down.TabIndex = 9;
            this.button_minus_down.Text = "-";
            this.button_minus_down.UseVisualStyleBackColor = true;
            this.button_minus_down.Click += new System.EventHandler(this.button_minus_down_Click);
            // 
            // button_plus_right
            // 
            this.button_plus_right.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_plus_right.Location = new System.Drawing.Point(497, 104);
            this.button_plus_right.Name = "button_plus_right";
            this.button_plus_right.Size = new System.Drawing.Size(39, 23);
            this.button_plus_right.TabIndex = 10;
            this.button_plus_right.Text = "+";
            this.button_plus_right.UseVisualStyleBackColor = true;
            this.button_plus_right.Click += new System.EventHandler(this.button_plus_right_Click);
            // 
            // button_plus_up
            // 
            this.button_plus_up.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_plus_up.Location = new System.Drawing.Point(435, 67);
            this.button_plus_up.Name = "button_plus_up";
            this.button_plus_up.Size = new System.Drawing.Size(39, 23);
            this.button_plus_up.TabIndex = 11;
            this.button_plus_up.Text = "+";
            this.button_plus_up.UseVisualStyleBackColor = true;
            this.button_plus_up.Click += new System.EventHandler(this.button_plus_up_Click);
            // 
            // radioButton_down
            // 
            this.radioButton_down.AutoSize = true;
            this.radioButton_down.Location = new System.Drawing.Point(12, 49);
            this.radioButton_down.Name = "radioButton_down";
            this.radioButton_down.Size = new System.Drawing.Size(51, 17);
            this.radioButton_down.TabIndex = 12;
            this.radioButton_down.TabStop = true;
            this.radioButton_down.Text = "down";
            this.radioButton_down.UseVisualStyleBackColor = true;
            this.radioButton_down.CheckedChanged += new System.EventHandler(this.radioButton_down_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(12, 111);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(38, 17);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "10";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(12, 134);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(38, 17);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "15";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(12, 157);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(38, 17);
            this.checkBox20.TabIndex = 15;
            this.checkBox20.Text = "20";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 274);
            this.Controls.Add(this.checkBox20);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.radioButton_down);
            this.Controls.Add(this.button_plus_up);
            this.Controls.Add(this.button_plus_right);
            this.Controls.Add(this.button_minus_down);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_minus_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.buttonplayer);
            this.Controls.Add(this.buttonplay);
            this.Controls.Add(this.radioButton_up);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.button_up);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.RadioButton radioButton_up;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.Button buttonplayer;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_minus_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_minus_down;
        private System.Windows.Forms.Button button_plus_right;
        private System.Windows.Forms.Button button_plus_up;
        private System.Windows.Forms.RadioButton radioButton_down;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox20;
    }
}