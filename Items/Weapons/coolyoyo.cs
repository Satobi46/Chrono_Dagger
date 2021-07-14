using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class coolyoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(" Kagerou Yooo! ");
            Tooltip.SetDefault("Burn in the flame with this Yoo-Yooo!\nDamage = 100\nBuffs = OnFire");
            // These are all related to gamepad controls and don't seem to affect anything else
            //ItemID.Sets.Yoyo[item.type] = true;
            //ItemID.Sets.GamepadExtraRange[item.type] = 20;
            //ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 20f;
            item.knockBack = 5.5f;
            item.damage = 100;
            item.crit = 20;
            item.rare = ItemRarityID.Orange;
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.value = 20000;
            item.shoot = ModContent.ProjectileType<Projectiles.ExampleYoyoProjectile>();
            item.buffType = BuffID.Ichor;
            item.buffTime = 10;
            //item.shoot = ProjectileID.Terrarian;
            //item.shoot = ModContentProjectileType<coolyoyo2>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amarok, 1);
            recipe.AddIngredient(ItemID.Fireblossom, 20);
            recipe.AddIngredient(ItemID.PlatinumCoin, 20);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}