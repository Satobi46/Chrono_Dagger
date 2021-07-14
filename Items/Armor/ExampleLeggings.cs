using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace chronodagger.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ExampleLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded leg armor."
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeetleLeggings, 1);
            recipe.AddIngredient(ItemID.FrostLeggings, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}