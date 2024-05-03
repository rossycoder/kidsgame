using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class swip : MonoBehaviour
{
    public Sprite pageimage;
    public List<Sprite> number;
    public int Pagenumber;
    private Vector2 touchposition;
    private Vector2 touchupposition;


    private void Update()
    {
        if(Input.touchCount > 0&& Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchposition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchupposition = Input.GetTouch(0).position;
            if(touchposition.x < touchupposition.y)
            {
                Nextpage();
            }
            touchupposition = Input.GetTouch(0).position;
            if (touchposition.x > touchupposition.y)
            {
                Perviouspage();
            }
        }
    }
    private void Nextpage()
    { Pagenumber --;
        pageimage = number[Pagenumber];
    }
    private void Perviouspage()
    {
        Pagenumber++;
        pageimage = number[Pagenumber];
    }
}
