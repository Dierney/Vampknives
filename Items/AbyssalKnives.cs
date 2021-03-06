﻿using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace VampKnives.Items
{
    public class AbyssalKnives : KnifeItem
    {
        //TO CALL A MOD
        Mod Calamity = ModLoader.GetMod("CalamityMod");
        public override void SetStaticDefaults()
        {
            //IF MOD EXCLUSIVE
            if (Calamity != null)
            {
                DisplayName.SetDefault("Abyssal Knives");
                Tooltip.SetDefault("it's calm... It's terrifying");
            }
            else
            {
                DisplayName.SetDefault("Abyssal Knives");
                Tooltip.SetDefault("Please enable Calamity");
            }

            //FOR ANIMATIONS
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 10));

            //Defaults
            //DisplayName.SetDefault("KNIFENAME");
            //Tooltip.SetDefault("KNIFEDESCRIPTION");
        }
        public override void SetDefaults()
        {
            item.damage = 38; //PUT DAMAGE, GENERALLY 1/2 OF COMPONENT'S DAMAGE
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 180000; //10000 = 1 gold
            item.rare = 1; // -1 = Grey; 0 = White; 1 = Blue; 2 = Green; 3 = Orange; 4 = Light Red
            //5 = Pink; 6 = Light Purple; 7 = Lime; 8 = Yellow; 9 = Cyan; 10 = Red; 11 = Purple
            //-12 = Rainbow; -2 = Amber
            item.UseSound = SoundID.Item39; //Default 39
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AbyssalKnivesProj");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
        {
            if (Calamity != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod"), "Lumenite", 10);
                recipe.AddTile(mod.GetTile("KnifeBench"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

}
