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
    public class MechanicalFingers : KnifeItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("They seem to move on their own...");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
            item.defense = 2;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<ExamplePlayer>().ExtraProj += 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.Bone, 30);
            recipe.AddIngredient(mod.GetItem("ExtraFinger"));
            recipe.AddTile(mod.GetTile("KnifeBench"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
