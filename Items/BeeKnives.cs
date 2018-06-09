using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
	public class BeeKnives : KnifeItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Knives");
			Tooltip.SetDefault("Life Stealing Knives Covered in Bees");
        }
		public override void SetDefaults()
		{
			item.damage = 4;
            item.mana = 6;
            item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
            item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item97;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("BeeKnifeProj");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HoneyBlock, 50);
            recipe.AddIngredient(mod.GetItem("IronKnives"), 1);
            recipe.AddTile(mod.GetTile("KnifeBench"));
            //recipe.needHoney = true;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}
