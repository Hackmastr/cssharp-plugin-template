using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace PluginName;

public class PluginNameConfig : BasePluginConfig
{
    [JsonPropertyName("ConfigName")] 
    public string ConfigName { get; set; } = "value";

    [JsonPropertyName("ConfigNameSecond")]
    public string ConfigNameSecond { get; set; } = "value";
}