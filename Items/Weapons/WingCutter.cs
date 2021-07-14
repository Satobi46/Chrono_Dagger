// ExampleMod.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
	public class WingCutter : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("The Wing Cutter");
            Tooltip.SetDefault("Big sword, Big future. " +
                "+%15 Crit"
                + "+ Damage 150");
		}

		public override void SetDefaults() {
			item.damage = 150;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 40000;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.SoulDrain;
			item.shootSpeed = 10f;
            item.crit = 20;
		}

		public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = ItemUseStyleID.Stabbing;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 100;
				item.shoot = ProjectileID.SoulDrain;
			}
			else {
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 160;
				item.shoot = ProjectileID.None;
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit) {
			if (player.altFunctionUse == 2) {
				target.AddBuff(BuffID.BrokenArmor, 60);
			}
			else {
				target.AddBuff(BuffID.Midas, 60);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				if (player.altFunctionUse == 2) {
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169, 0f, 0f, 100, default(Color), 2f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity.X += player.direction * 2f;
					Main.dust[dust].velocity.Y += 0.2f;
				}
				else {
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.FrostStaff, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
					Main.dust[dust].noGravity = true;
				}
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			// Fix the speedX and Y to point them horizontally.
			speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
			speedY = 0;
			// Add random Rotation
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
			// Change the damage since it is based off the weapons damage and is too high
			damage = (int)(damage * .1f);
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
	}
}