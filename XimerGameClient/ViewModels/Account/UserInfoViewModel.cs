using CommunityToolkit.Mvvm.ComponentModel;

namespace XimerGameClient.ViewModels.Account;

public partial class UserInfoViewModel : ObservableObject
{
    [ObservableProperty]
    string title = "我的账户";
}
