using XimerGame.Shared.Models.Entities;

namespace XimerGame.Client;

public static class GlobalStateManager
{
    private static User currentUser = User.NoneUserInstance;

    public static User CurrentUser
    {
        get => currentUser;
        set
        {
            currentUser = value;
            if (currentUser != User.NoneUserInstance)
                LoginTime = DateTime.Now;
            else
                LoginTime = default;
        }
    }

    public static DateTime LoginTime { get; set; }
}
