using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Projectiles.Pets
{
	public class ExamplePet : ModProjectile
	{
		public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Paper Airplane"); // Automatic from .lang files
            DisplayName.SetDefault("Cream");
            Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish
;
        }

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			HumanPlayer modPlayer = player.GetModPlayer<HumanPlayer>();
			if (player.dead) {
				modPlayer.examplePet = false;
			}
			if (modPlayer.examplePet) {
				projectile.timeLeft = 2;
			}
		}
	}
}