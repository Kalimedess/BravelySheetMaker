using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private Sheet _sheet;
    [SerializeField] private List<GameObject> inventorySlotList;
    [SerializeField] private GameObject inventoryPrefab;
    [SerializeField] private GameObject inventorySlotObject;
    [SerializeField] private RectTransform inventoryCanvasTransform;

    [SerializeField] private TMP_InputField[] inventorySlotInputFields;
    [SerializeField] private List<int> inventorySlotsNumbersList;
    [SerializeField] private List<string> inventorySlotsNamesList;
    private int repeatTimes;

    public List<GameObject> InventorySlotList { get => inventorySlotList; set => inventorySlotList = value; }
    public TMP_InputField[] InventorySlotInputFields { get => inventorySlotInputFields; set => inventorySlotInputFields = value; }
    public List<int> InventorySlotsNumbersList { get => inventorySlotsNumbersList; set => inventorySlotsNumbersList = value; }
    public List<string> InventorySlotsNamesList { get => inventorySlotsNamesList; set => inventorySlotsNamesList = value; }
    public Sheet Sheet { get => _sheet; set => _sheet = value; }

    private void Start()
    {
        inventoryCanvasTransform = GetComponent<RectTransform>();
    }
    public void AddInventorySlot()
    {
        inventorySlotObject = Instantiate(inventoryPrefab,inventoryCanvasTransform);
        inventorySlotList.Add(inventorySlotObject);
    }
    public void RemoveInventorySlot()
    {
        if (inventorySlotList.Count <= 0) return;
        inventorySlotObject = inventorySlotList[inventorySlotList.Count - 1];
        inventorySlotList.RemoveAt(inventorySlotList.Count - 1);
        Destroy(inventorySlotObject);
    }
    public virtual void OnLoad()
    {
        repeatTimes = inventorySlotList.Count;
        for (int i = 0; i < repeatTimes; i++)
        {
            RemoveInventorySlot();
        }

        if (inventorySlotsNamesList.Count > 0) 
            inventorySlotsNamesList.Clear();

        if(inventorySlotsNumbersList.Count > 0)
            inventorySlotsNumbersList.Clear();

        inventorySlotsNamesList = Sheet.InventorySlotsNamesList;
        inventorySlotsNumbersList = Sheet.InventorySlotsNumbersList;
        for (int i=0;i<Sheet.InventorySlotsCount;i++)
        {
            AddInventorySlot();
            inventorySlotInputFields = inventorySlotList[i].GetComponentsInChildren<TMP_InputField>();
            inventorySlotInputFields[0].text = inventorySlotsNamesList[i];
            inventorySlotInputFields[1].text = inventorySlotsNumbersList[i].ToString();
        }
        
    }
}
