using CommunityToolkit.Diagnostics;
using XimerGame.Shared.Validators.Abstract;

namespace XimerGame.Shared.Validators;

/// <summary>
/// 用户名检查规则：Type=string, Length<=32
/// </summary>
/// <typeparam name="T"></typeparam>
public class UsernameValidator : ISingleValueValidator<string>
{
    public void Validate(string value)
    {
        Guard.IsNotNullOrWhiteSpace(value);
        Guard.HasSizeLessThanOrEqualTo(value.Trim(), 32);
    }
}
