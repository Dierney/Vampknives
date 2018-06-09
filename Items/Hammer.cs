
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class Hammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forging Hammer");
            Tooltip.SetDefault("Used to hammer metals into shapes");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.anyWood = true;
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}