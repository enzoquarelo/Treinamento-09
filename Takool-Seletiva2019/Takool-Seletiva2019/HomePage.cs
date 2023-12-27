using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takool_Seletiva2019.Model;

namespace Takool_Seletiva2019
{
    public partial class HomePage : Form
    {
        private int usuarioId;
        public HomePage(int id)
        {
            InitializeComponent();
            this.usuarioId = id;
            label_Sair.Visible = false;
            label_Editar.Visible = false;
        }

        dbTarefasEntities ctx = new dbTarefasEntities();

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {

            string saudacao;
            DateTime horario = DateTime.Now;
            int hora = horario.Hour;

            var usuario = ctx.Usuario.FirstOrDefault(x => x.Codigo == usuarioId);

            string nomeUsuario = usuario.Nome;

            if (hora >= 12 && hora < 18)
            {
                saudacao = $"Boa tarde, {nomeUsuario}!";
            }
            else if (hora >= 18 && hora < 24)
            {
                saudacao = $"Boa noite, {nomeUsuario}!";
            }
            else if (hora >= 0 && hora < 4)
            {
                saudacao = $"Boa madrugada, {nomeUsuario}";
            }
            else
            {
                saudacao = $"Bom dia, {nomeUsuario}";

            }
            Txt_BoaTarde.Text = saudacao;

            btnPortugues.BackColor = Color.Green;
            btnIngles.BackColor = Color.YellowGreen;



        }

        private void btnIngles_Click(object sender, EventArgs e)
        {

            var usuario = ctx.Usuario.FirstOrDefault(x => x.Codigo == usuarioId);

            DateTime horario = DateTime.Now;
            int hora = horario.Hour;
            string nomeUsuario = usuario.Nome;
            string saudacaoIngles;

            if (hora >= 12 && hora < 18)
                saudacaoIngles = $"Good afternoon, {nomeUsuario}!";
            else if (hora >= 18 && hora < 24)
                saudacaoIngles = $"Good evening, {nomeUsuario}!";
            else if (hora >= 0 && hora < 5)
                saudacaoIngles = $"Good sun-up, {nomeUsuario}!";
            else
                saudacaoIngles = $"Good morning, {nomeUsuario}!";

            Txt_BoaTarde.Text = saudacaoIngles;

            btnPortugues.BackColor = Color.YellowGreen;
            btnIngles.BackColor = Color.Green;

        }

        private void label_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
