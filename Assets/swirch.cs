using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class swirch : MonoBehaviour
{


    public GameObject[] background;
    int index1;// Start is called before the first frame update
    void Start()
    {
        index1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (index1 >= 17)
        {
            index1 = 17; ;
        }
        if (index1 < 0)
        {
            index1 = 0;
        }
        if (index1 == 0)
        {
            background[0].gameObject.SetActive(true);
        }

    }
    public void Next()
    {
        index1 += 1;
        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index1].gameObject.SetActive(true);
        }

    }
    public void pervious()
    {
        index1 -= 1;
        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index1].gameObject.SetActive(true);
        }
        Debug.Log(index1);
    }
}