using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Sheet : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI saveWindowInputField;
    [SerializeField] private GameObject loadWindow;
    [SerializeField] private string sheetName;

    
    [Header("Header of sheet")]
    [SerializeField] private string characterName;
    [SerializeField] private string characterClass;
    [SerializeField] private string classMastery;
    [SerializeField] private int level;
    [SerializeField] private int experience;
    
    [Header("Middle left of sheet")]
    [SerializeField] private int masteryScore;
    [SerializeField] private int bulkScore;
    [SerializeField] private int memoryScore;
    [SerializeField] private int imaginationScore;
    [SerializeField] private int leadershipScore;
    [SerializeField] private int luckScore;
    
    [Header("Middle of sheet")]
    [SerializeField] private int speed;
    [SerializeField] private int health;
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private int bulkBuff;
    [SerializeField] private int avoid;
    [SerializeField] private int defense;
    
    [Header("Middle right of sheet")]
    [SerializeField] private char swordRank;
    [SerializeField] private char axesRank;
    [SerializeField] private char polearmsRank;
    [SerializeField] private char bowlikeRank;
    [SerializeField] private char firearmsRank;
    [SerializeField] private char magicRank;
    [SerializeField] private char shieldsRank;
    [SerializeField] private char armorRank;
    
    [Header("Bottom right of sheet")]
    [SerializeField] private char alchemyRank;
    [SerializeField] private char athleticsRank;
    [SerializeField] private char craftingRank;
    [SerializeField] private char historyRank;
    [SerializeField] private char investigationRank;
    [SerializeField] private char performingRank;
    [SerializeField] private char religionRank;
    [SerializeField] private char reputationRank;
    [SerializeField] private char ridingRank;
    [SerializeField] private char spellworkingRank;
    [SerializeField] private char survivalRank;
    [SerializeField] private char thieveryRank;
    [SerializeField] private char understandingRank;
    [SerializeField] private List<bool> enabledExpertisesList;

    
    [Header("Inventory")]
    [SerializeField] private int inventorySlotsCount;
    [SerializeField] private List<int> inventorySlotsNumbersList;
    [SerializeField] private List<string> inventorySlotsNamesList;
    
    [Header("Skills")]
    [SerializeField] private int skillSlotsCount;
    [SerializeField] private List<string> skillSlotsTitlesList;
    [SerializeField] private List<string> skillSlotsTextList;
    
    [Header("Spells")]
    [SerializeField] private List<string> spellSlotsNamesList;
    [SerializeField] private List<int> spellSlotsRangesList;
    [SerializeField] private List<char> spellSlotsRanksList;
    [SerializeField] private List<string> spellSlotsDescriptionsList;
    [SerializeField] private List<bool> spellSlotsAttackSpellStateList;
    [SerializeField] private List<int> spellSlotsHitRateList;
    [SerializeField] private List<int> spellSlotsHitList;
    [SerializeField] private List<int> spellSlotsCritList;
    [SerializeField] private int spellSlotsCount;
    [SerializeField] private string spellcastingAbility;
    [SerializeField] private int currentSpellslots;
    [SerializeField] private int maxSpellslots;

    [Header("Armor usability")]
    [SerializeField] private int currentShield;
    [SerializeField] private int maxShield;
    [SerializeField] private int shieldDefense;
    [SerializeField] private int currentArmor;
    [SerializeField] private int maxArmor;
    [SerializeField] private int armorDefense;
    public string CharacterName { get => characterName; set => characterName = value; }
    public string CharacterClass { get => characterClass; set => characterClass = value; }
    public string ClassMastery { get => classMastery; set => classMastery = value; }
    public int Level { get => level; set => level = value; }
    public int MasteryScore { get => masteryScore; set => masteryScore = value; }
    public int BulkScore { get => bulkScore; set => bulkScore = value; }
    public int MemoryScore { get => memoryScore; set => memoryScore = value; }
    public int ImaginationScore { get => imaginationScore; set => imaginationScore = value; }
    public int LeadershipScore { get => leadershipScore; set => leadershipScore = value; }
    public int LuckScore { get => luckScore; set => luckScore = value; }
    public int Speed { get => speed; set => speed = value; }
    public int Health { get => health; set => health = value; }
    public int BulkBuff { get => bulkBuff; set => bulkBuff = value; }
    public char SwordRank { get => swordRank; set => swordRank = value; }
    public char AxesRank { get => axesRank; set => axesRank = value; }
    public char PolearmsRank { get => polearmsRank; set => polearmsRank = value; }
    public char BowlikeRank { get => bowlikeRank; set => bowlikeRank = value; }
    public char FirearmsRank { get => firearmsRank; set => firearmsRank = value; }
    public char MagicRank { get => magicRank; set => magicRank = value; }
    public char AlchemyRank { get => alchemyRank; set => alchemyRank = value; }
    public char AthleticsRank { get => athleticsRank; set => athleticsRank = value; }
    public char CraftingRank { get => craftingRank; set => craftingRank = value; }
    public char HistoryRank { get => historyRank; set => historyRank = value; }
    public char InvestigationRank { get => investigationRank; set => investigationRank = value; }
    public char PerformingRank { get => performingRank; set => performingRank = value; }
    public char ReligionRank { get => religionRank; set => religionRank = value; }
    public char ReputationRank { get => reputationRank; set => reputationRank = value; }
    public char RidingRank { get => ridingRank; set => ridingRank = value; }
    public char SpellworkingRank { get => spellworkingRank; set => spellworkingRank = value; }
    public char SurvivalRank { get => survivalRank; set => survivalRank = value; }
    public char ThieveryRank { get => thieveryRank; set => thieveryRank = value; }
    public char UnderstandingRank { get => understandingRank; set => understandingRank = value; }
    public List<int> InventorySlotsNumbersList { get => inventorySlotsNumbersList; set => inventorySlotsNumbersList = value; }
    public List<string> InventorySlotsNamesList { get => inventorySlotsNamesList; set => inventorySlotsNamesList = value; }
    public int InventorySlotsCount { get => inventorySlotsCount; set => inventorySlotsCount = value; }
    public int SkillSlotsCount { get => skillSlotsCount; set => skillSlotsCount = value; }
    public List<string> SkillSlotsTitlesList { get => skillSlotsTitlesList; set => skillSlotsTitlesList = value; }
    public List<string> SkillSlotsTextList { get => skillSlotsTextList; set => skillSlotsTextList = value; }
    public List<string> SpellSlotsNamesList { get => spellSlotsNamesList; set => spellSlotsNamesList = value; }
    public List<int> SpellSlotsRangesList { get => spellSlotsRangesList; set => spellSlotsRangesList = value; }
    public List<char> SpellSlotsRanksList { get => spellSlotsRanksList; set => spellSlotsRanksList = value; }
    public List<string> SpellSlotsDescriptionsList { get => spellSlotsDescriptionsList; set => spellSlotsDescriptionsList = value; }
    public List<bool> SpellSlotsAttackSpellStateList { get => spellSlotsAttackSpellStateList; set => spellSlotsAttackSpellStateList = value; }
    public List<int> SpellSlotsHitRateList { get => spellSlotsHitRateList; set => spellSlotsHitRateList = value; }
    public List<int> SpellSlotsHitList { get => spellSlotsHitList; set => spellSlotsHitList = value; }
    public List<int> SpellSlotsCritList { get => spellSlotsCritList; set => spellSlotsCritList = value; }
    public int SpellSlotsCount { get => spellSlotsCount; set => spellSlotsCount = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int Avoid { get => avoid; set => avoid = value; }
    public int Defense { get => defense; set => defense = value; }
    public char ShieldsRank { get => shieldsRank; set => shieldsRank = value; }
    public char ArmorRank { get => armorRank; set => armorRank = value; }
    public List<bool> EnabledExpertisesList { get => enabledExpertisesList; set => enabledExpertisesList = value; }
    public int Experience { get => experience; set => experience = value; }
    public int CurrentShield { get => currentShield; set => currentShield = value; }
    public int MaxShield { get => maxShield; set => maxShield = value; }
    public int ShieldDefense { get => shieldDefense; set => shieldDefense = value; }
    public int CurrentArmor { get => currentArmor; set => currentArmor = value; }
    public int MaxArmor { get => maxArmor; set => maxArmor = value; }
    public int ArmorDefense { get => armorDefense; set => armorDefense = value; }
    public string SpellcastingAbility { get => spellcastingAbility; set => spellcastingAbility = value; }
    public int CurrentSpellslots { get => currentSpellslots; set => currentSpellslots = value; }
    public int MaxSpellslots { get => maxSpellslots; set => maxSpellslots = value; }
    public string SheetName { get => sheetName; set => sheetName = value; }

    public UnityEvent OnSheetLoad;
    public void GetSheetNameSave()
    {
        sheetName = saveWindowInputField.text;
        if (sheetName == null)
        {
            Debug.LogError("No sheet name");
            return;
        }
    }
    public void SaveSheet()
    {
        SaveSystem.SavePlayer(this);
    }
    public void DeactivateLoadWindowBeforeLoad()
    {
        loadWindow.SetActive(false);
        LoadSheet();
    }
    public void LoadSheet()
    {
        SheetData data = SaveSystem.LoadPlayer(this);
        if(data == null)
        {
            Debug.LogError("Sheet not loaded correctly");
            return;
        }
        characterName = data.characterName;
        characterClass = data.characterClass;
        classMastery = data.classMastery;
        level = data.level;
        Experience = data.experience;
        masteryScore = data.masteryScore;
        bulkScore = data.bulkScore;
        memoryScore = data.memoryScore;
        imaginationScore = data.imaginationScore;
        leadershipScore = data.leadershipScore;
        luckScore = data.luckScore;
        speed = data.speed;
        health = data.health;
        maxHealth = data.maxHealth;
        currentHealth = data.currentHealth;
        bulkBuff = data.bulkBuff;
        defense = data.defense;
        avoid = data.avoid;
        swordRank = data.swordRank;
        axesRank = data.axesRank;
        polearmsRank = data.polearmsRank;
        bowlikeRank = data.bowlikeRank;
        firearmsRank = data.firearmsRank;
        magicRank = data.magicRank;
        armorRank = data.armorRank;
        shieldsRank = data.shieldsRank;
        alchemyRank = data.alchemyRank;
        athleticsRank = data.athleticsRank;
        craftingRank = data.craftingRank;
        historyRank = data.historyRank;
        investigationRank = data.investigationRank;
        performingRank = data.performingRank;
        religionRank = data.religionRank;
        reputationRank = data.reputationRank;
        ridingRank = data.ridingRank;
        spellworkingRank = data.spellworkingRank;
        survivalRank = data.survivalRank;
        thieveryRank = data.thieveryRank;
        understandingRank = data.understandingRank;
        enabledExpertisesList = data.enabledExpertisesList;
        inventorySlotsCount = data.inventorySlotsCount;
        inventorySlotsNamesList = data.inventorySlotsNamesList;
        inventorySlotsNumbersList = data.inventorySlotsNumbersList;
        skillSlotsCount = data.skillSlotsCount;
        skillSlotsTextList = data.skillSlotsTextList;
        skillSlotsTitlesList = data.skillSlotsTitlesList;
        spellSlotsNamesList = data.spellSlotsNamesList;
        spellSlotsRangesList = data.spellSlotsRangesList;
        spellSlotsRanksList = data.spellSlotsRanksList;
        spellSlotsDescriptionsList = data.spellSlotsDescriptionsList;
        spellSlotsHitList = data.spellSlotsHitList;
        spellSlotsHitRateList = data.spellSlotsHitRateList;
        spellSlotsCritList = data.spellSlotsCritList;
        spellSlotsAttackSpellStateList = data.spellSlotsAttackSpellStateList;
        spellSlotsCount = data.spellSlotsCount;
        maxSpellslots = data.maxSpellslots;
        currentSpellslots = data.currentSpellslots;
        spellcastingAbility = data.spellcastingAbility;
        currentShield = data.currentShield;
        maxShield = data.maxShield;
        shieldDefense = data.shieldDefense;
        currentArmor = data.currentArmor;
        maxArmor = data.maxArmor;
        armorDefense = data.armorDefense;
        OnSheetLoad?.Invoke();
    }
}
