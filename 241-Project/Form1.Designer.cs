namespace _241_Project
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_LogIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(138, 325);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(160, 55);
            this.button_Register.TabIndex = 2;
            this.button_Register.Text = "Rgister";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_LogIN
            // 
            this.button_LogIN.Location = new System.Drawing.Point(138, 234);
            this.button_LogIN.Name = "button_LogIN";
            this.button_LogIN.Size = new System.Drawing.Size(160, 55);
            this.button_LogIN.TabIndex = 3;
            this.button_LogIN.Text = "Log in";
            this.button_LogIN.UseVisualStyleBackColor = true;
            this.button_LogIN.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button_LogIN);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Location = new System.Drawing.Point(74, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 541);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 659);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_LogIN;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

