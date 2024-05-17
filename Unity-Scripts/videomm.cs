using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videomm : MonoBehaviour
{
    VideoPlayer player;
    public Sprite dur;
    public Sprite devam;
    Image img;
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        img = GetComponent<Image>();
    }

    public void StartStopVideo()
    {
        if (player.isPlaying)
        {
            player.Pause();
        } else if (!player.isPlaying)
        {

            player.Play();
        }
    }


    public void StopVideo()
    {
        player.Stop();
    }
}
