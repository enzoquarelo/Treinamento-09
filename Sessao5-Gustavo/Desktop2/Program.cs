using Desktop2.Models;
using Desktop2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop2
{
    internal static class Program
    {
        public static Sessao5Entities ctx = new Sessao5Entities();
        public static Settings settings = Settings.Default;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }

    public static class ME
    {
        public static DialogResult Alert(this string text)
        {
            return MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Information(this string text)
        {
            return MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirmation(this string text)
        {
            return MessageBox.Show(text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
