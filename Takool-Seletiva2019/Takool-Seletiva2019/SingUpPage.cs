using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takool_Seletiva2019.Model;

namespace Takool_Seletiva2019
{
    public partial class SingUpPage : Form
    {
        dbTarefasEntities ctx = new dbTarefasEntities();

        public SingUpPage()
        {
            InitializeComponent();
        }

        private string GerarUsuarioAleatorio(string nomeCompleto, DateTime dataNascimento)
        {
            string anoNascimento = (dataNascimento.Year % 100).ToString();

            nomeCompleto = RemoverAcentos(nomeCompleto).ToLower();

            string[] partesNome = nomeCompleto.Split(' ');

           
            StringBuilder usuario = new StringBuilder();
            if (partesNome.Length >= 2)
            {
                usuario.Append(partesNome[0]);
                usuario.Append(".");
                usuario.Append(partesNome[1]);
                usuario.Append(anoNascimento);
                usuario.Append(".");
            }

            return usuario.ToString();
        }

        //stackOverflow - pesquisa
        private string RemoverAcentos(string texto)
        {
            string normalizedString = texto.Normalize(NormalizationForm.FormD);
            StringBuilder result = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    result.Append(c);
                }
            }

            return result.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {


            string nomeCompleto = textBoxName.Text;
            DateTime dataNascimento = dateTimePicker1.Value;

            //chama a função de geraUsuario
            string usuarioAleatorio = GerarUsuarioAleatorio(nomeCompleto, dataNascimento);

            textBoxUser.Text = usuarioAleatorio;
        }

        private bool IsValidEmail(string email)
        {
            // expressão pega da internet
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        private void textMail_Leave(object sender, EventArgs e)
        {
            string email = textMail.Text;

            if (IsValidEmail(email))
            {
                return;
            }
            else
            {
                MessageBox.Show("O e-mail não é válido.");
            }
        }

        private void btnSelectCredential_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens (*.png;*.jpg;*) | *.png;*.jpg;*";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Carrega a imagem selecionada no PictureBox
                string imagePath = ofd.FileName;
                Image imagemSelecionada = Image.FromFile(imagePath);

                pictureCredential.Image = imagemSelecionada;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos necessários foram preenchidos
            if (textMail.Text == "" || textBoxUser.Text == "" || textBoxName.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }

            var validarEmail = ctx.Usuario.FirstOrDefault(x => x.Email == textMail.Text);
            if (validarEmail != null)
            {
                MessageBox.Show("Email já cadastrado");
                return;
            }

            Usuario user = new Usuario();
            user.Usuario1 = textBoxUser.Text;
            user.Nome = textBoxName.Text;
            user.Email = textMail.Text;
            user.Telefone = textBoxPhone.Text;


            if (pictureCredential.Image != null)
            {
                ImageConverter cvt = new ImageConverter();
                byte[] binaryImage = (byte[])cvt.ConvertTo(pictureCredential.Image, typeof(byte[]));
                user.Foto = binaryImage;
            }

            ctx.Usuario.Add(user);
            ctx.SaveChanges();

            MessageBox.Show("Usuário Cadastrado com sucesso!!");
            
            textMail.Text = "";
            textBoxUser.Text = "";
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            pictureBox1.Image = Image.FromFile("C:\\Users\\enzoq\\Desktop\\DataFilesS01\\user");
        }
    }
}
