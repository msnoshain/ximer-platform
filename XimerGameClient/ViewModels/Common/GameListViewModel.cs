using CommunityToolkit.Mvvm.ComponentModel;

namespace XimerGameClient.ViewModels.Common;

public partial class GameListViewModel : ObservableObject
{
    [ObservableProperty]
    string title = "游戏列表";
}
