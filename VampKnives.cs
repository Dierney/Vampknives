using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VampKnives
{
    public class VampKnives : Mod
    {
        public static ModHotKey HoodUpDownHotkey;
        public VampKnives()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            ModRecipe recipe2 = new ModRecipe(this);
            ModRecipe recipe3 = new ModRecipe(this); 
            recipe.AddIngredient(this.GetItem("IronKnives"), 1);
            recipe.AddIngredient(ItemID.CrimsonKey, 1);
            recipe.AddTile(this.GetTile("KnifeBench"));
            recipe.SetResult(ItemID.VampireKnives);
            recipe.AddRecipe();
            recipe2.AddIngredient(this.GetItem("WeakVampireKnives"), 1);
            recipe2.AddIngredient(this.GetItem("LivingTissue"), 1);
            recipe2.AddTile(this.GetTile("KnifeBench"));
            recipe2.SetResult(ItemID.VampireKnives);
            recipe2.AddRecipe();
            recipe3.AddIngredient(ItemID.GlowingMushroom, 1);
            recipe3.AddIngredient(ItemID.BottledWater, 1);
            recipe3.AddTile(TileID.AlchemyTable);
            recipe3.SetResult(ItemID.LesserManaPotion);
            recipe3.AddRecipe();
        }
        public override void Load()
        {
            HoodUpDownHotkey = RegisterHotKey("HoodUpDown", "P");
            if (!Main.dedServ)
            {
                // Add certain equip textures
                //AddEquipTexture(null, EquipType.Legs, "ExampleRobe_Legs", "ExampleMod/Items/Armor/ExampleRobe_Legs");
                AddEquipTexture(new Items.Armor.PyroHead(), null, EquipType.Head, "PyroHead", "VampKnives/Items/Armor/PyromancersHood_Head");
                AddEquipTexture(new Items.Armor.DPyroHead(), null, EquipType.Head, "DPyroHead", "VampKnives/Items/Armor/DarkPyromancersHood_Head");
                AddEquipTexture(new Items.Armor.TransmuterHead(), null, EquipType.Head, "TransmuterHead", "VampKnives/Items/Armor/TransmutersHood_Head");
                AddEquipTexture(new Items.Armor.InvokerHead(), null, EquipType.Head, "InvokerHead", "VampKnives/Items/Armor/InvokersHood_Head");
                AddEquipTexture(new Items.Armor.MageHead(), null, EquipType.Head, "MageHead", "VampKnives/Items/Armor/MagesHood_Head");
                AddEquipTexture(new Items.Armor.TechnomancerHead(), null, EquipType.Head, "TechnomancerHead", "VampKnives/Items/Armor/TechnomancersHood_Head");
                AddEquipTexture(new Items.Armor.PartyHead(), null, EquipType.Head, "PartyHead", "VampKnives/Items/Armor/PartyHood_Head");
                AddEquipTexture(new Items.Armor.ShamanHead(), null, EquipType.Head, "ShamanHead", "VampKnives/Items/Armor/ShamansHood_Head");
                AddEquipTexture(new Items.Armor.WitchDoctorHead(), null, EquipType.Head, "WitchDoctorHead", "VampKnives/Items/Armor/WitchDoctorHood_Head");
            }
                base.Load();
        }
        public override void Unload()
        {
            HoodUpDownHotkey = null;
            base.Unload();
        }
    }
}