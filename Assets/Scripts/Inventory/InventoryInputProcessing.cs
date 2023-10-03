using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryInputProcessing : MonoBehaviour
{
    private Sheet _sheet;
    private InventoryManager _inventoryManager;

    public Sheet Sheet { get => _sheet; set => _sheet = value; }
    public InventoryManager InventoryManager { get => _inventoryManager; set => _inventoryManager = value; }

    // This should probably be in InventoryManager.cs but since the inputs are a part of a prefab that doesn't contain InventoryManager I can't use their events to import data into Sheet.cs
    // An instance of this script also exists on the Canvas that has the InventoryManager script for the same reasoning as the last comment. TODO: Not do that? This is dumb as hell?
    private void Start()
    {
        InventoryManager = GetComponentInParent<InventoryManager>();
        Sheet = GetComponentInParent<Sheet>();
    }

    public void UpdateInventoryList()
    {
        Sheet.InventorySlotsCount = InventoryManager.InventorySlotList.Count;
        if(InventoryManager.InventorySlotsNamesList != null)
            InventoryManager.InventorySlotsNamesList.Clear();
        if(InventoryManager.InventorySlotsNumbersList != null)
            InventoryManager.InventorySlotsNumbersList.Clear();
        foreach (GameObject slot in InventoryManager.InventorySlotList)
        {
            InventoryManager.InventorySlotInputFields = slot.GetComponentsInChildren<TMP_InputField>();
            InventoryManager.InventorySlotsNamesList.Add(InventoryManager.InventorySlotInputFields[0].text);
            InventoryManager.InventorySlotsNumbersList.Add(int.Parse(InventoryManager.InventorySlotInputFields[1].text));
        }
        Sheet.InventorySlotsNamesList = InventoryManager.InventorySlotsNamesList;
        Sheet.InventorySlotsNumbersList = InventoryManager.InventorySlotsNumbersList;
    }
    public void OnLoad()
    {
        
    }
}
