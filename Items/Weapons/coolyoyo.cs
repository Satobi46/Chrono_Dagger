using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class coolyoyo : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(" Jojo's Yoyooo ");
            Tooltip.SetDefault("The Coolest Yo-Yooo!");

			// These are all related to gamepad controls and don't seem to affect anything else
			//ItemID.Sets.Yoyo[item.type] = true;
			//ItemID.Sets.GamepadExtraRange[item.type] = 20;
			//ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults() {
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 9;
			item.rare = ItemRarityID.Blue;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
            item.value = 2000;
            //item.shoot = ProjectileID.Terrarian;
            //item.shoot = ModContentProjectileType<coolyoyo2>();
            item.shoot = ModContent.ProjectileType<ExampleYoyoProjectile>();
		}

		public override void AddRecipes()
        { 
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(ItemID.Terrarian, 1);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}

