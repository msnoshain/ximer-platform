using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using XimerGame.Shared.Helpers.Abstract;

namespace XimerGameClient.ViewModels.Account;

public partial class LoginViewModel : ObservableObject
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
    bool rememberPassword=false;

    [ObservableProperty]
    bool autoLogin=false;

    [RelayCommand]
    async Task LoginAsync()
    {
        ErrorText = string.Empty;

        var loginResult = await AccountHelper.LoginAsync(account, password);

        if (!loginResult.Succeed)
        {
            ErrorText = loginResult.Message;
            return;
        }

        ConfigurationHelper.LoginForm = (Account, Password, RememberPassword, AutoLogin);

        await Shell.Current.GoToAsync("///GameListPage");
    }
}
