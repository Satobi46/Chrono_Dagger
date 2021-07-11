//using ExampleMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items
{
	public class ExamplePet : ModItem
	{
		public override void SetStaticDefaults() {
            // DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
            // DisplayName.SetDefault("Paper Airplane");
            // Tooltip.SetDefault("Summons a Paper Airplane to follow aimlessly behind you");
            DisplayName.SetDefault(" Chronos ");
        }

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = ModContent.ProjectileType<Projectiles.Pets.ExamplePet>();
			item.buffType = ModContent.BuffType<Buffs.ExamplePet>();
		}

		public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(ItemID.Terrarian, 1);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}