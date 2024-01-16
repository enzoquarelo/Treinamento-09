using Desktop2.Components;
using Desktop2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Desktop2
{
    public partial class AdmForm : parent
    {
        DataTable dt = new DataTable();

        public Rodada CurrentRodada { get; private set; }

        public AdmForm()
        {
            InitializeComponent();
            dt.Columns.Add("Id");
            dt.Columns.Add("Data");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Mandante");
            dt.Columns.Add("Placar");
            dt.Columns.Add(" ");
            dt.Columns.Add("Placar ");
            dt.Columns.Add("Visitante");
            dt.Columns.Add("");

            CurrentRodada = ctx.Rodadas.First();
        }
        int rodada = 0;
        private void AdmForm_Load(object sender, EventArgs e)
        {
            LoadNotify();
            LoadGames();
            labelInicio.Text = $"{CurrentRodada.DataInicio.ToShortDateString()}";
            labelTermino.Text = CurrentRodada.DataInicio.AddDays(1).ToShortDateString();
        }

        private void LoadGames()
        {
            dt.Rows.Clear();
            var jogos = CurrentRodada.Jogos.ToList();
            label3.Text = $"Rodada {rodada+1}";
            foreach (var item in jogos)
            {
                dt.Rows.Add(item.Id,item.Data.Value.ToShortDateString(), item.Data.Value.ToShortTimeString(), item.Seleco.Nome, item.PlacarCasa, "X",item.PlacarVisitante,item.Seleco1.Nome,"Atualizar Placar");
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void LoadNotify()
        {
            flowLayoutPanel1.Controls.Clear();
            label2.Text = $"{ctx.Notificacoes.Count()} Notificações";
            foreach (var item in ctx.Notificacoes.OrderByDescending(x => x.DataHoraEnvio))
            {
                var c = new NotifyControl(item); 
                flowLayoutPanel1.Controls.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InsertNotificationForm().ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                button1.Visible  = label2.Visible = false;
            }
            else
                button1.Visible = label2.Visible = true;
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            rodada += 1;
            if (rodada == ctx.Rodadas.Count())
            {
                    rodada = rodada-1;
                    "It's the maximum".Alert();
            }
            CurrentRodada = ctx.Rodadas.ToList()[rodada];
            LoadGames();
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            rodada -= 1;
            if (rodada == -1)
            {
                rodada = 0;
                "It's the minimum".Alert();
            }

            CurrentRodada = ctx.Rodadas.ToList()[rodada];
            LoadGames();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            var rodadaCad = new Rodada();
            rodadaCad.DataInicio = ctx.Rodadas.ToList().Last().DataInicio.AddDays(7);
            var rod = ctx.Rodadas.Add(rodadaCad);
            ctx.SaveChanges();
            var ids = ctx.Selecoes.Select(x => x.Id).ToList();
            for (int i = 0; i < ids.Count(); i++)
            {
                for (int j = ids.Count()-1; j > i; j--) 
                {
                    Jogo jogo = new Jogo();
                    jogo.SelecaoCasaId = ids[i];
                    jogo.SelecaoVisitanteId = ids[j];
                    jogo.RodadaId = rod.Id;
                    ctx.Jogos.Add(jogo);
                }
            }
            ctx.SaveChanges() ;
            

            ctx.SaveChanges();
            var data = rodadaCad.DataInicio;
            while (data.DayOfWeek != DayOfWeek.Saturday)
                data = data.AddDays(1);
            data = data.Date + TimeSpan.FromHours(8);
            int count = 0;

            foreach (var item in ctx.Jogos.Where(x => x.Data == null))
            {
                item.Data = data;
                ctx.Entry(item).CurrentValues.SetValues(item);
                count++;
                data = data.AddHours(2);

                if (count % 4 != 0)
                    continue;

                data = data.AddDays(1);
                if (data.DayOfWeek == DayOfWeek.Sunday)
                {
                    data = data.Date + TimeSpan.FromHours(8);
                    continue;
                }
                data = data.AddDays(5);
                data = data.Date + TimeSpan.FromHours(8);
            }
            ctx.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
