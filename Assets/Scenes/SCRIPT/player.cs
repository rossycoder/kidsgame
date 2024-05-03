using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed = 3;
    public float leftrightspeed = 4;
    // Start is called before the first frame update
    public void SHOW()
    {


        GetComponent<star>().starsAcheived();
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector3.forward * Time.deltaTime * movespeed, Space.World);


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.B)
            )
            if (this.gameObject.transform.position.x > levelboundry.leftside)
            {
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
                }
            }
        if (Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundry.rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed * -1);
            }
        }
    }
}
