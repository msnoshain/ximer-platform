using XimerGame.Shared.Helpers;
using XimerGame.Shared.Helpers.Abstract;
using XimerGame.Shared.Models.Entities;
using XimerGame.Shared.Models.Enums;
using XimerGame.Shared.Models.Results;
using XimerGame.Shared.Validators;

namespace XimerGameClient.Models.Helpers;

public class AccountHelper : IAccountHelper
{
    public async Task<ResultWithContent<object>> LoginAsync(string account, string password)
    {
        if(ValidationHelper.TryValidate(typeof(AccountValidator), out _, account) &&
           ValidationHelper.TryValidate(typeof(PasswordValidator), out _, password))

        {
            //获取user信息
            var user = new User()
            {
                Account = account,
                Password= password,
            };

            GlobalStateManager.CurrentUser = user;

            return new ResultWithContent<object>()
            {
                StatusCode = Code.Succeed,
            };
        }

        return new ResultWithContent<object>()
        {
            StatusCode = Code.IllegalArgs,
            Message = "测试错误",
        };
    }

    public async Task<Result> LogoutAsync(string account, string password)
    {
        return new Result();
    }

    public async Task<ResultWithContent<object>> RegisterAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UnregisterAsync(string account, string password)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UpdateInfoAsync(string account, string password, User newUser)
    {
        throw new NotImplementedException();
    }
}
