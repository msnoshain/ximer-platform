using XimerGame.Shared.Helpers.Abstract;
using XimerGame.Shared.Models.Entities;
using XimerGame.Shared.Models.Results;

namespace XimerGameClient.Models.Helpers;

public class AccountHelper : IAccountHelper
{
    public Task<ResultWithContent<object>> LoginAsync(string account, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Result> LogoutAsync(string account, string password)
    {
        throw new NotImplementedException();
    }

    public Task<ResultWithContent<object>> RegisterAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<Result> UnregisterAsync(string account, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateInfoAsync(string account, string password, User newUser)
    {
        throw new NotImplementedException();
    }
}
