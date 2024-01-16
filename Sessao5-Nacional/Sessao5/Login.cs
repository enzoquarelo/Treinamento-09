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
    public partial class Login : parent
    {
        Settings settings = Settings.Default;
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            var email = ctx.Usuarios.FirstOrDefault(x => x.Email == textBoxEmail.Text);
            if (email == null) return;

            if (email.perfil == ADM)
                checkBox1.Enabled = false;
            else checkBox1.Enabled = true;
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                "Empty email or password".Alert();
                return;
            }
            var user = ctx.Usuarios.FirstOrDefault(x => x.Email == textBoxEmail.Text && x.Senha == textBoxPass.Text);
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
            var email = ctx.Usuarios.FirstOrDefault(x => x.Email == textBoxEmail.Text);
                if (email == null)
            {
                "Invalid email".Alert();
                return;
            }

            Dados.Logged = email;
            new ForgotPassword().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "administrador@email.com";
            textBoxPass.Text = "admin123";
        }
    }
}
