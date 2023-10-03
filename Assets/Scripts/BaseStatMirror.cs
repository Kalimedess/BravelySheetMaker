using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BaseStatMirror : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToMirrorStatInto;
    [SerializeField] private string baseStatToMirror;
    [SerializeField] private Sheet _sheet;

    [Header("Variables for manual stat mirroring")]
    [SerializeField] private string sheetStatNameToMirror;
    //method works only for numbers
    public void MirrorStatsManual()
    {
        foreach(var input in objectsToMirrorStatInto)
        {
            if (!input.TryGetComponent(out TMP_InputField TMPcomponent))
            {
                Debug.LogError("Input component not found");
            }
            switch (sheetStatNameToMirror)
            {
                case "Max Health":
                    TMPcomponent.text = _sheet.MaxHealth.ToString();
                    break;
                case "Health":
                    TMPcomponent.text = _sheet.Health.ToString();
                    break;
                default:
                    Debug.LogError("Error during mirroring stats manually");
                    break;
            }
        }
    }
    public void MirrorStatsWithDropdown()
    {
        if (!gameObject.TryGetComponent(out TMP_Dropdown dropdown))
        {
            Debug.LogError("Dropdown component not found.");
        }
        else
        {
            baseStatToMirror = dropdown.GetComponentInChildren<TextMeshProUGUI>().text;
        }
        foreach (var input in objectsToMirrorStatInto)
        {
            switch (baseStatToMirror)
            {
                case "Mastery":
                    input.GetComponent<TMP_InputField>().text = _sheet.MasteryScore.ToString();
                    break;
                case "Bulk":
                    input.GetComponent<TMP_InputField>().text = _sheet.BulkScore.ToString();
                    break;
                case "Memory":
                    input.GetComponent<TMP_InputField>().text = _sheet.MemoryScore.ToString();
                    break;
                case "Imagination":
                    input.GetComponent<TMP_InputField>().text = _sheet.ImaginationScore.ToString();
                    break;
                case "Leadership":
                    input.GetComponent<TMP_InputField>().text = _sheet.LeadershipScore.ToString();
                    break;
                case "Luck":
                    input.GetComponent<TMP_InputField>().text = _sheet.LuckScore.ToString();
                    break;
                default:
                    Debug.LogWarning("No base stat input.");
                    break;
            }
        }
    }
}
