using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeleteSavedSheetButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _buttonText;
    [SerializeField] private GameObject parentObject;
    private string _filename;
    public void DeleteSavedSheet()
    {
        _filename = _buttonText.text;
        if (File.Exists(Application.persistentDataPath+"/"+_filename))
        {
            File.Delete(Application.persistentDataPath + "/" + _filename);
            Debug.Log("Save file deleted");
            Destroy(parentObject);
        }
        else
        {
            Debug.Log("save file does not exist");
        }
    }
}
