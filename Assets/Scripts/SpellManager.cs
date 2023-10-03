using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    [SerializeField] private Sheet _sheet;
    [SerializeField] private List<GameObject> spellSlotList;
    [SerializeField] private GameObject descriptionSpellPrefab;
    [SerializeField] private GameObject attackSpellPrefab;
    [SerializeField] private GameObject spellSlotObject;
    [SerializeField] private RectTransform spellCanvasTransform;

    [SerializeField] private TMP_InputField[] spellSlotInputFields;
    private TextMeshProUGUI dropdownText;
    [SerializeField] private List<string> spellSlotsNamesList;
    [SerializeField] private List<int> spellSlotsRangesList;
    [SerializeField] private List<char> spellSlotsRanksList;
    [SerializeField] private List<string> spellSlotsDescriptionsList;
    [SerializeField] private List<bool> spellSlotsAttackSpellStateList;
    [SerializeField] private List<int> spellSlotsHitRateList;
    [SerializeField] private List<int> spellSlotsHitList;
    [SerializeField] private List<int> spellSlotsCritList;

    private int repeatTimes;

    public List<GameObject> SpellSlotList { get => spellSlotList; set => spellSlotList = value; }
    public TMP_InputField[] SpellSlotInputFields { get => spellSlotInputFields; set => spellSlotInputFields = value; }
    public List<string> SpellSlotsNamesList { get => spellSlotsNamesList; set => spellSlotsNamesList = value; }
    public List<int> SpellSlotsRangesList { get => spellSlotsRangesList; set => spellSlotsRangesList = value; }
    public Sheet Sheet { get => _sheet; set => _sheet = value; }
    public List<char> SpellSlotsRanksList { get => spellSlotsRanksList; set => spellSlotsRanksList = value; }
    public List<string> SpellSlotsDescriptionsList { get => spellSlotsDescriptionsList; set => spellSlotsDescriptionsList = value; }
    public List<bool> SpellSlotsAttackSpellStateList { get => spellSlotsAttackSpellStateList; set => spellSlotsAttackSpellStateList = value; }
    public List<int> SpellSlotsHitRateList { get => spellSlotsHitRateList; set => spellSlotsHitRateList = value; }
    public List<int> SpellSlotsHitList { get => spellSlotsHitList; set => spellSlotsHitList = value; }
    public List<int> SpellSlotsCritList { get => spellSlotsCritList; set => spellSlotsCritList = value; }

    private void Start()
    {
        spellCanvasTransform = GetComponent<RectTransform>();
    }
    public void AddSpellSlot(GameObject spellPrefab)
    {
        spellSlotObject = Instantiate(spellPrefab, spellCanvasTransform);
        spellSlotList.Add(spellSlotObject);
        spellSlotObject.GetComponent<SpellInputProcessing>().SiblingIndex = spellSlotList.Count - 1;

    }
    
    public virtual void OnLoad()
    {
        repeatTimes = spellSlotList.Count;
        for (int i = 0; i < repeatTimes; i++)
        {
            if (spellSlotList.Count <= 0) break;
            spellSlotObject = spellSlotList[repeatTimes - i - 1];
            spellSlotList.RemoveAt(repeatTimes - i - 1);
            Destroy(spellSlotObject);
        }

        if (spellSlotsNamesList.Count > 0)
            spellSlotsNamesList.Clear();
        if (spellSlotsRangesList.Count > 0)
            spellSlotsRangesList.Clear();
        if (spellSlotsRanksList.Count > 0)
            spellSlotsRanksList.Clear();
        if (spellSlotsDescriptionsList.Count > 0)
            spellSlotsDescriptionsList.Clear();
        if (spellSlotsAttackSpellStateList.Count > 0)
            spellSlotsAttackSpellStateList.Clear();
        if(spellSlotsHitList.Count > 0)
            spellSlotsHitList.Clear();
        if(spellSlotsHitRateList.Count > 0)
            spellSlotsHitRateList.Clear();
        if(spellSlotsCritList.Count > 0)
            spellSlotsCritList.Clear();

        spellSlotsNamesList = Sheet.SpellSlotsNamesList;
        spellSlotsRangesList = Sheet.SpellSlotsRangesList;
        spellSlotsDescriptionsList = Sheet.SpellSlotsDescriptionsList;
        spellSlotsAttackSpellStateList = Sheet.SpellSlotsAttackSpellStateList;
        spellSlotsCritList = Sheet.SpellSlotsCritList;
        spellSlotsHitList = Sheet.SpellSlotsHitList;
        spellSlotsHitRateList = Sheet.SpellSlotsHitRateList;
        spellSlotsRanksList = Sheet.SpellSlotsRanksList;

        for (int i = 0; i < Sheet.SpellSlotsCount; i++)
        {
            if (spellSlotsAttackSpellStateList[i])
            {
                AddSpellSlot(attackSpellPrefab);
                spellSlotInputFields = spellSlotList[i].GetComponentsInChildren<TMP_InputField>();
                spellSlotInputFields[0].text = spellSlotsDescriptionsList[i];
                spellSlotInputFields[1].text = spellSlotsRangesList[i].ToString();
                spellSlotInputFields[2].text = spellSlotsNamesList[i];
                spellSlotInputFields[3].text = spellSlotsHitRateList[i].ToString();
                spellSlotInputFields[4].text = spellSlotsHitList[i].ToString();
                spellSlotInputFields[5].text = spellSlotsCritList[i].ToString();
                dropdownText = spellSlotList[i].GetComponentInChildren<TMP_Dropdown>().GetComponentInChildren<TextMeshProUGUI>();
                dropdownText.text = spellSlotsRanksList[i].ToString();
            }
            else
            {
                AddSpellSlot(descriptionSpellPrefab);
                spellSlotInputFields = spellSlotList[i].GetComponentsInChildren<TMP_InputField>();
                spellSlotInputFields[0].text = spellSlotsDescriptionsList[i];
                spellSlotInputFields[1].text = spellSlotsRangesList[i].ToString();
                spellSlotInputFields[2].text = spellSlotsNamesList[i];
                dropdownText = spellSlotList[i].GetComponentInChildren<TMP_Dropdown>().GetComponentInChildren<TextMeshProUGUI>();
                dropdownText.text = spellSlotsRanksList[i].ToString();
            }
        }
    }
}
