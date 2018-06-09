using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class IronKnives : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Knives");
            Tooltip.SetDefault("Uses Throwing Knives and Darts"
            +"\n does 10 damage total");
        }
        public override void SetDefaults()
        {
            item.damage = 2;
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 8;
            item.UseSound = SoundID.Item39;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("IronKnivesAnim");
            item.shootSpeed = 15f;
            item.useAmmo = AmmoID.Dart;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numProjectiles2 = 3 + player.GetModPlayer<ExamplePlayer>().ExtraProj;
            Random random = new Random();
            int ran = random.Next(10, 35);
            float spread = MathHelper.ToRadians(ran);
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
            double deltaAngle = spread / (float)numProjectiles2;
            double offsetAngle;

            for (int j = 0; j < numProjectiles2; j++)
            {
                offsetAngle = startAngle + deltaAngle * j;
                Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), type, damage, knockBack, player.whoAmI);
            }

            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 4);
            recipe.anyIronBar = true;
            recipe.AddIngredient(mod.GetItem("IronKnivesMold"));
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnCraft(Recipe recipe)
        {
            Item.NewItem(Main.LocalPlayer.getRect(), mod.ItemType("IronKnivesMold"));
            base.OnCraft(recipe);
        }

    }

}
