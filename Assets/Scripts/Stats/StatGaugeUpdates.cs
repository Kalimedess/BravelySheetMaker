using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using System.Globalization;

public class StatGaugeUpdates : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI baseStatTextComponent;
    [SerializeField] private TextMeshProUGUI statGaugesTextComponent;

    private void Start()
    {
        baseStatTextComponent = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void GetText()
    {
        baseStatTextComponent = GetComponentInChildren<TextMeshProUGUI>();
        OtherStatUpdate();
    }
    private void OtherStatUpdate()
    {
        string baseStatText = baseStatTextComponent.text.ToString();
        baseStatText = baseStatText.Substring(0, baseStatText.Length - 1);
        
        int text = 0;
        if (int.TryParse(baseStatText, out text))
        {
            text *= 3;
            string statGaugeTextStr = text.ToString();
            statGaugesTextComponent.text = statGaugeTextStr;

        }
        else
        {
            Debug.Log("Akcja zakoñczona niepowodzeniem");
        }
    }
}
