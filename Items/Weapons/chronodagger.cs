using IL.Terraria;
using chronodagger.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class chronodagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Book of Chronos");
            Tooltip.SetDefault("[c/FF0000:A cursed book!]\n Recipe = Book of Skulls + Golden Shower + Crystal Storm");
        }

        public override void SetDefaults()
        {
            // item.scale = 10; //
            item.damage = 129;
            item.melee = false;
            item.ranged = true;
            item.shopSpecialCurrency = ItemID.Acorn;
            item.crit = 20;
            item.width = 30;
            item.height = 30;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 200000;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item30;
            item.autoReuse = true;
            //item.projectile = ???
            //item.shoot = ProjectileID.Daybreak; Noonononoonon
            //item.shoot = ProjectileID.MagicMissile;
            item.shoot = item.shoot = ModContent.ProjectileType<ChronoBlast>();
            item.shootSpeed = 10.5f;
            item.useStyle = ItemUseStyleID.HoldingOut;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BookofSkulls, 1);
            recipe.AddIngredient(ItemID.GoldenShower, 1);
            recipe.AddIngredient(ItemID.CrystalStorm, 1);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}