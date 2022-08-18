using XimerGame.Shared.Helpers.Abstract;

namespace XimerGameClient.Models.Helpers;

public class ConfigurationHelper : IConfigurationHelper
{
    public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool RememberPassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Autologin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public (string username, string password) UserLoginInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public (string username, string password, bool rememberPassword, bool autoLogin) LoginForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
