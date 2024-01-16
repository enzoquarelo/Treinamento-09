using Desktop2.Models;
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
    public partial class InsertNotificationForm : parent
    {
        public InsertNotificationForm()
        {
            InitializeComponent();
        }

        public InsertNotificationForm(Notificaco item)
        {
            InitializeComponent();
            Item = item;
            textBox1.Text = item.Titulo;
            textBox2.Text = item.Descricao;
        }

        public Notificaco Item { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            Notificaco not = new Notificaco();
            not.Titulo = textBox1.Text;
            not.Descricao = textBox2.Text;  
            if (comboBox1.SelectedItem != null)
            not.SelecaoId = ctx.Selecoes.First(x => x.Nome == comboBox1.SelectedItem.ToString()).Id;            
            not.Importancia = comboBox2.SelectedItem.ToString();
            not.DataHoraCadastro = DateTime.Now;
            not.DataHoraEnvio = new DateTime();
            ctx.Notificacoes.Add(not);
            ctx.SaveChanges();
        }

        private void InsertNotificationForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
        }

        private void LoadCombo()
        {
            comboBox1.Items.Add("Nenhum");
            comboBox1.Items.AddRange(ctx.Selecoes.Select(x => x.Nome).ToArray());

            comboBox2.Items.Add("Padrão");
            comboBox2.Items.Add("Urgente");

            if (Item == null) return;
            comboBox2.SelectedItem = Item.Importancia;
            comboBox1.SelectedItem = Item.Seleco.Nome;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            button1.Enabled = IsFilled();
        }

        private bool IsFilled()
        {
            return !(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || comboBox2.SelectedItem == null ||dateTimePicker2.Value == null ||dateTimePicker2.Value.Hour == 0);
        }
    }
}
