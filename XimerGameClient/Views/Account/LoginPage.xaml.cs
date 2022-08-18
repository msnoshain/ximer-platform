using XimerGameClient.Resources.ControlTemplates;
using XimerGameClient.ViewModels.Account;

namespace XimerGameClient.Views.Account;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
	}
}