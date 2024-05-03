using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1: MonoBehaviour
{

    public string Nextscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void switchsecne(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void swtichsecene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void nextscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
