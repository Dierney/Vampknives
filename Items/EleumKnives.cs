using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using Terraria.DataStructures;
using Terraria.Localization;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
	public class EleumKnives : KnifeItem
	{
        Mod Calamity = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
		{
            if (Calamity != null)
            {
                DisplayName.SetDefault("Eleum Knives");
                Tooltip.SetDefault("Stay Frosty");
            }
            else
            {
                DisplayName.SetDefault("Eleum Knives");
                Tooltip.SetDefault("Please enable Calamity");
            }
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 10));
        }
        public override void SetDefaults()
		{
			item.damage = 50;
            item.mana = 6;
            item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item39;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("EleumKnivesProj");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
		{
            if (Calamity != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod"), "CoreofEleum", 7);
                recipe.AddIngredient(ItemID.VampireKnives, 1);
                recipe.AddTile(TileID.CrystalBall);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}

}
