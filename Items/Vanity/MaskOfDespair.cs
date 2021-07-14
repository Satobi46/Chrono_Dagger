using chronodagger.Dusts;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace chronodagger.Items.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class MaskOfDespair : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rage!!!"
                + "\nThe Mask of Chronos Actor");
        }
        public override bool DrawHead()
        {
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShroomiteMask, 1);
            recipe.AddIngredient(ItemID.AdamantiteMask, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateVanity(Player player, EquipType type)
        {
            base.UpdateVanity(player, type);
            //Dust.NewDust(player.position, player.width, player.height, 226, 0f, 0f, 150, default, 0.5f); // Draws Particles // Draws Particle Count // Draws Particle Light //
            Dust.NewDust(player.position, player.width, player.height, ModContent.DustType<Sparkle>());
        }
        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            base.VerticalWingSpeeds(player, ref ascentWhenFalling, ref ascentWhenRising, ref maxCanAscendMultiplier, ref maxAscentMultiplier, ref constantAscend);
            //Dust.NewDust(player.position, player.width, player.height, ModContent.DustType<Sparkle>()); // Draws Particles when Jump.
            //Dust.NewDust(player.position, player.width, player.height, ModContent.DustType<Sparkle>());
        }
    }
}