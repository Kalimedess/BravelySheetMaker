using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SpellInputProcessing : MonoBehaviour
{
    [SerializeField] private SpellManager _spellManager;
    [SerializeField] private Sheet _sheet;
    [SerializeField] private int siblingIndex;
    [SerializeField] private GameObject spellAttackPrefab;
    private TextMeshProUGUI dropdownText;

    public SpellManager SpellManager { get => _spellManager; set => _spellManager = value; }
    public int SiblingIndex { get => siblingIndex; set => siblingIndex = value; }
    public Sheet Sheet { get => _sheet; set => _sheet = value; }

    private void Start()
    {
        SpellManager = GetComponentInParent<SpellManager>();
        Sheet = GetComponentInParent<Sheet>();
    }
    public void RemoveSpellSlot()
    {
        if (_spellManager.SpellSlotList.Count <= 0) return;
        _spellManager.SpellSlotList.RemoveAt(SiblingIndex);
        Destroy(gameObject);
    }
    public void UpdateMainSheetData()
    {
        Sheet.SpellSlotsAttackSpellStateList = SpellManager.SpellSlotsAttackSpellStateList;
        Sheet.SpellSlotsCritList = SpellManager.SpellSlotsCritList;
        Sheet.SpellSlotsDescriptionsList = SpellManager.SpellSlotsDescriptionsList;
        Sheet.SpellSlotsHitList = SpellManager.SpellSlotsHitList;
        Sheet.SpellSlotsHitRateList = SpellManager.SpellSlotsHitRateList;
        Sheet.SpellSlotsNamesList  = SpellManager.SpellSlotsNamesList;
        Sheet.SpellSlotsRangesList = SpellManager.SpellSlotsRangesList;
        Sheet.SpellSlotsRanksList = SpellManager.SpellSlotsRanksList;
    }
    public void UpdateSiblingIndexes(GameObject spellSlot)
    {
        spellSlot.GetComponent<AttackSpellCheckFunctionality>().SiblingIndex = spellSlot.transform.GetSiblingIndex();
        spellSlot.GetComponent<SpellInputProcessing>().SiblingIndex = spellSlot.transform.GetSiblingIndex();
    }
    public void UpdateSpellList()
    {
        Sheet.SpellSlotsCount = SpellManager.SpellSlotList.Count;
        if (SpellManager.SpellSlotsNamesList != null)
            SpellManager.SpellSlotsNamesList.Clear();
        if (SpellManager.SpellSlotsRangesList != null)
            SpellManager.SpellSlotsRangesList.Clear();
        if (SpellManager.SpellSlotsRanksList != null)
            SpellManager.SpellSlotsRanksList.Clear();
        if (SpellManager.SpellSlotsDescriptionsList != null)
            SpellManager.SpellSlotsDescriptionsList.Clear();
        if(SpellManager.SpellSlotsAttackSpellStateList != null)
            SpellManager.SpellSlotsAttackSpellStateList.Clear();
        if(SpellManager.SpellSlotsHitList != null)
            SpellManager.SpellSlotsHitList.Clear();
        if(SpellManager.SpellSlotsHitRateList != null)
            SpellManager.SpellSlotsHitRateList.Clear();
        if(SpellManager.SpellSlotsCritList != null)
            SpellManager.SpellSlotsCritList.Clear();
        foreach (GameObject slot in SpellManager.SpellSlotList)
        {
            SpellManager.SpellSlotInputFields = slot.GetComponentsInChildren<TMP_InputField>();
            SpellManager.SpellSlotsDescriptionsList.Add(SpellManager.SpellSlotInputFields[0].text);
            SpellManager.SpellSlotsRangesList.Add(int.Parse(SpellManager.SpellSlotInputFields[1].text));
            SpellManager.SpellSlotsNamesList.Add(SpellManager.SpellSlotInputFields[2].text);
            dropdownText = slot.GetComponentInChildren<TMP_Dropdown>().GetComponentInChildren<TextMeshProUGUI>();
            SpellManager.SpellSlotsRanksList.Add(dropdownText.text[0]);
            if (slot.tag == "Spell_attack")
            {
                SpellManager.SpellSlotsAttackSpellStateList.Add(true);
                SpellManager.SpellSlotsHitRateList.Add(int.Parse(SpellManager.SpellSlotInputFields[3].text));
                SpellManager.SpellSlotsHitList.Add(int.Parse(SpellManager.SpellSlotInputFields[4].text));
                SpellManager.SpellSlotsCritList.Add(int.Parse(SpellManager.SpellSlotInputFields[5].text));
            }
            else
            {
                SpellManager.SpellSlotsAttackSpellStateList.Add(false);
                SpellManager.SpellSlotsHitRateList.Add(0);
                SpellManager.SpellSlotsHitList.Add(0);
                SpellManager.SpellSlotsCritList.Add(0);
            }
            UpdateSiblingIndexes(slot);
        }
        UpdateMainSheetData();
    }
}
