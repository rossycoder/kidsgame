using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onclick1 : MonoBehaviour
{

    public AudioSource coinfx;
    // Start is called before the first frame update

        private void OnTriggerEnter(Collider other)
    {
        coinfx.Play();
        this.gameObject.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void stratgame() {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}
