using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestOne : MonoBehaviour
{
    public Sprite Sprite1, Sprite2;
    public Image SprtSwapImage;
    bool IsSprt1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpriteSwap()
    {
        IsSprt1 = !IsSprt1;
        if(IsSprt1 )
        {
            SprtSwapImage.sprite = Sprite1;
        }
        else
        {
            SprtSwapImage.sprite = Sprite2;
        }
    }
}
