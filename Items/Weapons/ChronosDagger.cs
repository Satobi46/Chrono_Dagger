using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class ChronosDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dagger of Chronos");
            Tooltip.SetDefault("The Ancient weapon of Chrono!\nDamage = 100\nBuffs = Frostburn, OgreSpit, Silenced");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.knockBack = 10;
            item.value = 50000;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.buffType = BuffID.Hunter;
            item.buffTime = 5;
            //item.shoot = ProjectileID.Bee;
            //item.shootSpeed = 5f;
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
        // adds buffs on the weapons and can be used on Projectiles.
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 30 * 3000);
            target.AddBuff(BuffID.OgreSpit, 30 * 3000);
            target.AddBuff(BuffID.Silenced, 30 * 3000);

        }
    }
}