using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class CorruptionCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unstable Corruption Crystal");
            Tooltip.SetDefault("Seems to have corrupt energy pouring from its cracks");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(2, 9));
        }
        public override void SetDefaults()
        {
            item.maxStack = 10;
            item.value = 5000;
            item.rare = 11;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("CrimsonCrystal"), 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(mod.GetItem("CorruptionShard"), 5);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}