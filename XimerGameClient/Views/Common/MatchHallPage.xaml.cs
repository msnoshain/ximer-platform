using XimerGame.Client.ViewModels.Common;

namespace XimerGame.Client.Views.Common;

public partial class MatchHallPage : ContentPage
{
	public MatchHallPage(MatchHallViewModel matchHallViewModel)
	{
		InitializeComponent();
		BindingContext = matchHallViewModel;

    }
}