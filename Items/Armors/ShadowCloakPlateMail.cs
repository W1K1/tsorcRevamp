﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.Armors
{
    [AutoloadEquip(EquipType.Body)]
    public class ShadowCloakPlateMail : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shadow Cloak Skill activates +8 Life Regen when health falls below 80, otherwise grants +1 life regen\nSet bonus: +10% Melee Damage, +27% Melee Speed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.defense = 9;
            item.value = 2000000;
            item.rare = ItemRarityID.Pink;
        }

        public override void UpdateEquip(Player player)
        {
            if (player.statLife <= 80)
            {
                player.lifeRegen += 8;
                int dust = Dust.NewDust(new Vector2((float)player.position.X, (float)player.position.Y), player.width, player.height, 21, (player.velocity.X) + (player.direction * 1), player.velocity.Y, 245, Color.Violet, 2.0f);
                Main.dust[dust].noGravity = true;
            }
            else
            {
                player.lifeRegen += 1;
            }
            if (Main.rand.Next(7) == 0)
            {
                int dust2 = Dust.NewDust(new Vector2((float)player.position.X, (float)player.position.Y), player.width, player.height, 21, (player.velocity.X) + (player.direction * 1), player.velocity.Y, 200, Color.Violet, 1.0f);
                Main.dust[dust2].noGravity = true;

                Main.dust[dust2].noGravity = true;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShadowScalemail, 1);
            recipe.AddIngredient(mod.GetItem("DarkSoul"), 2000);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
