using System.IO;
using UnityEngine;


public class SaveManager : MonoBehaviour
{
    string path;
    SaveData saveData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Save()
    {
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(path, json); 
    }

    void Load()
    {
        string file = File.ReadAllText(path);
        SaveData loadedData = JsonUtility.FromJson<SaveData>(file);

    }
}
