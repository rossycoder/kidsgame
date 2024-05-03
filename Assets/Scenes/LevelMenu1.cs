using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu1 : MonoBehaviour
{
    public Button[] buttons;
    public Image[] stars;
    private void Awake()
    {
        int unlockedlevel = PlayerPrefs.GetInt("unlocked", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            
        }
        for (int i = 0; i < unlockedlevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
















    public void option(int levelid)
    {
        string levelName ="level"+levelid;
        SceneManager.LoadScene(levelName);
    }    
}
