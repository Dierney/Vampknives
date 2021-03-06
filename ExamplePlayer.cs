using Terraria;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace VampKnives
{
    public class ExamplePlayer : ModPlayer
    {
        public bool PenetratingPoison = false;
        public bool SengosCurse = false;

        private const int saveVersion = 0;
 
        public bool Connor = false;
        public bool Cobalt = false;
        public bool Mudkip = false;
        public bool lucario = false;
        public bool lucarioMinion = false;
        public bool MudkipMinion = false;
        public bool Mime = false;
        public bool Eevee = false;
        public bool Link = false;
        public bool hasMyBuff = false;
        public bool Arcanine = false;
        public int ExtraProj = 0;
        public int NumProj = 5;

        public bool pyroAccessoryPrevious;
        public bool pyroAccessory;
        public bool pyroHideVanity;
        public bool pyroForceVanity;
        public bool pyroPower;
        public bool pyro = false;

        public bool dPyroAccessoryPrevious;
        public bool dPyroAccessory;
        public bool dPyroHideVanity;
        public bool dPyroForceVanity;
        public bool dPyroPower;
        public bool dPyro = false;

        public bool TransmuterAccessoryPrevious;
        public bool TransmuterAccessory;
        public bool TransmuterHideVanity;
        public bool TransmuterForceVanity;
        public bool TransmuterPower;
        public bool Transmuter = false;

        public bool InvokerAccessoryPrevious;
        public bool InvokerAccessory;
        public bool InvokerHideVanity;
        public bool InvokerForceVanity;
        public bool InvokerPower;
        public bool Invoker = false;

        public bool MageAccessoryPrevious;
        public bool MageAccessory;
        public bool MageHideVanity;
        public bool MageForceVanity;
        public bool MagePower;
        public bool Mage = false;

        public bool TechnomancerAccessoryPrevious;
        public bool TechnomancerAccessory;
        public bool TechnomancerHideVanity;
        public bool TechnomancerForceVanity;
        public bool TechnomancerPower;
        public bool Technomancer = false;

        public bool PartyAccessoryPrevious;
        public bool PartyAccessory;
        public bool PartyHideVanity;
        public bool PartyForceVanity;
        public bool PartyPower;
        public bool Party = false;

        public bool ShamanAccessoryPrevious;
        public bool ShamanAccessory;
        public bool ShamanHideVanity;
        public bool ShamanForceVanity;
        public bool ShamanPower;
        public bool Shaman = false;

        public bool WitchDoctorAccessoryPrevious;
        public bool WitchDoctorAccessory;
        public bool WitchDoctorHideVanity;
        public bool WitchDoctorForceVanity;
        public bool WitchDoctorPower;
        public bool WitchDoctor = false;

        public bool nullified = false;
        public bool HoodKeyPressed = false;

        public override void ResetEffects()
        {
            Connor = false;
            Cobalt = false;
            Mudkip = false;
            lucario = false;
            lucarioMinion = false;
            MudkipMinion = false;
            Mime = false;
            Eevee = false;
            Link = false;
            hasMyBuff = false;
            Arcanine = false;
            PenetratingPoison = false;
            SengosCurse = false;
            nullified = false;
            ExtraProj = 0;
            NumProj = 5;
            pyroAccessoryPrevious = pyroAccessory;
            pyroAccessory = pyroHideVanity = pyroForceVanity = pyroPower = false;
            pyro = false;
            dPyroAccessoryPrevious = dPyroAccessory;
            dPyroAccessory = dPyroHideVanity = dPyroForceVanity = dPyroPower = false;
            dPyro = false;
            TransmuterAccessoryPrevious = TransmuterAccessory;
            TransmuterAccessory = TransmuterHideVanity = TransmuterForceVanity = TransmuterPower = false;
            Transmuter = false;
            InvokerAccessoryPrevious = InvokerAccessory;
            InvokerAccessory = InvokerHideVanity = InvokerForceVanity = InvokerPower = false;
            Invoker = false;
            MageAccessoryPrevious = MageAccessory;
            MageAccessory = MageHideVanity = MageForceVanity = MagePower = false;
            Mage = false;
            TechnomancerAccessoryPrevious = TechnomancerAccessory;
            TechnomancerAccessory = TechnomancerHideVanity = TechnomancerForceVanity = TechnomancerPower = false;
            Technomancer = false;
            PartyAccessoryPrevious = PartyAccessory;
            PartyAccessory = PartyHideVanity = PartyForceVanity = PartyPower = false;
            Party = false;
            ShamanAccessoryPrevious = ShamanAccessory;
            ShamanAccessory = ShamanHideVanity = ShamanForceVanity = ShamanPower = false;
            Shaman = false;
            WitchDoctorAccessoryPrevious = WitchDoctorAccessory;
            WitchDoctorAccessory = WitchDoctorHideVanity = WitchDoctorForceVanity = WitchDoctorPower = false;
            WitchDoctor = false;
        }

        public override void clientClone(ModPlayer clientClone)
        {
            ExamplePlayer clone = clientClone as ExamplePlayer;
            // Here we would make a backup clone of values that are only correct on the local players Player instance.
            // Some examples would be RPG stats from a GUI, Hotkey states, and Extra Item Slots
            clone.HoodKeyPressed = this.HoodKeyPressed;
        }

        public override void SendClientChanges(ModPlayer clientPlayer)
        {
            // Here we would sync something like an RPG stat whenever the player changes it.
            // So far, ExampleMod has nothing that needs this.
            ExamplePlayer client = clientPlayer as ExamplePlayer;

            if (client.HoodKeyPressed != this.HoodKeyPressed)
            {
                client.HoodKeyPressed = this.HoodKeyPressed;
            }
        }

        public override void UpdateDead()
        {
            PenetratingPoison = false;
            SengosCurse = false;
        }
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (hasMyBuff == true)
                ApplyMyBuff(target);
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (hasMyBuff == true)
                ApplyMyBuff(target);
        }
        void ApplyMyBuff(NPC npc)
        {
            npc.AddBuff(72, 60 * 4); //7 seconds, 60 frames per second, just an example number
        }

        public override void UpdateBadLifeRegen()
        {
            if (PenetratingPoison)
            {
                if (player.lifeRegen > 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 3;
            }
            if(SengosCurse)
            {
                if(player.lifeRegen > 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 10;
            }
        }

        public override void UpdateVanityAccessories()
        {
            for (int n = 13; n < 18 + player.extraAccessorySlots; n++)
            {
                Item item = player.armor[n];
                if (item.type == mod.ItemType<Items.Armor.PyromancersHood>())
                {
                    pyroHideVanity = false;
                    pyroForceVanity = true;
                }
                if(item.type == mod.ItemType<Items.Armor.DarkPyromancersHood>())
                {
                    dPyroHideVanity = false;
                    dPyroForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.TransmutersHood>())
                {
                    TransmuterHideVanity = false;
                    TransmuterForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.InvokersHood>())
                {
                    InvokerHideVanity = false;
                    InvokerForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.MagesHood>())
                {
                    MageHideVanity = false;
                    MageForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.TechnomancersHood>())
                {
                    TechnomancerHideVanity = false;
                    TechnomancerForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.PartyHood>())
                {
                    PartyHideVanity = false;
                    PartyForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.ShamansHood>())
                {
                    ShamanHideVanity = false;
                    ShamanForceVanity = true;
                }
                if (item.type == mod.ItemType<Items.Armor.WitchDoctorHood>())
                {
                    WitchDoctorHideVanity = false;
                    WitchDoctorForceVanity = true;
                }
            }
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Make sure this condition is the same as the condition in the Buff to remove itself. We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded items to set blockyAccessory
            if (HoodKeyPressed == true && pyroAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.PyroHoodBuff>(), 60, true);
            }
            if(HoodKeyPressed == true && dPyroAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.DPyroHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && TransmuterAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.TransmuterHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && InvokerAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.InvokerHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && MageAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.MageHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && TechnomancerAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.TechnomancerHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && PartyAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.PartyHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && ShamanAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.ShamanHoodBuff>(), 60, true);
            }
            if (HoodKeyPressed == true && WitchDoctorAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.WitchDoctorHoodBuff>(), 60, true);
            }
        }
        public override void FrameEffects()
        {
            if ((pyroPower || pyroForceVanity) && !pyroHideVanity)
            {
                player.head = mod.GetEquipSlot("PyroHead", EquipType.Head);
            }
            if ((dPyroPower || dPyroForceVanity) && !dPyroHideVanity)
            {
                player.head = mod.GetEquipSlot("DPyroHead", EquipType.Head);
            }
            if ((TransmuterPower || TransmuterForceVanity) && !TransmuterHideVanity)
            {
                player.head = mod.GetEquipSlot("TransmuterHead", EquipType.Head);
            }
            if ((InvokerPower || InvokerForceVanity) && !InvokerHideVanity)
            {
                player.head = mod.GetEquipSlot("InvokerHead", EquipType.Head);
            }
            if ((MagePower || MageForceVanity) && !MageHideVanity)
            {
                player.head = mod.GetEquipSlot("MageHead", EquipType.Head);
            }
            if ((TechnomancerPower || TechnomancerForceVanity) && !TechnomancerHideVanity)
            {
                player.head = mod.GetEquipSlot("TechnomancerHead", EquipType.Head);
            }
            if ((PartyPower || PartyForceVanity) && !PartyHideVanity)
            {
                player.head = mod.GetEquipSlot("PartyHead", EquipType.Head);
            }
            if ((ShamanPower || ShamanForceVanity) && !ShamanHideVanity)
            {
                player.head = mod.GetEquipSlot("ShamanHead", EquipType.Head);
            }
            if ((WitchDoctorPower || WitchDoctorForceVanity) && !WitchDoctorHideVanity)
            {
                player.head = mod.GetEquipSlot("WitchDoctorHead", EquipType.Head);
            }
            if (nullified)
            {
                Nullify();
            }
        }
        private void Nullify()
        {
            player.ResetEffects();
            player.head = -1;
            player.body = -1;
            player.legs = -1;
            player.handon = -1;
            player.handoff = -1;
            player.back = -1;
            player.front = -1;
            player.shoe = -1;
            player.waist = -1;
            player.shield = -1;
            player.neck = -1;
            player.face = -1;
            player.balloon = -1;
            nullified = true;
        }
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (VampKnives.HoodUpDownHotkey.JustPressed)
            {
                if (HoodKeyPressed == false)
                    HoodKeyPressed = true;
                else
                    HoodKeyPressed = false;
            }
        }
    }
}