
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class Superglue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Superglue");
            Tooltip.SetDefault("It contains a mysterious white sticky substance with adhesive properties");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.value = 500;
            base.SetDefaults();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddIngredient(ItemID.Gel, 50);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Bottle, 1);
            recipe2.AddIngredient(ItemID.TissueSample, 10);
            recipe2.AddTile(TileID.AlchemyTable);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.Bottle, 1);
            recipe3.AddIngredient(ItemID.ShadowScale, 10);
            recipe3.AddTile(TileID.AlchemyTable);
            recipe3.SetResult(this);
            recipe3.AddRecipe();
        }
    }
}