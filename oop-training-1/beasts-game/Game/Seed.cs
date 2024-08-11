using System;
using beasts_game.Core;
using beasts_game.Core.Powers;

namespace beasts_game.Game;

public class Seed
{
    public static List<Beast> BeastsPool;
    public static List<Power> PowersPool;
    public static List<Owner> OwnersPool;

    public static void CreateOwners()
    {
        // CREATE POWERS
        // 1. Flame Strike
        var flameStrike = new AttackPower(
            name: "Flame Strike",
            description: "A fiery attack that engulfs the enemy in flames.",
            damage: 30,
            plusDamage: 10
        );

        // 2. Thunder Clap
        var thunderClap = new AttackPower(
            name: "Thunder Clap",
            description: "A powerful shockwave that disorients and damages the target.",
            damage: 25,
            plusDamage: 5
        );

        // 3. Shadow Slash
        var shadowSlash = new AttackPower(
            name: "Shadow Slash",
            description: "A quick, lethal strike from the shadows.",
            damage: 40,
            plusDamage: 0
        );

        // 4. Ice Shard
        var iceShard = new AttackPower(
            name: "Ice Shard",
            description: "A sharp shard of ice that pierces the enemy.",
            damage: 20,
            plusDamage: 15
        );

        // 5. Earthquake
        var earthquake = new AttackPower(
            name: "Earthquake",
            description: "A massive tremor that shakes the battlefield.",
            damage: 35,
            plusDamage: 5
        );

        // 6. Healing Light
        var healingLight = new DefensePower(
            name: "Healing Light",
            description: "A warm light that restores health to the user.",
            restore: 25
        );

        // 7. Shield Wall
        var shieldWall = new DefensePower(
            name: "Shield Wall",
            description: "A protective barrier that absorbs incoming damage.",
            restore: 20
        );

        // 8. Regeneration
        var regeneration = new DefensePower(
            name: "Regeneration",
            description: "A gradual recovery of health over time.",
            restore: 15
        );

        // 9. Iron Skin
        var ironSkin = new DefensePower(
            name: "Iron Skin",
            description: "Temporarily hardens the user's skin, reducing damage taken.",
            restore: 10
        );

        // 10. Divine Protection
        var divineProtection = new DefensePower(
            name: "Divine Protection",
            description: "A sacred shield that provides a large burst of healing.",
            restore: 30
        );

        // 11. Lightning Bolt
        var lightningBolt = new AttackPower(
            name: "Lightning Bolt",
            description: "A bolt of lightning that strikes with immense force.",
            damage: 50,
            plusDamage: 0
        );

        // 12. Poison Dart
        var poisonDart = new AttackPower(
            name: "Poison Dart",
            description: "A dart coated in poison that deals damage over time.",
            damage: 15,
            plusDamage: 20
        );

        // 13. Wind Cutter
        var windCutter = new AttackPower(
            name: "Wind Cutter",
            description: "A sharp gust of wind that slices through the enemy.",
            damage: 25,
            plusDamage: 10
        );

        // 14. Fireball
        var fireball = new AttackPower(
            name: "Fireball",
            description: "A blazing ball of fire that explodes upon impact.",
            damage: 35,
            plusDamage: 15
        );

        // 15. Venomous Bite
        var venomousBite = new AttackPower(
            name: "Venomous Bite",
            description: "A toxic bite that weakens the enemy over time.",
            damage: 20,
            plusDamage: 10
        );

        // 16. Fortify
        var fortify = new DefensePower(
            name: "Fortify",
            description: "Strengthens the user's defenses, reducing damage taken.",
            restore: 5
        );

        // 17. Magic Barrier
        var magicBarrier = new DefensePower(
            name: "Magic Barrier",
            description: "A mystical barrier that absorbs a large amount of damage.",
            restore: 20
        );

        // 18. Life Drain
        var lifeDrain = new DefensePower(
            name: "Life Drain",
            description: "Drains life from the opponent and restores health to the user.",
            restore: 15
        );

        // 19. Spirit Shield
        var spiritShield = new DefensePower(
            name: "Spirit Shield",
            description: "A shield made of spiritual energy that heals the user.",
            restore: 18
        );

        // 20. Healing Wave
        var healingWave = new DefensePower(
            name: "Healing Wave",
            description: "A wave of healing energy that restores a significant amount of health.",
            restore: 28
        );

        // Creating BeastStats for the beasts
        var beastStats1 = new BeastStats(experience: 100, experienceFactor: 1.5f, level: 5);
        var beastStats2 = new BeastStats(experience: 80, experienceFactor: 1.2f, level: 4);
        var beastStats3 = new BeastStats(experience: 150, experienceFactor: 1.8f, level: 6);
        var beastStats4 = new BeastStats(experience: 50, experienceFactor: 1.3f, level: 3);
        var beastStats5 = new BeastStats(experience: 120, experienceFactor: 1.7f, level: 5);
        var beastStats6 = new BeastStats(experience: 130, experienceFactor: 1.4f, level: 5);
        var beastStats7 = new BeastStats(experience: 70, experienceFactor: 1.1f, level: 3);
        var beastStats8 = new BeastStats(experience: 160, experienceFactor: 1.9f, level: 6);
        var beastStats9 = new BeastStats(experience: 90, experienceFactor: 1.2f, level: 4);
        var beastStats10 = new BeastStats(experience: 110, experienceFactor: 1.6f, level: 5);

        // Creating Beasts
        // 1. Fire Dragon
        var fireDragon = new Beast(
            name: "Fire Dragon",
            maxHealth: 200,
            stats: beastStats1,
            basicPowers: new List<Power>
            {
                flameStrike,
                fireball,
                shieldWall
            }
        );

        // 2. Thunder Wolf
        var thunderWolf = new Beast(
            name: "Thunder Wolf",
            maxHealth: 150,
            stats: beastStats2,
            basicPowers: new List<Power>
            {
                thunderClap,
                lightningBolt,
                fortify
            }
        );

        // 3. Shadow Panther
        var shadowPanther = new Beast(
            name: "Shadow Panther",
            maxHealth: 180,
            stats: beastStats3,
            basicPowers: new List<Power>
            {
                shadowSlash,
                venomousBite,
                magicBarrier
            }
        );

        // 4. Ice Golem
        var iceGolem = new Beast(
            name: "Ice Golem",
            maxHealth: 250,
            stats: beastStats4,
            basicPowers: new List<Power>
            {
                iceShard,
                healingLight,
                spiritShield
            }
        );

        // 5. Earth Titan
        var earthTitan = new Beast(
            name: "Earth Titan",
            maxHealth: 300,
            stats: beastStats5,
            basicPowers: new List<Power>
            {
                earthquake,
                lifeDrain,
                ironSkin
            }
        );
        // 6. Poison Serpent
        var poisonSerpent = new Beast(
            name: "Poison Serpent",
            maxHealth: 140,
            stats: beastStats6,
            basicPowers: new List<Power>
            {
                poisonDart,
                venomousBite,
                regeneration
            }
        );

        // 7. Wind Eagle
        var windEagle = new Beast(
            name: "Wind Eagle",
            maxHealth: 120,
            stats: beastStats7,
            basicPowers: new List<Power>
            {
                windCutter,
                fortify,
                healingWave
            }
        );

        // 8. Lightning Phoenix
        var lightningPhoenix = new Beast(
            name: "Lightning Phoenix",
            maxHealth: 160,
            stats: beastStats8,
            basicPowers: new List<Power>
            {
                lightningBolt,
                thunderClap,
                divineProtection
            }
        );

        // 9. Stone Guardian
        var stoneGuardian = new Beast(
            name: "Stone Guardian",
            maxHealth: 220,
            stats: beastStats9,
            basicPowers: new List<Power>
            {
                earthquake,
                ironSkin,
                shieldWall
            }
        );

        // 10. Mystic Unicorn
        var mysticUnicorn = new Beast(
            name: "Mystic Unicorn",
            maxHealth: 180,
            stats: beastStats10,
            basicPowers: new List<Power>
            {
                lifeDrain,
                healingLight,
                magicBarrier
            }
        );
        
        PowersPool = new List<Power>
        {
            flameStrike,
            thunderClap,
            shadowSlash,
            iceShard,
            earthquake,
            healingLight,
            shieldWall,
            regeneration,
            ironSkin,
            divineProtection,
            lightningBolt,
            poisonDart,
            windCutter,
            fireball,
            venomousBite,
            fortify,
            magicBarrier,
            lifeDrain,
            spiritShield,
            healingWave
        };

        BeastsPool = new List<Beast>
        {
            thunderWolf,
            iceGolem,
            poisonSerpent,
            stoneGuardian,
            mysticUnicorn
        };

        // CREATE OWNERS
        OwnersPool = new List<Owner>()
        {
            new Owner(
                name: "Drako",
                beast: fireDragon,
                npc: true
            ),
            new Owner(
                name: "Zephyr",
                beast: windEagle,
                npc: true
            ),
            new Owner(
                name: "Nyx",
                beast: shadowPanther,
                npc: true
            ),
            new Owner(
                name: "Gaia",
                beast: earthTitan,
                npc: true
            ),
            new Owner(
                name: "Orion",
                beast: lightningPhoenix,
                npc: true
            )
        };
    }
}
