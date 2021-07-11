using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaID;
using Terraria.ModLoader;
using Terraria;


namespace chronodagger
{
    class MyProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.TerraBeam);
            projectile.name = "Terrabeam of Death";
            aiType = ProjectileID.TerraBeam;
        }

        public override bool Autoload(ref string name, ref string texture)
        {
            texture = "Terraria/Projectile_" + ProjectileID.TerraBeam;
            return true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60);
        }
    }
}
    }
}
