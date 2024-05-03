using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    // Start is called before the first frame update
    public void secenchange()
    {
        SceneManager.LoadScene("Scenes/2");
    }
    public void secenchange2()
    {
        SceneManager.LoadScene("Scenes/3");
    }
    public void secenechange3()
    {

        SceneManager.LoadScene("Scenes/1");
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
