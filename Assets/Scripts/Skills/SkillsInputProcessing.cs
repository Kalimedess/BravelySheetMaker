using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillsInputProcessing : MonoBehaviour
{
    [SerializeField] private SkillManager _skillManager;
    [SerializeField] private Sheet _sheet;
    
    private void Start()
    {
        _skillManager = GetComponentInParent<SkillManager>();
        _sheet = GetComponentInParent<Sheet>();
    }
    public void UpdateSkillList()
    {
        _sheet.SkillSlotsCount = _skillManager.InventorySlotList.Count;
        if (_skillManager.SkillSlotsTitlesList != null)
            _skillManager.SkillSlotsTitlesList.Clear();
        if (_skillManager.SkillSlotsTextList != null)
            _skillManager.SkillSlotsTextList.Clear();
        foreach (GameObject slot in _skillManager.InventorySlotList)
        {
            _skillManager.InventorySlotInputFields = slot.GetComponentsInChildren<TMP_InputField>();
            _skillManager.SkillSlotsTextList.Add(_skillManager.InventorySlotInputFields[0].text);
            _skillManager.SkillSlotsTitlesList.Add(_skillManager.InventorySlotInputFields[1].text);
        }
        _sheet.SkillSlotsTitlesList = _skillManager.SkillSlotsTitlesList;
        _sheet.SkillSlotsTextList = _skillManager.SkillSlotsTextList;
    }
    public void OnLoad()
    {

    }
}
