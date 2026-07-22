using Orion.Api;
using Orion.Api.Items;
using Orion.Api.Traits;

namespace OrionItemDurability;

/// <summary>Durability marker/trait for items with <c>minecraft:durability</c> (wear logic stub, parity with core).</summary>
public sealed class ItemStackDurabilityTrait : ItemTraitBase
{
    public static string Identifier => "item_durability";

    public static readonly string[] Components = ["minecraft:durability"];

    public IItemStack ItemStack { get; }

    public ItemStackDurabilityTrait(IItemStack itemStack)
    {
        ItemStack = itemStack ?? throw new ArgumentNullException(nameof(itemStack));
    }

    /// <summary>Placeholder for future wear-on-use / break damage.</summary>
    public void ProcessDamage(IEntity _entity)
    {
    }
}
