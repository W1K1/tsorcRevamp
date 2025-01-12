﻿using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.Weapons.Ranged {
    class ThrowingAxe : ModItem {

        public override void SetDefaults() {
            item.consumable = true;
            item.damage = 9;
            item.height = 34;
            item.knockBack = 7;
            item.maxStack = 250;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.ranged = true;
            item.shootSpeed = 8;
            item.useAnimation = 15;
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 15;
            item.value = 5;
            item.width = 22;
            item.shoot = ModContent.ProjectileType<Projectiles.ThrowingAxe>();
        }
    }
}
