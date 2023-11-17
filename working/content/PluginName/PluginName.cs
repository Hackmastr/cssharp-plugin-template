using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace PluginName;


[MinimumApiVersion(43)]
public class PluginName : BasePlugin, IPluginConfig<PluginNameConfig>
{
    public override string ModuleName => "plugin name";
    public override string ModuleAuthor => "author";
    public override string ModuleVersion => "0.0.1";
    
    
    public PluginNameConfig Config { get; set; } = new ();
    
    public void Load(bool hotReload)
    {
        
    }
    
    public void Unload(bool hotReload)
    {
        
    }
    
    public void OnConfigParsed(PluginNameConfig config)
    {
        this.Config = config;
    }
}

