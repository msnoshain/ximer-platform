using XimerGameClient.ViewModels.Common;

namespace XimerGameClient.Views.Common;

public partial class GameListPage : ContentPage
{
	public GameListPage(GameListViewModel gameListViewModel)
	{
		InitializeComponent();
		BindingContext = gameListViewModel;
	}
}