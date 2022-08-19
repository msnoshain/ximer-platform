using XimerGameClient.ViewModels.Common;

namespace XimerGameClient.Views.Common;

public partial class MatchHallPage : ContentPage
{
	public MatchHallPage(MatchHallViewModel matchHallViewModel)
	{
		InitializeComponent();
		BindingContext = matchHallViewModel;

    }
}