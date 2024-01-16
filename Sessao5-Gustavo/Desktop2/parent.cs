using Desktop2.Models;
using System;
using System.CodeDom;
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
    public partial class parent : Form
    {
        public Sessao5Entities ctx = new Sessao5Entities();
        public string videosFolder = AppDomain.CurrentDomain.BaseDirectory + "Videos";

        public string ADM = "0";
        public string USER = "1";
        public parent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void parent_Load(object sender, EventArgs e)
        {
            PutStyle(panel1);
        }

        private void PutStyle(Control panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Panel || c is FlowLayoutPanel || c is UserControl || c is GroupBox || c is TabControl || c is TabPage)
                {
                    PutStyle(c);
                }
                if (c is ComboBox combo)
                {
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (c is DataGridView dgv)
                {
                    dgv.AllowUserToAddRows = false;
                    dgv.ReadOnly = true;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgv.RowHeadersVisible = false;
                }
            }
        }
    }
}
