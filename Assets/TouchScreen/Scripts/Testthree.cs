using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Testthree : MonoBehaviour
{
    public Sprite Sprite1, Sprite2;
    public Image SprtSwapImage;
    bool IsSprt1 = false;
    bool allowSwipe = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!allowSwipe)
            return;
        if (Input.GetMouseButtonDown(0)) // 0 for left , 1 for right , 2 for middle
        {
            SpriteSwap();
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
