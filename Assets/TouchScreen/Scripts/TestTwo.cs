using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestTwo : MonoBehaviour
{
    public Sprite Sprite1, Sprite2;
    public Image SprtSwapImage;
    bool IsSprt1 = false, Swiped = false;
    [SerializeField] bool allowSwipe = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("this will only work in mobile");
        if (!allowSwipe)
            return;

        if(Input.touchCount>0)
        {
            if (!Swiped)
            {
                // touch is
                SpriteSwap();
                Swiped = true;
                return;
            }
        }
        else
        {
            if (Swiped)
            {
                Swiped = false;
            }
            // touch is not
        }
    }

    public void SpriteSwap()
    {
        IsSprt1 = !IsSprt1;
        if (IsSprt1)
        {
            SprtSwapImage.sprite = Sprite1;
        }
        else
        {
            SprtSwapImage.sprite = Sprite2;
        }
    }
}
