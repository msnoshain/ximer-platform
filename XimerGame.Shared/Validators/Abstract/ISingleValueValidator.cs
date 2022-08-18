namespace XimerGame.Shared.Validators.Abstract;

public interface ISingleValueValidator<T>
{
    void Validate(T value);
}
