using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class chronodagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(" Book of Chronos ");
            Tooltip.SetDefault("[c/FF0000:A cursed book!]");
        }

        public override void SetDefaults()
        {
            // item.scale = 10; //
            item.damage = 129;
            item.melee = false;
            item.ranged = true;
            item.shopSpecialCurrency = ItemID.Acorn;
            item.crit = 30;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 12000;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item30;
            item.autoReuse = true;
            //item.useAmmo = ProjectileID.Daybreak; Noonononoonon
            item.shoot = ProjectileID.MagicMissile;
            item.shootSpeed = 20.5f;
            item.useTime = 10;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BloodyMachete, 1);
            recipe.AddIngredient(ItemID.VampireKnives, 1);
            recipe.AddIngredient(ItemID.GoldCoin, 20);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}