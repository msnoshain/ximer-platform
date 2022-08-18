namespace XimerGame.Shared.Models.Enums;

/// <summary>
/// 操作状态码
/// </summary>
public enum Code
{
    /// <summary>
    /// 未定义
    /// </summary>
    Undefined = -1,

    /// <summary>
    /// 成功
    /// </summary>
    Succeed = 0,

    /// <summary>
    /// 非法参数
    /// </summary>
    IllegalArgs = 1,

    /// <summary>
    /// 内部错误
    /// </summary>
    InternalFault = 2,

    /// <summary>
    /// 身份验证错误
    /// </summary>
    WrongValidation = 3,

    /// <summary>
    /// 第三方API未响应
    /// </summary>
    NoResponseFrom3rdPartyAPI = 4,

    /// <summary>
    /// 第三方API执行出错
    /// </summary>
    BadResultFrom3rdPartyAPI = 5,

    /// <summary>
    /// 无可用的查询结果
    /// </summary>
    NoQueryResult = 6,

    /// <summary>
    /// 数据库操作失败
    /// </summary>
    DBError = 7,
}
