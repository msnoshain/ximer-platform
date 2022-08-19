using XimerGame.Client.ViewModels.Account;

namespace XimerGame.Client.Views.Account;

public partial class UserInfoPage : ContentPage
{
    public UserInfoPage(UserInfoViewModel userInfoViewModel)
    {
        InitializeComponent();

        userInfoViewModel.SyncInfoFromGlobalState();

        BindingContext = userInfoViewModel;
    }
}