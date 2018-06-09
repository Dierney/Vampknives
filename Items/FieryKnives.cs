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
	public class FieryKnives : KnifeItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tormenting Spikes");
			Tooltip.SetDefault("Forged from bits of hell");
        }
		public override void SetDefaults()
		{
			item.damage = 18;
            item.melee = true;
			item.width = 46;
			item.height = 46;
			item.useTime = 15;
			item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("FieryKnivesProj");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.LivingFireBlock, 12);
            recipe.AddTile(mod.GetTile("KnifeBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}
