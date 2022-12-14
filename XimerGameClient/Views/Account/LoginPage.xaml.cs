using XimerGame.Shared.Extentions;
using XimerGame.Client.Resources.ControlTemplates;
using XimerGame.Client.ViewModels.Account;

namespace XimerGame.Client.Views.Account;

//[QueryProperty(nameof(LoginForm), "LoginForm")]
public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        //Shell.Current.DisplayAlert("123", LoginForm.ToJson(), "Cancel");
        //loginViewModel.Account = LoginForm.account;
        //loginViewModel.Password = LoginForm.password;
        //loginViewModel.AutoLogin = LoginForm.autoLogin;
        //if (LoginForm.autoLogin)
        //    loginViewModel.RememberPassword = true;
        //else
        //    loginViewModel.RememberPassword = false;

        BindingContext = loginViewModel;
    }

    //(string account, string password, bool rememberPassword, bool autoLogin) LoginForm { get; set; }
}