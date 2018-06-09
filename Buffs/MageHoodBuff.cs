using Terraria;
using Terraria.ModLoader;
using VampKnives;

namespace VampKnives.Buffs
{
    public class MageHoodBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Pyromancy");
            Description.SetDefault("Knives are imbued with flames");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            ExamplePlayer p = player.GetModPlayer<ExamplePlayer>();

            // We use blockyAccessoryPrevious here instead of blockyAccessory because UpdateBuffs happens before UpdateEquips but after ResetEffects.
            if (p.HoodKeyPressed == true && p.MageAccessoryPrevious)
            {
                p.MagePower = true;

            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            if (p.Mage == true && p.HoodKeyPressed == false)
            {
                player.manaRegenBonus += 5;
            }
            if (p.Mage == true && p.HoodKeyPressed == true)
            {
                if (player.manaRegenBuff && player.manaRegenDelay > 20)
                {
                    player.manaRegenDelay = 20;
                }
                if (player.manaRegenDelay <= 0)
                {
                    player.manaRegenDelay = 0;
                    player.manaRegen = player.statManaMax2 / 7 + 1 + player.manaRegenBonus;
                    if ((player.velocity.X == 0f && player.velocity.Y == 0f) || player.grappling[0] >= 0 || player.manaRegenBuff)
                    {
                        player.manaRegen += player.statManaMax2 / 2;
                    }
                    float num2 = (float)player.statMana / (float)player.statManaMax2 * 0.8f + 0.2f;
                    if (player.manaRegenBuff)
                    {
                        num2 = 1f;
                    }
                    player.manaRegen = (int)((double)((float)player.manaRegen * num2) * 1.15);
                }
                else
                {
                    player.manaRegen = 0;
                }
            }
        }
    }
}