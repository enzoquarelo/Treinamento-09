using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace MobileMG_Prova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        int invalidCount = 0;

        public LoginPage()
        {
            InitializeComponent();
            toastInvalid.IsVisible = false;
            erroBorderEntry.BorderColor = Color.Transparent;
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (usuarioInput.Text == "adm" && senhaInput.Text == "adm")
            {
                App.Current.MainPage = new HomePage();
            }
            else
            {
                invalidCount++;
                erroBorderEntry.BorderColor = Color.FromHex("#ff0000");
                if(invalidCount >= 3)
                {
                    usuarioInput.IsEnabled = btnLogin.IsEnabled = senhaInput.IsEnabled = false;
                    toastInvalid.Text = "Login bloqueado aguarde 30s";

                    await Task.Delay(30000);

                    usuarioInput.IsEnabled = senhaInput.IsEnabled  = btnLogin.IsEnabled = true;
                    toastInvalid.IsVisible = false;
                    toastInvalid.Text = "Usuário/Senha inválidos";
                    invalidCount = 0;
                }
                else if (invalidCount > 0 && invalidCount < 3)
                {
                    toastInvalid.IsVisible = true;
                }
            }
        }

        private void usuarioInput_Focused(object sender, FocusEventArgs e)
        {
            toastInvalid.IsVisible = false;
        }

        private void senhaInput_Focused(object sender, FocusEventArgs e)
        {
            toastInvalid.IsVisible = false;
        }
    }
}