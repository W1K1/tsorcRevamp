﻿using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.Weapons.Melee {
    class ForgottenKaiserKnuckles : ModItem {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Great spiked knuckles.");
        }

        public override void SetDefaults() {
            item.autoReuse = true;
            item.useTurn = true;
            item.rare = ItemRarityID.Pink;
            item.damage = 25;
            item.height = 23;
            item.knockBack = 3;
            item.melee = true;
            item.useAnimation = 8;
            item.useTime = 8;
            item.UseSound = SoundID.Item1;
            item.value = 450000;
            item.width = 21;
        }
    }
}
