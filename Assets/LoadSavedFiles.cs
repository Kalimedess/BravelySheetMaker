using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LoadSavedFiles : MonoBehaviour
{
    [SerializeField] private Sheet _sheet;
    [SerializeField] private GameObject sheetButtonPrefab;
    [SerializeField] private GameObject currentSheetButton;
    [SerializeField] private string[] savedFiles;
    private void OnEnable()
    {
        if(transform.childCount > 0)
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            CreateSavedSheetsArray();
        }
        else
        {
            CreateSavedSheetsArray();
        }
    }
    private void CreateSavedSheetsArray()
    {
        savedFiles = new string[Directory.GetFiles(Application.persistentDataPath, "*.bvst").Length];
        savedFiles = Directory.GetFiles(Application.persistentDataPath, "*.bvst");
        savedFiles[savedFiles.Length-1] = Directory.GetFiles(Application.persistentDataPath, "player.fun")[0];
        foreach(string file in savedFiles)
        {
            currentSheetButton = Instantiate(sheetButtonPrefab,gameObject.transform);
            currentSheetButton.GetComponentInChildren<TextMeshProUGUI>().text = Path.GetFileName(file);
        }
    }
    
}
