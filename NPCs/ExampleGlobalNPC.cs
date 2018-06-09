using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives.NPCs
{
    public class ExampleGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if(npc.type == NPCID.Plantera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloomingTerror"));
                for (int x = 0; x < 5; x++)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Superglue"));
                }
            }
            if(npc.type == NPCID.MartianTurret)
            {
                if(Main.rand.Next(50) == 4)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RukasusTeslaKnives"));
                            }
            if (npc.type == NPCID.BrainofCthulhu)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrimsonCrystal"));
            }
            if (npc.type == NPCID.Butcher)
            {
                if (NPC.downedPlantBoss == true)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LivingTissue"));
                }
            }
            if (npc.type == NPCID.EaterofWorldsHead)
            {
                if (Main.rand.Next(6) == 0)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptionCrystal"));

            }
            if (npc.type == NPCID.EaterofSouls)
            {
                Random random = new Random();
                int ran = random.Next(0, 11);
                if (ran == 5)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptionShard"));
            }
            if (npc.type == NPCID.FaceMonster)
            {
                Random random = new Random();
                int ran = random.Next(0, 11);
                if (ran == 5)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrimsonShard"));
            }
            if (npc.type == NPCID.MoonLordCore)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuminiteKnives"));
            }
            if (npc.type == NPCID.KingSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Superglue"));
            }
            if(npc.type == NPCID.SkeletronHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExtraFinger"));
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MechanicalFingers"));
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.WitchDoctor)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.MudkipBall>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.LucarioBall>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.ArcanineBall>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.EeveeBall>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.Bagutte>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.MasterSword>());
                shop.item[nextSlot].shopCustomPrice = new int?(100000);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.ConnorPet>());
                nextSlot++;
            }
            if(type == NPCID.SkeletonMerchant)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExtraFinger"));
                shop.item[nextSlot].shopCustomPrice = new int?(10000);
                nextSlot++;
            }
        }
        public bool PenetratingPoison = false;
        public bool bleedingOut = false;
        public bool hellfire = false;
        public bool cursedFire = false;
        public bool gildedCurse = false;
        public bool ichorUproar = false;
        public bool partyBuff = false;
        public bool potentPoison = false;

        public override void ResetEffects(NPC npc)
        {
            PenetratingPoison = false;
            bleedingOut = false;
            hellfire = false;
            cursedFire = false;
            gildedCurse = false;
            ichorUproar = false;
            partyBuff = false;
            potentPoison = false;
        }
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (PenetratingPoison)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    npc.lifeRegen -= 12;
                    if (damage < 6)
                    {
                        damage = 6;
                    }
                }
            }
            if(bleedingOut)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int exampleKnifeCount = 0;
                for (int i = 0; i < 1000; i++)
                {
                    Projectile p = Main.projectile[i];
                    if (p.active && p.type == mod.ProjectileType<Projectiles.ButchersKnivesProj>() && p.ai[0] == 1f && p.ai[1] == npc.whoAmI)
                    {
                        exampleKnifeCount++;
                    }
                }
                npc.lifeRegen -= exampleKnifeCount * 2 * 3;
                if (damage < exampleKnifeCount * 3)
                {
                    damage = exampleKnifeCount * 3;
                }
            }
            if (hellfire)
            {
                for (int x = 0; x < 10; x++)
                {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= Main.rand.Next(5, 12);
                if (damage < 5)
                    damage = damage + x;
                }
            }
            if(cursedFire)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    npc.lifeRegen -= Main.rand.Next(8, 18);
                    if (damage < 8)
                        damage = damage + x;
                }
            }
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (PenetratingPoison)
            {
                int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 273, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.DarkGreen, 1.8f);
                Main.dust[DustID2].noGravity = true;
                int DustID3 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 244, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.LightGreen, 1.8f);
                Main.dust[DustID3].noGravity = true;
                //this make that the npc faces the right way 
            }
            if(bleedingOut)
            {
                Random ran = new Random();
                int blood = ran.Next(0, 2);
                if(blood == 1)
                {
                    int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 5, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.Red, 1f);
                    Main.dust[DustID2].noGravity = true;
                }
            }
            if(hellfire)
            {
                int DustID3 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 186, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 40, Color.Black, 2f);
                Main.dust[DustID3].noGravity = false;
                Main.dust[DustID3].velocity.Y = -6;
                int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 6, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.Red, 3f);
                Main.dust[DustID2].noGravity = false;
                Main.dust[DustID2].velocity.Y = -5;
            }
            if (cursedFire)
            {
                int DustID3 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y-(npc.height/2)), npc.width - 3, npc.height - 3, 186, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 40, Color.Black, 2f);
                Main.dust[DustID3].noGravity = false;
                Main.dust[DustID3].velocity.Y = -6;
                int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 228, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.Green, 2f);
                Main.dust[DustID2].noGravity = false;
                Main.dust[DustID2].velocity.Y = -5;
            }
            if(gildedCurse)
            {
                int DustID3 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 10, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 40, Color.Gold, 1.2f);
                Main.dust[DustID3].noGravity = true;
                int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 19, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 40, Color.Gold, 0.8f);
                Main.dust[DustID2].noGravity = true;
                npc.color = Color.Gold;
            }
            if(ichorUproar)
            {
                int DustID3 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y - (npc.height / 2)), npc.width - 3, npc.height - 3, 186, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 40, Color.White, 2f);
                Main.dust[DustID3].noGravity = false;
                Main.dust[DustID3].velocity.Y = -6;
                int DustID2 = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width - 3, npc.height - 3, 228, npc.velocity.X * 0.2f, npc.velocity.Y * 0.2f, 10, Color.Orange, 2f);
                Main.dust[DustID2].noGravity = false;
                Main.dust[DustID2].velocity.Y = -5;
            }
            if(partyBuff)
            {
                Random ran = new Random();
                int colorSelect = ran.Next(0,25);
                if(colorSelect == 0)
                    npc.color = Color.Red;
                if (colorSelect == 1)
                    npc.color = Color.Orange;
                if (colorSelect == 2)
                    npc.color = Color.Yellow;
                if (colorSelect == 3)
                    npc.color = Color.Green;
                if (colorSelect == 4)
                    npc.color = Color.Blue;
                if (colorSelect == 5)
                    npc.color = Color.Indigo;
                if (colorSelect == 6)
                    npc.color = Color.Violet;
            }
        }
    }
}
