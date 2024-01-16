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
    public partial class NotifyForm : parent
    {
        DataTable dt = new DataTable();
        public NotifyForm()
        {
            InitializeComponent();
            dt.Columns.Add("Data");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Importancia");
            dt.Columns.Add("Título");

            var notificacoes = Dados.Logged.NotificacoesUsuarios.Select(x=> x.Notificaco).ToList();
            notificacoes.AddRange(ctx.Notificacoes.ToList().Where(x => x.SelecaoId == Dados.Logged.TimeFavoritoId).ToList());

            foreach (var item in notificacoes)
            {
                dt.Rows.Add(item.DataHoraEnvio.Value.ToShortDateString(), item.DataHoraEnvio.Value.ToShortTimeString(),item.Importancia, item.Titulo);
            }
        }
    }
}
