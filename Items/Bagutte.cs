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
    public class Bagutte : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mystic Bagutte");
            Tooltip.SetDefault("Summons a creature from the heart of France");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 8));
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.shoot = mod.ProjectileType("MrMime");
            item.buffType = mod.BuffType("MimeBuff");
            item.noUseGraphic = true;
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}