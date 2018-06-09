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
    public class ExtraFinger : KnifeItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Y'know what they say, five's better than four");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = 2;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<ExamplePlayer>().ExtraProj += 1;
        }

    //public override void AddRecipes()
    //    {
    //        ModRecipe recipe = new ModRecipe(mod);
    //        recipe.AddIngredient(ItemID.DirtBlock, 5);
    //        recipe.AddTile(mod.GetTile("KnifeBench"));
    //        recipe.SetResult(this);
    //        recipe.AddRecipe();
    //    }
    }
}
