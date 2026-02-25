using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    /*
     VideoManager Script
     has a list of videoclips and a reference to the UI Panel that will play the video
     Note for me: Video UI should then also be included in Image UIs, so that "hide" will still work 
     in order to deactivate UI
     */

    public GameObject videoUi;
    public VideoClip[] videos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddVideoLayer(string target)
    {
        AssignVideo(target);
        videoUi.SetActive(true);
    }



    private void AssignVideo(string videoTarget)
    {
        foreach (VideoClip clip in videos) {
            if (clip.name == videoTarget)
            {
                videoUi.GetComponentInChildren<VideoPlayer>(true).clip = clip;
            }
        }
        
    }
}
