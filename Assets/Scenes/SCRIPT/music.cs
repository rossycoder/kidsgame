using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    private Sprite soundonimage;
    public  Sprite soundofImage;
    public Button button;
    private bool is0n = true;
    private bool is1n = true;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        soundonimage = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (is0n)
        {
            button.image.sprite = soundofImage;
            is0n=false;
            audiosource.mute = true;
        }
        else
        {
            button.image.sprite=soundonimage;
            is0n=true;
            audiosource.mute=false;
            
        }
    }
}
