using XimerGame.ViewModels.Common;

namespace XimerGame.Views.Common;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingViewModel loadingViewModel)
	{
		InitializeComponent();
		BindingContext = loadingViewModel;
	}

	private async void ContentPage_Loaded(object sender, EventArgs e)
	{
		await (BindingContext as LoadingViewModel)?.TryLoginAndNavigateAsync();
    }
}