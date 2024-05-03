using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int rotatte = 1;        
    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
     transform.Rotate(0,rotatte,0,Space.World);   
    }
}
