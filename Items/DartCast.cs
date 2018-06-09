using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class DartCast : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Throwing Knives Cast");
            Tooltip.SetDefault("Hmm... Maybe I could put something in this");
        }

        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.IronBar, 1);
                recipe.anyIronBar = true;
                recipe.AddIngredient(mod.GetItem("Hammer"));
                recipe.AddTile(mod.GetTile("KnifeBench"));
                recipe.SetResult(this);
                recipe.AddRecipe();
        }
        public override void OnCraft(Recipe recipe)
        {
            Item.NewItem(Main.LocalPlayer.getRect(), mod.ItemType("Hammer"));
            base.OnCraft(recipe);
        }
    }
}