using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace XimerGameClient.ViewModels.Account;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string title = "Ximer Game - 登录";

    [RelayCommand]
    private void GetT(object sender)
    {
        var cp = sender as Shell;
        cp.FlyoutBehavior = FlyoutBehavior.Flyout;
    }
}
