using CommunityToolkit.Mvvm.ComponentModel;
using XimerGame.Shared.Helpers.Abstract;

namespace XimerGameClient.ViewModels.Common;

public partial class LoadingViewModel : ObservableObject
{
    public LoadingViewModel(IAccountHelper accountHelper, IConfigurationHelper configurationHelper)
    {
        AccountHelper = accountHelper;
        ConfigurationHelper = configurationHelper;
    }

    IAccountHelper AccountHelper { get; set; }

    IConfigurationHelper ConfigurationHelper { get; set; }

    [ObservableProperty]
    string title = "加载中...";

    public async Task TryLoginAndNavigateAsync()
    {
        (string acct, string psw, bool rempsd, bool autolog) = ConfigurationHelper.LoginForm;

        var loginResult = await AccountHelper.LoginAsync(acct, psw);

        if (!loginResult.Succeed)
        {
            await Shell.Current.GoToAsync("///LoginPage",
                new Dictionary<string, object>()
                {
                    { "LoginForm", (acct, psw, rempsd, autolog)},
                });
            return;
        }

        await Shell.Current.GoToAsync("///GameListPage");

    }
}
