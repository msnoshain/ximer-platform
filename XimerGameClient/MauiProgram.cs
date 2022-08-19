using CommunityToolkit.Maui;
using XimerGame.Shared.Helpers.Abstract;
using XimerGame.Client.Models.Helpers;
using XimerGame.Client.ViewModels.Account;
using XimerGame.Client.ViewModels.Common;
using XimerGame.Client.Views.Account;
using XimerGame.Client.Views.Common;

namespace XimerGame.Client;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit();

        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoadingViewModel>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<GameListPage>();
        builder.Services.AddSingleton<GameListViewModel>();
        builder.Services.AddSingleton<MatchHallPage>();
        builder.Services.AddSingleton<MatchHallViewModel>();
        builder.Services.AddSingleton<UserInfoPage>();
        builder.Services.AddSingleton<UserInfoViewModel>();

        builder.Services.AddSingleton<IAccountHelper, AccountHelper>();
        builder.Services.AddSingleton<IConfigurationHelper, ConfigurationHelper>();

        return builder.Build();
    }
}