using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
  public GameObject Mainmenu;
    public GameObject Howtoplay;
    public GameObject Setting;
    public GameObject Credits;


    // Start is called before the first frame update
    void Start()
    {
        Mainmenu.SetActive(true);
        Howtoplay.SetActive(false);
        Setting.SetActive(false);
        Credits.SetActive(false);
        Debug.Log("start () called");
    }
    public void settingBtnclicked()
    {
        Mainmenu.SetActive(false);
     
        Setting.SetActive(true);
        Debug.Log("SettingsBtnclicked() called");
    }
    public void howtopplay()
    {
        Mainmenu.SetActive(false);

       Howtoplay.SetActive(true);
        Debug.Log("howtoplay() called");
    }
    public void Crediitsbtnclicked()
    {
        Mainmenu.SetActive(false);

        Howtoplay.SetActive(true);
        Debug.Log("Crediitsbtnclicked called");
    }

     public void Backbtnclicked()
    {
        Mainmenu.SetActive(true) ;
        Howtoplay.SetActive(false);
        Setting.SetActive(false);
        Credits.SetActive (false);
    }








    // Update is called once per frame
    void Update()
    {
        
    }
}
