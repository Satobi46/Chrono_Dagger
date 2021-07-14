using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Weapons
{
	public class ThanatosSword : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Thanatos Sword");
            Tooltip.SetDefault("Sword of the Demon Knight!");
		}

		public override void SetDefaults() {
			//item.damage = 200;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 1000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bee;
			item.shootSpeed = 5f;
		}

		public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.TrueExcalibur, 1);
            recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
            recipe.AddTile(TileID.MythrilAnvil);
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
				item.damage = 150;
				item.shoot = ProjectileID.ClothiersCurse;
			}
			else {
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 30;
				item.useAnimation = 40;
				item.damage = 320;
				item.shoot = ProjectileID.None;
                item.knockBack = 10;
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit) {
			if (player.altFunctionUse == 2) {
				target.AddBuff(BuffID.Ichor, 60);
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
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
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