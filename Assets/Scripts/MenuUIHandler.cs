using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        GameManager.Instance.nameOfPlayer = GameManager.Instance.inputField.GetComponent<Text>().text;
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        #if UNITY_EDITOR
           EditorApplication.ExitPlaymode();
        #else 
           Application.Quit();
        #endif

    }
}
