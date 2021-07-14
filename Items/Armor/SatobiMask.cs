using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SatobiMask : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("The Mask of Satobi");
            Tooltip.SetDefault("You feel the ground shaking!"
                + "\n+50 Mana"
                + "\n+15 Defense");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Orange;
			item.defense = 15;
            item.manaIncrease = 50;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<ExampleBreastplate>() && legs.type == ModContent.ItemType<ExampleLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "trollface.jpg";
			player.AddBuff(BuffID.Ironskin, 2);
			player.AddBuff(BuffID.ShadowDodge, 2);
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumHeadgear, 1);
            recipe.AddIngredient(ItemID.NebulaHelmet, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}