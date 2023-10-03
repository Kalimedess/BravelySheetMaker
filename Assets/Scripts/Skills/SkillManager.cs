using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillManager : InventoryManager
{
    private int repeatCount;
    [SerializeField] private List<string> skillSlotsTitlesList;
    [SerializeField] private List<string> skillSlotsTextList;

    public List<string> SkillSlotsTitlesList { get => skillSlotsTitlesList; set => skillSlotsTitlesList = value; }
    public List<string> SkillSlotsTextList { get => skillSlotsTextList; set => skillSlotsTextList = value; }
    public override void OnLoad()
    {
        repeatCount = InventorySlotList.Count;
        for (int i = 0; i < repeatCount; i++)
        {
            RemoveInventorySlot();
        }

        if (skillSlotsTitlesList.Count > 0)
            skillSlotsTitlesList.Clear();

        if (skillSlotsTextList.Count > 0)
            skillSlotsTextList.Clear();

        skillSlotsTitlesList = Sheet.SkillSlotsTitlesList;
        skillSlotsTextList = Sheet.SkillSlotsTextList;
        for (int i = 0; i < Sheet.SkillSlotsCount; i++)
        {
            AddInventorySlot();
            InventorySlotInputFields = InventorySlotList[i].GetComponentsInChildren<TMP_InputField>();
            InventorySlotInputFields[0].text = skillSlotsTextList[i];
            InventorySlotInputFields[1].text = skillSlotsTitlesList[i];
        }

    }
}
