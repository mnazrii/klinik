using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klinik3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikDataSet.userlogin' table. You can move, or remove it, as needed.
            this.userloginTableAdapter.Fill(this.klinikDataSet.userlogin);
            label4versionno.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            userloginBindingSource.Filter = "username='" + textBoxusername.Text.Replace("'", "") + "' and password='" + textBoxpassword.Text.Replace("'", "") + "'";

            textBoxpassword.Text = "";
            if (userloginBindingSource.Count!=1)
            {
                errorProvider1.SetError(button1submit, "Login Failed!");
                return;
            }
            var datarow = (DataRowView)userloginBindingSource[0];
            Session.Username = datarow["username"].ToString();
            Session.Fullname = datarow["fullname"].ToString();
            Session.Level = datarow["level"].ToString();
//TODO: 

            qform.Show();
            this.Hide();
        }

        QueueForm qform = new QueueForm();

        private void textBoxpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
                
            }
        }

        UpdateForm updateform = new UpdateForm();
       
        private void label3_Click(object sender, EventArgs e)
        {
            updateform.ShowDialog();
        }
    }
}
