using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace chronodagger.Dusts
{
	public class VineDust : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.velocity *= 0.5f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 1f;
		}

		public override bool Update(Dust dust) {
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.15f;
			dust.scale *= 0.99f;
			float light = 1.35f * dust.scale;
			Lighting.AddLight(dust.position, light, light, light);
			if (dust.scale < 0.5f) {
				dust.active = false;
			}
			return false;
		}
    }
}