using Deedforge.Domain.Prestige;

namespace Deedforge.Domain.Adventuring
{
    public class Deed
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public List<PrestigeTitle> PrestigeTitles { get; set; }
    }

    public class Deeds
    {
        public static Deed TheFool = new Deed
        {
            Name = "The Fool",
            ImageUrl = "images/deeds/the-fool.jpg",
            Description = "You will embark on a grand adventure that will be spoken of for years to come.\r\nWhat will transpire is not set in stone, and thus what will mark the end of it is yet to be determined.",
            Reward = "A single Divine Wish.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.Monarch, PrestigeTitles.OutlawBoss }
        };

        public static Deed TheMagician = new Deed
        {
            Name = "The Magician",
            ImageUrl = "images/deeds/the-magician.jpg",
            Description = "You will attain great magical power stemming from a potent source of magic.\r\nThis power has no cost, other than the cost of power itself.",
            Reward = "A permanent access to a Spell Form of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Archmage, PrestigeTitles.Lich, PrestigeTitles.DemonPrince, PrestigeTitles.Hivemind, PrestigeTitles.Archdruid }
        };

        public static Deed TheHighPriestess = new Deed
        {
            Name = "The High Priestess",
            ImageUrl = "images/deeds/the-high-priestess.jpg",
            Description = "You will uncover an important secret and bring it into the light.\r\nThe hunger for uncovering this mystery is what fuels you.",
            Reward = "A Magic Tradition of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Pontiff, PrestigeTitles.DivineHerald, PrestigeTitles.Apostate }
        };

        public static Deed TheEmpress = new Deed
        {
            Name = "The Empress",
            ImageUrl = "images/deeds/the-empress.jpg",
            Description = "You will greatly influence the life of a person or a group of people.\r\nThrough this influence you will save their life or lives.",
            Reward = "Two Traits belonging to Charisma Skills of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.Monarch, PrestigeTitles.Chieftain, PrestigeTitles.Hivemind, PrestigeTitles.DragonLord }
        };

        public static Deed TheEmperor = new Deed
        {
            Name = "The Emperor",
            ImageUrl = "images/deeds/the-emperor.jpg",
            Description = "You will gain the right to rule.\r\nThis may be accomplished through regaining a hereditary right, succeeding on an extraordinary feat, or fulfilling a prophecy.",
            Reward = "Two Traits belonging to Fortitude Skills of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Monarch, PrestigeTitles.Chieftain, PrestigeTitles.GrandMaster, PrestigeTitles.Admiral, PrestigeTitles.DragonLord, PrestigeTitles.ApexBeast, PrestigeTitles.NightLord }
        };

        public static Deed TheHierophant = new Deed
        {
            Name = "The Hierophant",
            ImageUrl = "images/deeds/the-hierophant.jpg",
            Description = "You will uncover a great truth about the existence itself.\r\nIt may be the tale of how a specific deity or a devil came to be, how an aspect of magic functions, or a general question of world.",
            Reward = "A permanent Bolstered Status in an Intellect Skill of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Pontiff, PrestigeTitles.GuildMaster, PrestigeTitles.Archmage, PrestigeTitles.DivineHerald, PrestigeTitles.Archdruid, PrestigeTitles.Apostate }
        };

        public static Deed TheLovers = new Deed
        {
            Name = "The Lovers",
            ImageUrl = "images/deeds/the-lovers.jpg",
            Description = "You will establish a great friendship, or perhaps even find true love.\r\nThis harmony is something you yearn for.",
            Reward = "A permanent Bolstered Status in a Charisma Skill of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.Archdruid, PrestigeTitles.Admiral }
        };

        public static Deed TheChariot = new Deed
        {
            Name = "The Chariot",
            ImageUrl = "images/deeds/the-chariot.jpg",
            Description = "You will gain ownership of a great thing.\r\nIt may be an awe-inspiring castle, a powerful ship or a small town.",
            Reward = "Wealth increased by ten Tiers.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Monarch, PrestigeTitles.Chieftain, PrestigeTitles.GuildMaster, PrestigeTitles.OutlawBoss, PrestigeTitles.Admiral }
        };

        public static Deed Strength = new Deed
        {
            Name = "Strength",
            ImageUrl = "images/deeds/strength.jpg",
            Description = "You will overcome a legendary challenge.\r\nYou may be the first one to do so, or you may be the last person in a line of mythical people who have done so.",
            Reward = "A permanent Bolstered Status in a Fortitude Skill of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.Chieftain, PrestigeTitles.GrandMaster, PrestigeTitles.DivineHerald, PrestigeTitles.DragonLord, PrestigeTitles.ApexBeast }
        };

        public static Deed TheHermit = new Deed
        {
            Name = "The Hermit",
            ImageUrl = "images/deeds/the-hermit.jpg",
            Description = "You will help someone accomplish a great deed.\r\nIn doing so, you will find redemption and peace.\r\nA young king trying to make the right decision, or an adventurer needing help to accomplish their destiny, you will help guide them.",
            Reward = "An ability to speak and understand any language.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Archdruid, PrestigeTitles.Admiral }
        };

        public static Deed WheelOfFortune = new Deed
        {
            Name = "Wheel of Fortune",
            ImageUrl = "images/deeds/wheel-of-fortune.jpg",
            Description = "You will displace an entrenched hierarchy or a system, and in doing so cause a change or a revolution to happen.\r\nIt may be that you dethrone a tyrant king, uncover a hidden cabal or simply help a group of people to overthrow their chains.",
            Reward = "+3 Maximum Endurance.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.GrandMaster, PrestigeTitles.GuildMaster, PrestigeTitles.DemonPrince, PrestigeTitles.OutlawBoss, PrestigeTitles.DivineHerald, PrestigeTitles.Apostate }
        };

        public static Deed Justice = new Deed
        {
            Name = "Justice",
            ImageUrl = "images/deeds/justice.jpg",
            Description = "You will right a terrible wrong, and exact justice against those who committed that wrong.\r\nPerhaps you will bring a murderer into the light, retrieve a stolen artifact, or redeem an innocent.",
            Reward = "A permanent Resistance against one type of damage.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.Pontiff, PrestigeTitles.DragonLord }
        };

        public static Deed TheHangedMan = new Deed
        {
            Name = "The Hanged Man",
            ImageUrl = "images/deeds/the-hanged-man.jpg",
            Description = "You will sacrifice something of immense importance to you.\r\nIt may be your choice, or you may be forced to do so, but someone or something important to you will pay the price.",
            Reward = "An ability to change one of your Traits during a Respite.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.GrandMaster, PrestigeTitles.Lich, PrestigeTitles.OutlawBoss, PrestigeTitles.NightLord }
        };

        public static Deed Death = new Deed
        {
            Name = "Death",
            ImageUrl = "images/deeds/death.jpg",
            Description = "You will end the life of someone important.\r\nIt may be an act of vengeance, a bid for someone else's possession or status, or simply a necessity for greater good.",
            Reward = "A powerful Relic item belonging to the one whose life you will end.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Chieftain, PrestigeTitles.Lich, PrestigeTitles.DemonPrince, PrestigeTitles.OutlawBoss }
        };

        public static Deed Temperance = new Deed
        {
            Name = "Temperance",
            ImageUrl = "images/deeds/temperance.jpg",
            Description = "You will bring forth into existence up to three items of great power and beauty.\r\nThese items may be objects of prophecy, or they may be something never seen before.",
            Reward = "Up to three Mythical items.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.GuildMaster, PrestigeTitles.Archmage }
        };

        public static Deed TheDevil = new Deed
        {
            Name = "The Devil",
            ImageUrl = "images/deeds/the-devil.jpg",
            Description = "You will unleash a great evil upon the lands.\r\nThis burden may not be a consequence of your choices, but it is nonetheless yours to carry.",
            Reward = "Two Traits belonging to Intellect Skills of your choice.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Lich, PrestigeTitles.DemonPrince, PrestigeTitles.Hivemind, PrestigeTitles.ApexBeast, PrestigeTitles.NightLord, PrestigeTitles.Apostate }
        };

        public static Deed TheTower = new Deed
        {
            Name = "The Tower",
            ImageUrl = "images/deeds/the-tower.jpg",
            Description = "You will find yourself in the midst of a great cataclysm.\r\nThe choices you make amidst the chaos will shape the results of this event.",
            Reward = "A permanent Bolstered Status in an Agility Skill of your choice",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Archmage, PrestigeTitles.Pontiff, PrestigeTitles.DemonPrince, PrestigeTitles.DivineHerald, PrestigeTitles.Archdruid }
        };

        public static Deed TheStar = new Deed
        {
            Name = "The Star",
            ImageUrl = "images/deeds/the-star.jpg",
            Description = "You will regain something or someone long lost.\r\nPerhaps an old lover will be returned to you, an ancient family heirloom will be tracked down, or you will find a missing sibling.",
            Reward = "A single Trait of your choice, even if you don't satisfy it's prerequisites.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Monarch, PrestigeTitles.GuildMaster, PrestigeTitles.Admiral }
        };

        public static Deed TheMoon = new Deed
        {
            Name = "The Moon",
            ImageUrl = "images/deeds/the-moon.jpg",
            Description = "You will visit a different realm of reality.\r\nThere, you will plant the seeds of a future to come, and you will pen a great prophecy.",
            Reward = "An ability to change your Culture during a Respite.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Hivemind, PrestigeTitles.ApexBeast, PrestigeTitles.NightLord }
        };

        public static Deed TheSun = new Deed
        {
            Name = "The Sun",
            ImageUrl = "images/deeds/the-sun.jpg",
            Description = "You will find redemption for an evil that you committed.",
            Reward = "Gain an additional Respite Feature, chosen from any Profession.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Champion, PrestigeTitles.GrandMaster, PrestigeTitles.Pontiff, PrestigeTitles.DragonLord }
        };

        public static Deed Judgement = new Deed
        {
            Name = "Judgement",
            ImageUrl = "images/deeds/judgement.jpg",
            Description = "You will fulfill an ancient prophecy.\r\nThis act will forever change you.",
            Reward = "Gain the ability to change your Ancestry during a Respite.",
            PrestigeTitles = new List<PrestigeTitle> { PrestigeTitles.Archmage, PrestigeTitles.Lich, PrestigeTitles.DemonPrince, PrestigeTitles.Hivemind, PrestigeTitles.ApexBeast, PrestigeTitles.NightLord, PrestigeTitles.Apostate }
        };

        public static Deed TheWorld = new Deed
        {
            Name = "The World",
            ImageUrl = "images/deeds/the-world.jpg",
            Description = "You will ascend to godhood.",
            Reward = "–",
            PrestigeTitles = new List<PrestigeTitle> { }
        };
    }
}
