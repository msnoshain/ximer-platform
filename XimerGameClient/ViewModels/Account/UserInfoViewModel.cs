using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using XimerGame.Shared.Helpers.Abstract;
using XimerGame.Shared.Models.Entities;

namespace XimerGameClient.ViewModels.Account;

public partial class UserInfoViewModel : ObservableObject
{
    public UserInfoViewModel(IAccountHelper accountHelper, IConfigurationHelper configurationHelper)
    {
        AccountHelper = accountHelper;
        ConfigurationHelper = configurationHelper;
    }

    IAccountHelper AccountHelper { get; set; }

    IConfigurationHelper ConfigurationHelper { get; set; }

    [ObservableProperty]
    string title = "我的账户";

    [ObservableProperty]
    User currentUser = User.NoneUserInstance;

    [ObservableProperty]
    DateTime loginTime;

    public void SyncInfoFromGlobalState()
    {
        CurrentUser = GlobalStateManager.CurrentUser;
        LoginTime = GlobalStateManager.LoginTime;
    }

    [RelayCommand]
    async Task LogoutAsync()
    {
        await AccountHelper.LogoutAsync(CurrentUser.Account, CurrentUser.Password);

        await Shell.Current.GoToAsync("///LoginPage",
                new Dictionary<string, object>()
                {
                    { "LoginForm", (CurrentUser.Account, CurrentUser.Password, ConfigurationHelper.RememberPassword, ConfigurationHelper.Autologin)},
                });
        return;
    }
}
