using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile();
            pro.Show();
            this.Hide();
        }

        private void Admin_Login_Click(object sender, EventArgs e)
        {
            Admin_Choose_Uni adminChooseUni = new Admin_Choose_Uni();
            adminChooseUni.Show();
            this.Hide();

            /*string email = textBox1.Text.Trim();
string password = textBox2.Text;
 
if (email == "")
{
    MessageBox.Show("Email is required");
    textBox1.Focus();
    return;
}
 
if (!email.Contains("@") || !email.Contains("."))
{
    MessageBox.Show("Enter a valid email");
    textBox1.Focus();
    return;
}
 
if (password == "")
{
    MessageBox.Show("Password is required");
    textBox2.Focus();
    return;
}
 
Admin_Choose_Uni a1= new Admin_Choose_Uni();
a1.Show();
this.Close();*/
        }
    }
}
