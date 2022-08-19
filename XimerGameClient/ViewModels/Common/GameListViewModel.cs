using CommunityToolkit.Mvvm.ComponentModel;

namespace XimerGame.Client.ViewModels.Common;

public partial class GameListViewModel : ObservableObject
{
    [ObservableProperty]
    string title = "游戏列表";
}
