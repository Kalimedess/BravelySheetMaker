using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


[System.Serializable]
public class SheetData
{
    //Header of sheet
    public string characterName;
    public string characterClass;
    public string classMastery;
    public int level;
    public int experience;
    //Middle left of sheet
    public int masteryScore;
    public int bulkScore;
    public int memoryScore;
    public int imaginationScore;
    public int leadershipScore;
    public int luckScore;
    //Middle of sheet
    public int speed;
    public int health;
    public int currentHealth;
    public int maxHealth;
    public int bulkBuff;
    public int defense;
    public int avoid;
    //Middle right of sheet
    public char swordRank;
    public char axesRank;
    public char polearmsRank;
    public char bowlikeRank;
    public char firearmsRank;
    public char magicRank;
    public char shieldsRank;
    public char armorRank;
    //Bottom right of sheet
    public char alchemyRank;
    public char athleticsRank;
    public char craftingRank;
    public char historyRank;
    public char investigationRank;
    public char performingRank;
    public char religionRank;
    public char reputationRank;
    public char ridingRank;
    public char spellworkingRank;
    public char survivalRank;
    public char thieveryRank;
    public char understandingRank;
    public List<bool> enabledExpertisesList;
    //Inventory (Bottom center of sheet)
    public int inventorySlotsCount;
    public List<int> inventorySlotsNumbersList;
    public List<string> inventorySlotsNamesList;
    //Skills
    public int skillSlotsCount;
    public List<string> skillSlotsTitlesList;
    public List<string> skillSlotsTextList;
    //Spells
    public List<string> spellSlotsNamesList;
    public List<int> spellSlotsRangesList;
    public List<char> spellSlotsRanksList;
    public List<string> spellSlotsDescriptionsList;
    public List<int> spellSlotsHitRateList;
    public List<int> spellSlotsHitList;
    public List<int> spellSlotsCritList;
    public List<bool> spellSlotsAttackSpellStateList;
    public int spellSlotsCount;
    public string spellcastingAbility;
    public int currentSpellslots;
    public int maxSpellslots;
    //Armor defense usability
    public int currentShield;
    public int maxShield;
    public int shieldDefense;
    public int currentArmor;
    public int maxArmor;
    public int armorDefense;

    public SheetData(Sheet sheet)
    {
        characterName = sheet.CharacterName;
        characterClass = sheet.CharacterClass;
        classMastery = sheet.ClassMastery;
        level = sheet.Level;
        experience = sheet.Experience;
        masteryScore = sheet.MasteryScore;
        bulkScore = sheet.BulkScore;
        memoryScore = sheet.MemoryScore;
        imaginationScore = sheet.ImaginationScore;
        leadershipScore = sheet.LeadershipScore;
        luckScore = sheet.LuckScore;
        speed = sheet.Speed;
        health = sheet.Health;
        currentHealth = sheet.CurrentHealth;
        maxHealth = sheet.MaxHealth;
        defense = sheet.Defense;
        avoid = sheet.Avoid;
        bulkBuff = sheet.BulkBuff;
        swordRank = sheet.SwordRank;
        axesRank = sheet.AxesRank;
        polearmsRank = sheet.PolearmsRank;
        bowlikeRank = sheet.BowlikeRank;
        firearmsRank = sheet.FirearmsRank;
        magicRank = sheet.MagicRank;
        shieldsRank = sheet.ShieldsRank;
        armorRank = sheet.ArmorRank;
        alchemyRank = sheet.AlchemyRank;
        athleticsRank = sheet.AthleticsRank;
        craftingRank = sheet.CraftingRank;
        historyRank = sheet.HistoryRank;
        investigationRank = sheet.InvestigationRank;
        performingRank = sheet.PerformingRank;
        religionRank = sheet.ReligionRank;
        reputationRank = sheet.ReputationRank;
        ridingRank = sheet.RidingRank;
        spellworkingRank = sheet.SpellworkingRank;
        survivalRank = sheet.SurvivalRank;
        thieveryRank = sheet.ThieveryRank;
        understandingRank = sheet.UnderstandingRank;
        enabledExpertisesList = sheet.EnabledExpertisesList;
        inventorySlotsCount = sheet.InventorySlotsCount;
        inventorySlotsNamesList = sheet.InventorySlotsNamesList;
        inventorySlotsNumbersList = sheet.InventorySlotsNumbersList;
        skillSlotsCount = sheet.SkillSlotsCount;
        skillSlotsTitlesList = sheet.SkillSlotsTitlesList;
        skillSlotsTextList = sheet.SkillSlotsTextList;
        spellSlotsNamesList = sheet.SpellSlotsNamesList;
        spellSlotsRangesList = sheet.SpellSlotsRangesList;
        spellSlotsRanksList = sheet.SpellSlotsRanksList;
        spellSlotsDescriptionsList = sheet.SpellSlotsDescriptionsList;
        spellSlotsHitRateList = sheet.SpellSlotsHitRateList;
        spellSlotsHitList = sheet.SpellSlotsHitList;
        spellSlotsCritList = sheet.SpellSlotsCritList;
        spellSlotsAttackSpellStateList = sheet.SpellSlotsAttackSpellStateList;
        spellSlotsCount = sheet.SpellSlotsCount;
        maxSpellslots = sheet.MaxSpellslots;
        currentSpellslots = sheet.CurrentSpellslots;
        spellcastingAbility = sheet.SpellcastingAbility;
        currentShield = sheet.CurrentShield;
        maxShield = sheet.MaxShield;
        shieldDefense = sheet.ShieldDefense;
        currentArmor = sheet.CurrentArmor;
        maxArmor = sheet.MaxArmor;
        armorDefense = sheet.ArmorDefense;
    }
}
