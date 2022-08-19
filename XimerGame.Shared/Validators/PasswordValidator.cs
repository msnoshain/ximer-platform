using CommunityToolkit.Diagnostics;
using XimerGame.Shared.Validators.Abstract;

namespace XimerGame.Shared.Validators;

public class PasswordValidator : ISingleValueValidator<string>
{
    public void Validate(string value)
    {
        Guard.IsNotNullOrEmpty(value);
        Guard.IsNotNullOrWhiteSpace(value);
        Guard.HasSizeLessThanOrEqualTo(value, 32);
    }
}
