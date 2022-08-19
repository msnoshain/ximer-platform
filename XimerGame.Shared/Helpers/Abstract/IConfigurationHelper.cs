using XimerGame.Shared.Models.Results;

namespace XimerGame.Shared.Helpers.Abstract;

public interface IConfigurationHelper
{
    string Account { get; set; }

    string Password { get; set; }

    bool RememberPassword { get; set; }

    bool Autologin { get; set; }

    (string account, string password) UserLoginInfo { get; set; }

    (string account, string password, bool rememberPassword, bool autoLogin) LoginForm { get; set; }

}
