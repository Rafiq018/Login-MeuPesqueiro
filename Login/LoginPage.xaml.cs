using Login;
using Microsoft.Maui.Controls;

namespace MeuPesqueiro.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string senha = SenhaEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert("Erro", "Preencha todos os campos!", "OK");
                return;
            }

            // Simula��o de login v�lido
            if (email == "teste@teste.com" && senha == "123")
            {
                await DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");

                // Troca a MainPage para a tela principal
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                await DisplayAlert("Erro", "Email ou senha inv�lidos", "OK");
            }
        }


        private async void OnCadastroClicked(object sender, EventArgs e)
        {
            
        }
    }
}
