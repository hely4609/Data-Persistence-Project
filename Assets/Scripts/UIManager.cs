using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField playerNameSpace;
    public Text playerName;
    public TextMeshProUGUI bestScoreText;

    public void Start() //시작하면 최고점수 데이터를 가져옴.
    { 
        bestScoreText.text = "Best Score : "+MenuManager.instance.bestScore.ToString();
    }
    public void StartNew() // 씬을 이동하고, 현재 플레이어 이름을 MenuManager에 등록
    {
        MenuManager.instance.playerName = playerName.text;
        SceneManager.LoadScene("main");
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
