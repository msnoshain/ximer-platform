namespace XimerGame.Shared.Models.Results;

public class ResultWithContent<T> : Result
{
    public ResultWithContent()
    {

    }

    public ResultWithContent(ResultWithContent<T> result)
    {
        Message = result.Message;
        StatusCode = result.StatusCode;
        SourceException = result.SourceException;
        ResultObjects = result.ResultObjects;
    }

    /// <summary>
    /// 操作结果对象
    /// </summary>
    public T? ResultObjects { get; set; }

}
