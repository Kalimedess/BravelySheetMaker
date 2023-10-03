using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class InputDataProcessing : MonoBehaviour
{
    PropertyInfo _inputDataInfo;
    private string inputString;
    private int inputInt;
    private char inputChar;
    [SerializeField] private bool isDropdown;
    [SerializeField] private TextMeshProUGUI _input;
    [SerializeField] private Sheet _sheet;
    [SerializeField] private TMP_InputField _inputField;
    
    private void Start()
    {
        _input = GetComponentInChildren<TextMeshProUGUI>();
        _sheet = GetComponentInParent<Sheet>();
    }
    public void ProcessSheetData(string sheetAttributeToSaveInto)
    {
        if(_input != null)
        {
            _inputDataInfo = typeof(Sheet).GetProperty(sheetAttributeToSaveInto);
            if (_inputDataInfo.PropertyType == typeof(int))
            {
                inputString = _input.text;
                if(!isDropdown)
                    inputString = inputString.Substring(0, inputString.Length - 1);
                _inputDataInfo.SetValue(_sheet, int.Parse(inputString));
            }
            else if(_inputDataInfo.PropertyType == typeof(char))
            {
                inputString = _input.text;
                if(!isDropdown)
                    inputString = inputString.Substring(0, inputString.Length - 1);
                _inputDataInfo.SetValue(_sheet, inputString.ToCharArray()[0]);
            }
            else
            {
                inputString = _input.text;
                if(!isDropdown)
                    inputString = inputString.Substring(0, inputString.Length - 1);
                _inputDataInfo.SetValue(_sheet, inputString);
            }
        }
        else
        {
            Debug.LogError("Input component not found");
        }
    }
    public void OnLoadInput(string sheetAttributeToSaveInto)
    {
        if (!isDropdown)
        {
            _inputField = GetComponent<TMP_InputField>();
            if (_inputField != null)
            {
                _inputDataInfo = typeof(Sheet).GetProperty(sheetAttributeToSaveInto);
                if (_inputDataInfo.PropertyType == typeof(int))
                {
                    inputInt = (int)_inputDataInfo.GetValue(_sheet);
                    inputString = inputInt.ToString();
                    _inputField.text = inputString;
                }
                else if (_inputDataInfo.PropertyType == typeof(char))
                {
                    inputChar = (char)_inputDataInfo.GetValue(_sheet);
                    inputString = inputChar.ToString();
                    _inputField.text = inputString;
                }
                else
                {
                    inputString = (string)_inputDataInfo.GetValue(_sheet);
                    _inputField.text = inputString;
                }
            }
            else
            {
                Debug.LogError("Input component not found");
            }
        }
        else
        {
            if (_input != null)
            {
                _inputDataInfo = typeof(Sheet).GetProperty(sheetAttributeToSaveInto);
                if (_inputDataInfo.PropertyType == typeof(int))
                {
                    inputInt = (int)_inputDataInfo.GetValue(_sheet);
                    inputString = inputInt.ToString();
                    _input.text = inputString;
                }
                else if (_inputDataInfo.PropertyType == typeof(char))
                {
                    inputChar = (char)_inputDataInfo.GetValue(_sheet);
                    inputString = inputChar.ToString();
                    _input.text = inputString;
                }
                else
                {
                    inputString = (string)_inputDataInfo.GetValue(_sheet);
                    _input.text = inputString;
                }
            }
            else
            {
                Debug.LogError("Input component not found");
            }
        }
    }
}
