namespace _241_Project
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MiddleN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LastN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dbtestDataSet1 = new _241_Project.dbtestDataSet();
            this.tableAdapterManager1 = new _241_Project.dbtestDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dbtestDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(153, 52);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(170, 22);
            this.textBox_UserName.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(153, 97);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(170, 22);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBox_FirstN
            // 
            this.textBox_FirstN.Location = new System.Drawing.Point(153, 146);
            this.textBox_FirstN.Name = "textBox_FirstN";
            this.textBox_FirstN.Size = new System.Drawing.Size(170, 22);
            this.textBox_FirstN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "FirstN";
            // 
            // textBox_MiddleN
            // 
            this.textBox_MiddleN.Location = new System.Drawing.Point(153, 187);
            this.textBox_MiddleN.Name = "textBox_MiddleN";
            this.textBox_MiddleN.Size = new System.Drawing.Size(170, 22);
            this.textBox_MiddleN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "MiddleN";
            // 
            // textBox_LastN
            // 
            this.textBox_LastN.Location = new System.Drawing.Point(153, 236);
            this.textBox_LastN.Name = "textBox_LastN";
            this.textBox_LastN.Size = new System.Drawing.Size(170, 22);
            this.textBox_LastN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "lastN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbtestDataSet1
            // 
            this.dbtestDataSet1.DataSetName = "dbtestDataSet";
            this.dbtestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbluserTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = _241_Project.dbtestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_LastN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_MiddleN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_FirstN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbtestDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MiddleN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LastN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private dbtestDataSet dbtestDataSet1;
        private dbtestDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}