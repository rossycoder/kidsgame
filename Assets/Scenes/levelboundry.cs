using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelboundry : MonoBehaviour
{
    public static float leftside = -4f;
    public static float rightside = 4f;
    public float internalleft;
    public float externalright;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        internalleft = leftside;
        externalright = rightside;

    }
}
