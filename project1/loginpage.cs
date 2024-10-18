using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(tbun.Text=="admin" && tbpw.Text == "1234") {
                Homepage hp = new Homepage();
                hp.Show();
                this.Hide();
            }
            else { 
            MessageBox.Show("Incorrect UserName or Password","Alert !!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
