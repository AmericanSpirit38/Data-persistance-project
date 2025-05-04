using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public static MenuManager Instance;
    public TMP_InputField playerNameInput;
    public void SetPlayerName()
    {

        if (PlayerData.Instance != null)
        {
            PlayerData.Instance.playerName = playerNameInput.text;
            Debug.Log(Application.persistentDataPath);
            return;
        }
       
    }

    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
