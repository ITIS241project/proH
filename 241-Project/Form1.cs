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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        bool Login()
        {
            sql.Param("@usr", textBox1.Text);
            sql.Param("@pwd", textBox2.Text);
            sql.query("select count(*) from tbluser where usr=@usr and pwd=@pwd");
            if ((int)sql.dt.Rows[0][0] == 1)
            {
                return true;
            }
            MessageBox.Show("Invalid !!");
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(Login() == true)
            {
                mainForm mf = new mainForm();
                Hide();
                mf.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.ShowDialog();
        }
    }
}
