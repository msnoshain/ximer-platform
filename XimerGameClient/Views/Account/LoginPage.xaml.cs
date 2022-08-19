using XimerGameClient.Resources.ControlTemplates;
using XimerGameClient.ViewModels.Account;

namespace XimerGameClient.Views.Account;

[QueryProperty(nameof(LoginForm), "LoginForm")]
public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();

        loginViewModel.Account = LoginForm.account;
        loginViewModel.Password = LoginForm.password;
        loginViewModel.AutoLogin = LoginForm.autoLogin;
        if (LoginForm.autoLogin)
            loginViewModel.RememberPassword = true;
        else
            loginViewModel.RememberPassword = false;

        BindingContext = loginViewModel;
    }

    (string account, string password, bool rememberPassword, bool autoLogin) LoginForm { get; set; }
}