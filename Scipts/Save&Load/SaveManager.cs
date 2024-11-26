using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{
    
    static string path = Application.persistentDataPath + "PlayerData.data";
    public static void SaveData()
    {
        BinaryFormatter br = new BinaryFormatter();
        FileStream file = File.Open(path, FileMode.OpenOrCreate);
        br.Serialize(file, GameManager.Instance.data);
        file.Close();
    }

    public static void LoadData()
    {
        if(File.Exists(path))
        {
            BinaryFormatter br = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            GameManager.Instance.data = (PlayerData)br.Deserialize(file);
            file.Close();
        }
        else
        {
            GameManager.Instance.NewPlayer();
        }
    }
    public static void DeleteFile()
    {
        GameManager.Instance.NewPlayer();
        SaveData();
    }
}
