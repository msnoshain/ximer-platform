using XimerGame.Shared.Helpers.Abstract;

namespace XimerGame.Client.Models.Helpers;

public class ConfigurationHelper : IConfigurationHelper
{
    public string Account
    {
        get => Preferences.Default.Get(nameof(Account), "");
        set => Preferences.Default.Set(nameof(Account), value);
    }

    public string Password
    {
        get => Preferences.Default.Get(nameof(Password), "");
        set => Preferences.Default.Set(nameof(Password), value);
    }

    public bool RememberPassword
    {
        get => Preferences.Default.Get(nameof(RememberPassword), false);
        set => Preferences.Default.Set(nameof(RememberPassword), value);
    }

    public bool Autologin
    {
        get => Preferences.Default.Get(nameof(Autologin), false);
        set => Preferences.Default.Set(nameof(Autologin), value);
    }

    public (string account, string password) UserLoginInfo
    {
        get => (Account, Password);
        set => (Account, Password) = value;
    }

    public (string account, string password, bool rememberPassword, bool autoLogin) LoginForm
    {
        get => (Account, Password, RememberPassword, Autologin);
        set => (Account, Password, RememberPassword, Autologin) = value;
    }
}
