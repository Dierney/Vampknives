using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
	public class Dart : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Throwing Knives");
            Tooltip.SetDefault("Fit Snug Into the Metal Fan's Chambers");
        }

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 0;
			item.rare = 2;
			item.shoot = mod.ProjectileType("DartAnim");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 6f;                  //The speed of the projectile
			item.ammo = AmmoID.Dart;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.anyIronBar = true;
            recipe.AddIngredient(mod.GetItem("DartCast"));
			recipe.AddTile(null, "KnifeBench");
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
        public override void OnCraft(Recipe recipe)
        {
            Item.NewItem(Main.LocalPlayer.getRect(), mod.ItemType("DartCast"));
            base.OnCraft(recipe);
        }
    }
}
