using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace VampKnives.Items
{
    public class BloomingTerror : KnifeItem
    {
        ////TO CALL A MOD
        //Mod Calamity = ModLoader.GetMod("CalamityMod");
        public override void SetStaticDefaults()
        {
            ////IF MOD EXCLUSIVE
            //if (Calamity != null)
            //{
            //    DisplayName.SetDefault("KNIFENAME");
            //    Tooltip.SetDefault("KNIFEDESCRIPTION");
            //}
            //else
            //{
            //    DisplayName.SetDefault("KNIFENAME");
            //    Tooltip.SetDefault("Please enable Calamity");
            //}

            ////FOR ANIMATIONS
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 13));

            //Defaults
            DisplayName.SetDefault("Blooming Terror");
            Tooltip.SetDefault("It's growing out of control");
        }
        public override void SetDefaults()
        {
            item.damage = 25; //PUT DAMAGE, GENERALLY 1/2 OF COMPONENT'S DAMAGE
            item.ranged = true;
            item.width = 68;
            item.height = 68;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 50000; //10000 = 1 gold, 100 silver, or 10000 copper
            item.rare = 5; // -1 = Grey; 0 = White; 1 = Blue; 2 = Green; 3 = Orange; 4 = Light Red
            //5 = Pink; 6 = Light Purple; 7 = Lime; 8 = Yellow; 9 = Cyan; 10 = Red; 11 = Purple
            //-12 = Rainbow; -2 = Amber
            item.UseSound = SoundID.Item39; //Default 39
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BloomingTerrorProj");
            item.shootSpeed = 15f;
        }

        //public override void AddRecipes()
        //{
        //    ModRecipe recipe = new ModRecipe(mod);
        //    recipe.AddIngredient(ItemID.VANILLAITEM, NUMITEMS);
        //    recipe.AddIngredient(mod.GetItem("MODITEM"));
        //    recipe.AddTile(TileID.Furnaces);
        //    recipe.SetResult(this);
        //    recipe.AddRecipe();
        //}
    }

}
