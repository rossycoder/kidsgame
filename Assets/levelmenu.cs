using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmenu : MonoBehaviour
{
  
    public static int currlevel;

    public  void onclickLevel(int Levelnum)
    {
     
        currlevel = Levelnum; 
        SceneManager.LoadScene("3");
    }// Start is called before the first frame update
    public void onclickback() {
        this.gameObject.SetActive(false);

    }
    void Start()
    {
    
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
