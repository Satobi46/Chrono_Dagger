using chronodagger.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
    public class VineSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ivy Vine Spear");
            Tooltip.SetDefault("A green stick with a sharp thing on it's tip");
        }

        public override void SetDefaults()
        {
            item.damage = 67;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 3.7f;
            item.knockBack = 10.5f;
            item.width = 35;
            item.height = 35;
            item.scale = 1f;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(gold: 10);

            item.melee = true;
            item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
            item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
            item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

            item.UseSound = SoundID.Item1;
            item.shoot = ModContent.ProjectileType<SpearVine>();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            base.OnHitNPC(player, target, damage, knockBack, crit);
            target.AddBuff(BuffID.WeaponImbuePoison, 60);
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }
    }
}
