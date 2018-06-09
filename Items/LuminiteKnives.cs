using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace VampKnives.Items
{
	public class LuminiteKnives : KnifeItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hand of the Moon Lord");
			Tooltip.SetDefault("Life Stealing Knives Crafted from Fragments of the Moon");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(52, 13));
        }
        public override void SetDefaults()
		{
			item.damage = 160;
            item.mana = 11;
            item.magic = true;
			item.width = 66;
			item.height = 66;
            item.useTime = 12;
            item.useAnimation = 12;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 9;
			item.UseSound = SoundID.Item39;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("LuminiteKnifeProj");
            item.shootSpeed = 17f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 8);
            recipe.AddIngredient(ItemID.VampireKnives, 1);
            recipe.AddTile(mod.GetTile("KnifeBench"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}
