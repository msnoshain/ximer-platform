namespace XimerGame.Shared.Models.Entities;

public class User
{
    public string Account { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public static User NoneUserInstance { get; } = new ();

}
