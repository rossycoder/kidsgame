using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class vido : MonoBehaviour
{
    public VideoClip[] videoClips;
    private VideoPlayer player;
    private int videoclipss;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        player.clip = videoClips[0];
    }
    public void palyNext()
    {
        videoclipss++;
        if(videoclipss >= videoClips.Length)
        {
            videoclipss =videoclipss % videoClips.Length;
        }
        player.clip = videoClips[videoclipss];
    }
    public void playpause()
    {
        if (player.isPlaying)
        {
            player.Pause();
        }
        else
        {
            player.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
