using XimerGame.Shared.Models.Results;

namespace XimerGame.Shared.Helpers.Abstract;

public interface IConfigurationHelper
{
    string Username { get; set; }

    string Password { get; set; }

    bool RememberPassword { get; set; }

    bool Autologin { get; set; }

    (string username, string password) UserLoginInfo { get; set; }

    (string username, string password, bool rememberPassword, bool autoLogin) LoginForm { get; set; }

}
