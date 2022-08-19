using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using XimerGame.Shared.Extentions;
using XimerGame.Shared.Helpers.Abstract;

namespace XimerGameClient.ViewModels.Account;

public partial class LoginViewModel : ObservableObject, IQueryAttributable
{
    public LoginViewModel(IAccountHelper accountHelper, IConfigurationHelper configurationHelper)
    {
        AccountHelper = accountHelper;
        ConfigurationHelper = configurationHelper;
    }

    IAccountHelper AccountHelper { get; set; }

    IConfigurationHelper ConfigurationHelper { get; set; }

    [ObservableProperty]
    string title = "Ximer Game - 登录";

    [ObservableProperty]
    string account = string.Empty;

    [ObservableProperty]
    string password = string.Empty;

    [ObservableProperty]
    string errorText = string.Empty;

    [ObservableProperty]
    bool rememberPassword = false;

    private bool autoLogin = false;

    public bool AutoLogin
    {
        get => autoLogin;
        set
        {
            SetProperty(ref autoLogin, value);
            if (value) RememberPassword = true;
        }
    }


    [RelayCommand]
    async Task LoginAsync()
    {
        ErrorText = string.Empty;

        var loginResult = await AccountHelper.LoginAsync(Account, Password);

        if (!loginResult.Succeed)
        {
            ErrorText = loginResult.Message;
            return;
        }

        ConfigurationHelper.LoginForm = (Account, Password, RememberPassword, AutoLogin);

        await Shell.Current.GoToAsync("///GameListPage");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var form = (query["LoginForm"] as (string acct, string psd, bool rem, bool auto)?).Value;

        (Account, Password, RememberPassword, AutoLogin) = form;
    }
}
