using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class LivingTissue : ModItem
    {
        public override void SetStaticDefaults()
        {
            //Defaults
            DisplayName.SetDefault("Living Tissue");
            Tooltip.SetDefault("It's still moving...");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(52, 4));
        }
        public override void SetDefaults()
        {
            item.width = 32;
                item.height = 32;
            item.maxStack = 99;
            item.value = 5000;
            base.SetDefaults();
        }
    }
}
