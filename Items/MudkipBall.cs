using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.Items
{
    public class MudkipBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("M Ball");
            Tooltip.SetDefault("Summons a creature from the swamp");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.shoot = mod.ProjectileType("MudkipBunny");
            item.buffType = mod.BuffType("MudkipBuff");
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