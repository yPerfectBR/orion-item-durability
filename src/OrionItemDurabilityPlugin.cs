using Orion.PluginContracts;

namespace OrionItemDurability;

public sealed class OrionItemDurabilityPlugin : IOrionPlugin
{
    public string Id => "orion:item-durability";

    public Version Version { get; } = new(1, 0, 0);

    public void Load(IPluginLoadContext context)
    {
        var assembly = typeof(OrionItemDurabilityPlugin).Assembly;
        context.Registries.ItemTraits.RegisterFromAssembly(assembly, Id);
    }

    public void OnEnable(IPluginContext context) => _ = context;

    public void OnWorldInitialize(IWorldInitContext context) => _ = context;

    public void OnDisable(IPluginContext context) => _ = context;
}
