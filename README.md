# Orion Item Durability

**Durability** trait for items with the `minecraft:durability` component (`ProcessDamage` stub; wear-on-use can softdepend mining later).

- **Manifest id:** `orion:item-durability`
- **Provides:** `orion:item-durability`
- **SDK:** Orion.Api / PluginContracts **0.1.8+** (Api-only; no `Orion.dll`)

## Build

```bash
dotnet build OrionItemDurability.csproj -c Release
```

Deploy `plugin.json` and `orion.item-durability.dll` under `plugins/orion:item-durability/`.
