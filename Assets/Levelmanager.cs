using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{
    public GameObject[] levels;
    // Start is called before the first frame update
    void Start()
    {
        
        levels[levelmenu.currlevel].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
