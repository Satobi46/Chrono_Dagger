using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ExampleHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<ExampleBreastplate>() && legs.type == ModContent.ItemType<ExampleLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "trollface.jpg";
			player.AddBuff(BuffID.Cursed, 2);
			player.AddBuff(BuffID.Darkness, 2);
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteHeadgear, 1);
            recipe.AddIngredient(ItemID.AdamantiteHelmet, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}