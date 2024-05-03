using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public GameObject[] stars;
    private int coinscount;
    // Start is called before the first frame update
    void Start()
    {
        coinscount = GameObject.FindGameObjectsWithTag("coin").Length;   
    }

    
    public void starsAcheived()
    {
        int coinsleft = GameObject.FindGameObjectsWithTag("coin").Length;
        int coincollected=coinscount- coinsleft;
        float percentage = coincollected / coinsleft * 100f;
        print(percentage+"%");

        if(percentage>=33f && percentage <= 66)
        {
            stars[0].SetActive(true);
        }
        else if(percentage>=66 && percentage < 70)
        {

            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
