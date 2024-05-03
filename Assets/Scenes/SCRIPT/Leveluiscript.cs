using LevelsUnlockedsystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leveluiscript : MonoBehaviour
{
    [SerializeField] private GameObject lockobj, unlockobj;
    [SerializeField] private Image[] starsarray;
    [SerializeField] private Text levelIndexText;
    //[SerializeField] private Color lockcolor, unlockedcolor;
    [SerializeField] private Button btn;
    [SerializeField] private GameObject activrLevelIndicatorl;
    private int levelindex;
    public void Start()
    {
        btn.onClick.AddListener(() => Onclick());
    }
    public void Setlevelbutton(Levelitem value, int index, bool activelevel)
    {
        levelindex = index + 1;
        levelIndexText.text = "" + levelindex;

        if (value.unlocked)
        {
            activrLevelIndicatorl.SetActive(activelevel);
            btn.interactable = true;
            if (lockobj)
                lockobj.SetActive(false);
            SetStar(value.starAchived);
            if (unlockobj)
                unlockobj.SetActive(true);
        }
        else
        {
            btn.interactable = false;
            if (lockobj)
                lockobj.SetActive(true);
            if (unlockobj)
                unlockobj.SetActive(false);
        }
        
    }

    private void SetStar(int starAchived)
    {
        for (int i = 0; i < starsarray.Length; i++)
        {
            if (i < starAchived)
            {
                starsarray[i].gameObject.SetActive(true) ;
            }
            else
            {
                starsarray[i].gameObject.SetActive(false);
            }
        }
    }
    void Onclick()
    {
        LevelSystemManager.Instance.CurrentLevel = levelindex - 1;
        //SceneManager.LoadScene("Level" + levelindex);
        SceneManager.LoadScene(2);
    }


}
