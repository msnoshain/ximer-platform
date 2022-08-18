using Newtonsoft.Json;

namespace XimerGame.Shared.Extentions;

public static class Converters
{
    public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj);

    public static T? ToObject<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
}
