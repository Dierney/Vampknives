using Terraria;
using Terraria.ModLoader;
using VampKnives;

namespace VampKnives.Buffs
{
    public class WitchDoctorHoodBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("WitchDoctormancy");
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
            if (p.HoodKeyPressed == true && p.WitchDoctorAccessoryPrevious)
            {
                p.WitchDoctorPower = true;

            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}