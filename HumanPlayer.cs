using chronodagger.Buffs;
using chronodagger.Items;
using chronodagger.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace chronodagger
{
    public class HumanPlayer : ModPlayer
    {
        // Other mods / buffs / debuffs / misc / effects.
        public int score;
        public bool eFlames;
        public bool elementShield;
        public int elementShields;
        private int elementShieldTimer;
        public int elementShieldPos;
        public int lockTime;
        public bool voidMonolith = false;
        public int heroLives;
        public int reviveTime;
        public int constantDamage;
        public float percentDamage;
        public float defenseEffect = -1f;
        public bool badHeal;
        public int healHurt;
        public bool nullified;
        public int purityDebuffCooldown;
        public bool purityMinion;
        // Put your Pets here.
        public bool examplePet;
        public bool ExamplePet;
        public bool exampleLightPet;
        // Etc.
        public bool exampleShield;
        public bool infinity;
        public bool strongBeesUpgrade;
        public bool manaHeart;
        public int manaHeartCounter;
        // These 5 relate to ExampleCostume. ( Vanity )
        public bool blockyAccessoryPrevious;
        public bool blockyAccessory;
        public bool blockyHideVanity;
        public bool blockyForceVanity;
        public bool blockyPower;
        // The value of this bool can't be calculated by other clients automatically since it is set in ExampleUI. This bool is synced by SendClientChanges. ( Removed )
    }
}
