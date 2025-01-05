using Aron.OpenLoopMiner.Extensions;
using Aron.OpenLoopMiner.Models;
using System.Text.Json.Serialization;
using Aron.NetCore.Util.Extensions;
using static Aron.NetCore.Util.Extensions.ServiceExtensions;
using Aron.OpenLoopMiner.ViewModels;
using Aron.NetCore.Util.ViewModels;

namespace Aron.OpenLoopMiner.Services
{
    [JsonSourceGenerationOptions
        (
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = new[] { typeof(JsonStringEnumConverter), typeof(DateTimeConverter) }
        )]
    [JsonSerializable(typeof(MinerRecord))]
    [JsonSerializable(typeof(ResponseResult<LoginResp>))]
    [JsonSerializable(typeof(RequestResult<LoginReq>))]
    [JsonSerializable(typeof(ResponseResult<string>))]
    public partial class MyJsonContext : JsonSerializerContext
    {
        
    }
}
