using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop2
{
    public partial class UserForm : parent
    {
        DataTable dt = new DataTable();
        public UserForm()
        {
            InitializeComponent();
            dt.Columns.Add("Id");
            dt.Columns.Add("Mandante");
            dt.Columns.Add("Placar");
            dt.Columns.Add(" ");
            dt.Columns.Add("Placar ");
            dt.Columns.Add("Visitante");
            dt.Columns.Add("  ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (Dados.Logged.Foto != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(Dados.Logged.Foto));
            }

            if (Dados.Logged.NotificacoesUsuarios.Where(x=> x.Status == "Pendente").Count() > 0)
            {
                pictureBox2.Image = Properties.Resources.notification;
            }

            LoadGames();
        }

        private void LoadGames()
        {
            dt.Rows.Clear();
            var rodada = ctx.Rodadas.ToList().OrderBy(x => x.DataInicio).Last();
            foreach (var item in rodada.Jogos)
            {
                dt.Rows.Add(item.Id,item.Seleco.Nome,item.PlacarCasa,"X",item.PlacarVisitante,item.Seleco1.Nome,"Comentar");    
            }
            dataGridView1.DataSource = dt;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new NotifyForm().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 1)
            {
                var selecao = ctx.Selecoes.ToList().First(x => x.Nome == dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                new JogadoresForm(selecao).Show();
            }

            if (e.ColumnIndex == 5)
            {
                var selecao = ctx.Selecoes.ToList().First(x => x.Nome == dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                new JogadoresForm(selecao).Show();
            }
        }
    }
}
