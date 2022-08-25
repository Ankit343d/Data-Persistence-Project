using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public string nameOfPlayer;
    public string bestPlayer;
    public int bestScore;
    public GameObject inputField;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {

        if(Instance !=null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    class SaveData
    {
        public string name;
        public int score;
    }

    public bool LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestPlayer = data.name;
            bestScore = data.score;
            return true;
        }
        return false;
    }

    public void SaveDataScore(string name,int score)
    {
        SaveData data = new SaveData();
        bestPlayer=data.name = name;
        bestScore=data.score = score;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    
}
