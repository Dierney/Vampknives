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
	public class ManaKnivesAnimated : KnifeItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana Knives");
			Tooltip.SetDefault("Mana Stealing Knives");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
        }
		public override void SetDefaults()
		{
			item.damage = 14;
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
            item.shoot = mod.ProjectileType("ManaKnivesAnim");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("CorruptionCrystal"), 1);
            recipe.AddIngredient(mod.GetItem("IronKnives"), 1);
            recipe.AddTile(TileID.ImbuingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}
