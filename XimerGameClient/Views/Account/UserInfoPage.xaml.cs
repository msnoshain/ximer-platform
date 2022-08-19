using XimerGameClient.ViewModels.Account;

namespace XimerGameClient.Views.Account;

public partial class UserInfoPage : ContentPage
{
    public UserInfoPage(UserInfoViewModel userInfoViewModel)
    {
        InitializeComponent();

        userInfoViewModel.SyncInfoFromGlobalState();

        BindingContext = userInfoViewModel;
    }
}