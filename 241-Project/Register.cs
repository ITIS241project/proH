using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _241_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        void register()
        {
            sql.Param("@usr", textBox_UserName.Text);
            sql.Param("@pwd", textBox_Password.Text);
            sql.Param("@fname", textBox_FirstN.Text);
            sql.Param("@mn", textBox_MiddleN.Text);
            sql.Param("@lname", textBox_LastN.Text);

            sql.query("insert into tbluser (usr,pwd,fname,mn,lname) values(@usr,@pwd,@fname,@mn,@lname)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registered", "Succes");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
