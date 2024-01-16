using Desktop2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop2
{
    public partial class LoginForm : parent
    {
        Settings settings = Settings.Default;
        public LoginForm()
        {
            InitializeComponent();
            textBox1.Leave += TextBox1_Leave;
            textBox2.PasswordChar = '*';

            textBox1.Text = "lima.gustavo100@hotmail.com";
            textBox2.Text = "admin123";
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            var email = ctx.Usuarios.FirstOrDefault(x => x.Email == textBox1.Text);
            if (email == null) return;

            if (email.perfil == ADM)
                checkBox1.Enabled = false;
            else checkBox1.Enabled = true;
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                "Empty email or password".Alert();
                return;
            }
            var user = ctx.Usuarios.FirstOrDefault(x => x.Email == textBox1.Text && x.Senha == textBox2.Text);
            if (user == null)
            {
                "Email or Password not valid".Alert();
                return;
            }
            Dados.Logged = user;
            settings.keep = checkBox1.Checked;
            settings.idUser = user.Id;
            settings.Save();

            if (user.perfil == "0") new AdmForm().Show();
            else new UserForm().Show();

            this.Hide();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var email = ctx.Usuarios.FirstOrDefault(x => x.Email == textBox1.Text);
                if (email == null)
            {
                "Invalid email".Alert();
                return;
            }

            Dados.Logged = email;
            new ForgotPassForm().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
