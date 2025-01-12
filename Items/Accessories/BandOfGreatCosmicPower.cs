﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.Accessories {
    public class BandOfGreatCosmicPower : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Band of Great Cosmic Power");
            Tooltip.SetDefault("+3 life regen and increases max mana by 60" +
                                "\nCan be upgraded with 35,000 Dark Souls");
        }

        public override void SetDefaults() {
            item.width = 28;
            item.height = 28;
            item.lifeRegen = 3;
            item.accessory = true;
            item.value = 5000;
            item.rare = ItemRarityID.Orange;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("BandOfCosmicPower"), 1);
            recipe.AddIngredient(mod.GetItem("DarkSoul"), 20000);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

        public override void UpdateEquip(Player player) {
            player.statManaMax2 += 60;
        }

    }
}
