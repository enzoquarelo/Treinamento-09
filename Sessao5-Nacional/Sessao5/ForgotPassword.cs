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
    public partial class ForgotPassword : parent
    {
        private bool passValid;

        public ForgotPassword()
        {
            InitializeComponent();
            button1.Enabled = false;

            textBox1.TextChanged += TxtChanged;
            textBox2.TextChanged += TxtChanged;

            textBox1.TextChanged += TxtChanged1;
            passValid = button1.Enabled = textBox1.Enabled = textBox2.Enabled = false;

        }

        private void TxtChanged1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 15 || textBox1.Text.Any(x => char.IsUpper(x)) || textBox1.Text.Any(x => char.IsSymbol(x)))
            {
                passValid = button1.Enabled = false;
            }
            else 
                passValid = button1.Enabled = true;

            textBox3.BackColor = Color.Green;
            textBox3.Text = "Forte";
            var repetition1 = textBox1.Text.GroupBy(x => x).Any(g => g.Count() == 2);
            var repetition2 = textBox1.Text.GroupBy(x => x).Any(g => g.Count() > 2);

            if (repetition1) 
            { 
                textBox3.BackColor = Color.Yellow;
                textBox3.Text = "Medio";
            }
            if (repetition2)
            {
                textBox3.BackColor = Color.Red;
                textBox3.Text = "Fraca";
            }

            
        }

        private void TxtChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                textBox4.BackColor = Color.Green;
                textBox4.Text = "Senhas identicas";
                passValid = true;
            }
            else 
            {
                textBox4.Text = "Senhas nao correspondem";
                textBox4.BackColor = Color.Red;
                passValid = false;
            }
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(ctx.Selecoes.Select(x=> x.Nome).ToArray());
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() != Dados.Logged.Seleco.Nome ||
                dateTimePicker1.Value.Date != Dados.Logged.Nascimento.Date) 
            {
                textBox1.Enabled = textBox2.Enabled = false;
            }
            else
                textBox1.Enabled = textBox2.Enabled = true;




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!passValid) return;

            var user = ctx.Usuarios.Find(Dados.Logged.Id);
            user.Senha = textBox1.Text;
            ctx.Entry(user).CurrentValues.SetValues(user);
            ctx.SaveChanges();

            "Success!".Information();
            this.Close();
        }
    }
}
