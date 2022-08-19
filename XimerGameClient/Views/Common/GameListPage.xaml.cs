using XimerGame.Client.ViewModels.Common;

namespace XimerGame.Client.Views.Common;

public partial class GameListPage : ContentPage
{
	public GameListPage(GameListViewModel gameListViewModel)
	{
		InitializeComponent();
		BindingContext = gameListViewModel;
	}
}