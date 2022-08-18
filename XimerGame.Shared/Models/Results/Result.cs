using XimerGame.Shared.Extentions;
using XimerGame.Shared.Models.Enums;

namespace XimerGame.Shared.Models.Results;

public class Result
{
    public Result()
    {

    }

    public Result(Result result)
    {
        Message = result.Message;
        StatusCode = result.StatusCode;
        SourceException = result.SourceException;
    }

    /// <summary>
    /// 消息
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// 操作状态码
    /// </summary>
    public Code StatusCode { get; set; } = Code.Undefined;

    /// <summary>
    /// 获取操作是否成功执行
    /// </summary>
    public bool Succeed => StatusCode == Code.Succeed;

    /// <summary>
    /// 引发错误结果的原始异常
    /// </summary>
    public Exception? SourceException { get; set; }

    public override string ToString() => this.ToJson();
}
