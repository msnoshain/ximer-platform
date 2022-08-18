using XimerGame.Shared.Models.Entities;
using XimerGame.Shared.Models.Results;

namespace XimerGame.Shared.Helpers.Abstract;

public interface IAccountHelper
{
    Task<ResultWithContent<object>> LoginAsync(string account, string password);

    Task<ResultWithContent<object>> RegisterAsync(User user);

    Task<Result> UnregisterAsync(string account, string password);

    Task<Result> LogoutAsync(string account, string password);

    Task<Result> UpdateInfoAsync(string account, string password, User newUser);
}
