namespace XimerGame.Shared.Resources;

public static class ConfigurationKey
{
    public static string Username { get; } = nameof(Username);

    public static string Password { get; } = nameof(Password);

    public static string RememberPassword { get; } = nameof(RememberPassword);

    public static string Autologin { get; } = nameof(Autologin);
}
