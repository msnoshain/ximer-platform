using XimerGame.Shared.Validators.Abstract;

namespace XimerGame.Shared.Helpers;

public static class ValidationHelper
{
    public static bool TryValidate(IMultiValueValidator validator, out string message, params object[] data)
    {
        try
        {
            validator.Validate(data);
        }
        catch (Exception e)
        {
            message = e.Message;
            return false;
        }

        message = string.Empty;
        return true;
    }

    public static bool TryValidate(Type validatorType, out string message, params object[] data)
    {
        if (validatorType.GetConstructor(Array.Empty<Type>())?.Invoke(Array.Empty<object>()) is not IMultiValueValidator validator)
        {
            throw new ArgumentException("Invalid Validator Type", nameof(validatorType));
        }

        return TryValidate(validator, out message, data);
    }

    public static bool TryValidate<T>(ISingleValueValidator<T> validator, out string message, T data)
    {
        try
        {
            validator.Validate(data);
        }
        catch (Exception e)
        {
            message = e.Message;
            return false;
        }

        message = string.Empty;
        return true;
    }

    public static bool TryValidate<T>(Type validatorType, out string message, T data)
    {
        if (validatorType.GetConstructor(Array.Empty<Type>())?.Invoke(Array.Empty<object>()) is not ISingleValueValidator<T> validator)
        {
            throw new ArgumentException("Invalid Validator Type", nameof(validatorType));
        }

        return TryValidate(validator, out message, data);
    }

}
