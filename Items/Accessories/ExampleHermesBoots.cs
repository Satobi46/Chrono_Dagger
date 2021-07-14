using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Accessories
{
    [AutoloadEquip(EquipType.Shoes)]
    public class ExampleHermesBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kaizen Powerboots");
            Tooltip.SetDefault("Wearing this makes you run super fast!\nDefense = +20\nBuffs = +Dryads Blessing");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.accessory = true; // Makes this item an accessory.
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(platinum: 50); // Sets the item sell price to one gold coin.
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 6f; // The player's maximum run speed with accessories.
            player.moveSpeed += 0.05f; // The acceleration multiplier of the player's movement speed.
            player.statDefense = 20; // The player's defense.
            player.AddBuff(BuffID.DryadsWard, 30 * 3000); // Dryad's Buff.

        }
    }
}