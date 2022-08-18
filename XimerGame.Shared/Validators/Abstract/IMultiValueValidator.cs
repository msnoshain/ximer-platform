namespace XimerGame.Shared.Validators.Abstract;

public interface IMultiValueValidator
{
    void Validate(params object[] value);
}
