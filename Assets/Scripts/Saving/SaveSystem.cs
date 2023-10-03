using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void SavePlayer(Sheet sheet)
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + sheet.SheetName + ".bvst";
        FileStream stream = new FileStream(path, FileMode.Create);

        SheetData data = new SheetData(sheet);
        
        bf.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save successful!");
    }
    public static SheetData LoadPlayer(Sheet sheet)
    {
        string path = Application.persistentDataPath + "/" + sheet.SheetName + ".bvst";

        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SheetData sheetAttributes = bf.Deserialize(stream) as SheetData;
            stream.Close();
            return sheetAttributes;
        }
        else
        {
            Debug.LogError("Saved sheet file not found");
            return null;
        }
    }
}
