using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace chronodagger.Items.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class magic_curse : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(" Cursed Wings ");
            Tooltip.SetDefault("A Cursed Magical Wings.\nCan dash on flight.");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = ItemRarityID.Expert;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 170;

            // These can only out on Horizontal / Vertical wings. Examples Below
            //player.HorizontalWingSpeeds = 120;
            //player.VerticalWingSpeeds = 120;
        }
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            base.HorizontalWingSpeeds(player, ref speed, ref acceleration);
            speed = 9f;
            acceleration = 1.5f;
            item.UseSound = SoundID.Item46;
            player.dash = 2; // If player can dash/dash. 1= Master Ninja Gear 2= Shield of Cthulhu.
            // ====> Satobi, Wing Dust Effects on Vertical/Horizontal FLight. Just like the Solar Flare Wings.
            Dust.NewDust(player.position, player.width, player.height, 171, 0f, 0f, 150, default, 1.5f);

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

        public override void AddRecipes()
        {
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
//====================== Dust Particles ==========================//
         //Wings dust effects.
       //public override bool WingUpdate(Player player, bool inUse)
        //{
            //Dust.NewDust(player.position, player.width, player.height, 179, 0f, 0f, 150, default, 1.5f); //the dust you want, I've found this one in the example
            //return true;
        //}
    //}
//}