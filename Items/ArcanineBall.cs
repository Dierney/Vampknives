using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class ArcanineBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A Ball");
            Tooltip.SetDefault("Summons a mature dog of flame");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.shoot = mod.ProjectileType("Arcanine");
            item.buffType = mod.BuffType("ArcanineBuff");
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