using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Takool_Seletiva2019.Model;

namespace Takool_Seletiva2019
{
    public partial class AutentificationPage : Form
    {
        private dbTarefasEntities ctx = new dbTarefasEntities();

        public AutentificationPage()
        {
            InitializeComponent();
        }

        private void linkKeyboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("osk.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o teclado virtual: " + ex.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            bool capsLockAtivadoMessage = Control.IsKeyLocked(Keys.CapsLock);

            labelCapsLock.Visible = capsLockAtivadoMessage;

            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.X || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void linkSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUpPage page2 = new SingUpPage();

            page2.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var buscarUsuario = ctx.Usuario.FirstOrDefault(x => x.Usuario1 == textBox1.Text);

            if (buscarUsuario == null)
            {
                MessageBox.Show("Usuário não encontrado");
                return;
            }

            MessageBox.Show($"Seja Bem-Vindo {buscarUsuario.Usuario1} ");
            
            new HomePage(buscarUsuario.Codigo).Show();
        }

        private void searchCredential(object sender, EventArgs e)
        {
            searchUser(sender, e);
        }

        private void searchUser(object sender, EventArgs e)
        {
            var buscarUsuario = ctx.Usuario.FirstOrDefault(x => x.Usuario1 == textBox1.Text);

            if (buscarUsuario != null)
            {
                if (buscarUsuario.Foto != null && buscarUsuario.Foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(buscarUsuario.Foto))
                    {
                        Image userImage = Image.FromStream(ms);
                        pictureCredential.Image = userImage;
                        pictureCredential.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada!");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }

    }
}