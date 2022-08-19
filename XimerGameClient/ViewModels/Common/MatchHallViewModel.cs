using CommunityToolkit.Mvvm.ComponentModel;

namespace XimerGame.Client.ViewModels.Common;

public partial class MatchHallViewModel : ObservableObject
{
    [ObservableProperty]
    string title = "匹配大厅";
}
