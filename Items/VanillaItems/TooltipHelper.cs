﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.VanillaItems {
    class TooltipHelper : GlobalItem {

        //this method adds potentially multiple tooltip lines to the end of an item's tooltip stack 
        public static void SimpleModTooltip(Mod mod, Item item, List<TooltipLine> tooltips, int ItemID, string TipToAdd1, string TipToAdd2 = null) { 
            if (item.type == ItemID) {
                int ttindex = tooltips.FindLastIndex(t => t.mod == "Terraria"); //find the last tooltip line
                if (ttindex != -1) {// if we find one
                    //insert the extra tooltip line
                    tooltips.Insert(ttindex + 1, new TooltipLine(mod, "", TipToAdd1));
                    if (TipToAdd2 != null ) {
                        tooltips.Insert(ttindex + 2, new TooltipLine(mod, "", TipToAdd2));
                    }
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            //SimpleModTooltip(mod, item, tooltips, ItemID., "a");
            //SimpleModTooltip(mod, item, tooltips, ItemID., "a", "b");
            //SimpleModTooltip(mod, item, tooltips, ItemID.FlaskofFire, "Adds 10% melee damage);  don't do this. flask of fire's tooltip goes at a specific index, not the end
            SimpleModTooltip(mod, item, tooltips, ItemID.AdamantiteBreastplate, "Set can be upgraded in 3 ways, with 4000 Dark Souls for each piece");
            SimpleModTooltip(mod, item, tooltips, ItemID.AdamantiteDrill, "Use this to open the Adamantite gates in the", "Corruption Temple to the west of the village");
            SimpleModTooltip(mod, item, tooltips, ItemID.AngelWings, "You will discover these in time...", "Can be upgraded with 1 Supersonic Boots, 1 Cloud in a Balloon, and 10000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.BandofRegeneration, "Can be upgraded with the Band of Starpower and 4000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.BandofStarpower, "Can be upgraded with the Band of Regeneration and 4000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.CobaltBreastplate, "Set can be upgraded with 9000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.CobaltDrill, "Use this to gain entry to the Wyvern Mage's", "Fortress above the hallowed caverns to the east");
            SimpleModTooltip(mod, item, tooltips, ItemID.DivingHelmet, "Can be placed in an accessory slot or in your head slot.");
            SimpleModTooltip(mod, item, tooltips, ItemID.GoldHelmet, "Can be upgraded with Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.GrapplingHook, "Don't buy or craft this until you have discovered it in the jungle", "Can be upgraded with 1 Titan Glove and 15,000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.HerosHat, "Can be upgraded eventually with the flippers", "and diving helmet, when you acquire them");
            SimpleModTooltip(mod, item, tooltips, ItemID.ManaCrystal, "Can be used with 200 Dark Souls to create a Mana Bomb");
            SimpleModTooltip(mod, item, tooltips, ItemID.MechanicalEye, "Item is non-consumable.");
            SimpleModTooltip(mod, item, tooltips, ItemID.MechanicalWorm, "Item is non-consumable.");
            SimpleModTooltip(mod, item, tooltips, ItemID.MeteorSuit, "Can be augmented with Souls of Light");
            SimpleModTooltip(mod, item, tooltips, ItemID.MoltenFury, "Can be upgraded with 1 Soul of Sight and 70,000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.MoltenPickaxe, "Use this to open the Cobalt Gate to the east of", "the jungle ruins after you defeat the Wall of Flesh");
            SimpleModTooltip(mod, item, tooltips, ItemID.MythrilChainmail, "This armor set can be upgraded with 9000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.ShadowHelmet, "Can be upgraded with 1000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.SilverWatch, "Can be upgraded with Dark Souls to change day to night.");
            SimpleModTooltip(mod, item, tooltips, ItemID.Spear, "Can be reforged with 3 Souls of Light and 5000 Dark Souls");
            SimpleModTooltip(mod, item, tooltips, ItemID.StickyBomb, "More fun to use than a pickaxe!");
            SimpleModTooltip(mod, item, tooltips, ItemID.WireCutter, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.WormFood, "Item is not consumed so you can retry the fight until victory");
            SimpleModTooltip(mod, item, tooltips, ItemID.Wrench, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.BlueWrench, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.GreenWrench, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.YellowWrench, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.MulticolorWrench, "Do not use this!");
            SimpleModTooltip(mod, item, tooltips, ItemID.IceMachine, "This tile will be turned in a Bonfire upon saving and loading!", "Only place this if you want to create a Bonfire instead!");
        }
    }
}
