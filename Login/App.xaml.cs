namespace Login;

public partial class App : Application
{
    public App()
    {
        InitializeComponent(); // <- só vai funcionar se o App.xaml estiver correto

        MainPage = new NavigationPage(new MeuPesqueiro.Views.LoginPage());
    }
}
