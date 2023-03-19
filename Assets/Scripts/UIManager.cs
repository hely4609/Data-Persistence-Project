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

    public void Start() //�����ϸ� �ְ����� �����͸� ������.
    { 
        bestScoreText.text = "Best Score : "+MenuManager.instance.bestScore.ToString();
    }
    public void StartNew() // ���� �̵��ϰ�, ���� �÷��̾� �̸��� MenuManager�� ���
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
