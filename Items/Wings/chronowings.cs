using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class chronowings : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(" Wings of Chronos ");
            Tooltip.SetDefault(" Mobility, Speed and Death! ");
        }

        public override void SetDefaults() {
            item.width = 22;
            item.height = 20;
            item.value = 200000;
            item.rare = ItemRarityID.Expert;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 200;

            // These can only out on Horizontal / Vertical wings. Examples Below
            //player.HorizontalWingSpeeds = 120;
            //player.VerticalWingSpeeds = 120;
        }
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            base.HorizontalWingSpeeds(player, ref speed, ref acceleration);
            speed = 9f;
            acceleration = 20.5f;
        }
        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            base.VerticalWingSpeeds(player, ref ascentWhenFalling, ref ascentWhenRising, ref maxCanAscendMultiplier, ref maxAscentMultiplier, ref constantAscend);
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }
    
		public override void AddRecipes() {
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