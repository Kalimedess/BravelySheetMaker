using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeirdAssScriptToCopyBtnTxtToSheet : MonoBehaviour
{
    //THIS SHOULD NOT EXIST! But I can't figure out why won't the AddListener method work for me so this is a sort of workaround
    [SerializeField] private Sheet _sheet;
    [SerializeField] private string textToInsertIntoSheet;

    private void Start()
    {
        _sheet = GetComponentInParent<Sheet>();
    }
    public void OnClickedButton()
    {
        textToInsertIntoSheet = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
        _sheet.SheetName = textToInsertIntoSheet;
        _sheet.DeactivateLoadWindowBeforeLoad();
    }
}
