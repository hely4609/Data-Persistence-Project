using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MenuManager instance;
    public string playerName;
    public string bestPlayerName;
    public int bestScore;
    private void Awake() // 이 객체를 살려갈거임.여기에 있는 이름이 필요함.
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore();
    }
   
    [System.Serializable]
    class SaveData
    {
        public string BestPlayerName;
        public int BestScore;
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        Debug.Log("hey");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.BestPlayerName;
            bestScore = data.BestScore;
        }
        else
        {
            bestPlayerName = "NoName";
            bestScore = 0;
        }
    }
}
