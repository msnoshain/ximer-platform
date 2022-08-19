using CommunityToolkit.Mvvm.ComponentModel;

namespace XimerGameClient.ViewModels.Common;

public partial class MatchHallViewModel : ObservableObject
{
    [ObservableProperty]
    string title = "匹配大厅";
}
