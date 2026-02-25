using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoNavigation : MonoBehaviour
{
    private VideoManager videoManager; // Reference to the ImageManager
    public VideoClip target; // name of the target UI
    private Button button;

    public void Start()
    {
        videoManager = FindObjectOfType<VideoManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowVideo);
    }

    // Call this on button click
    public void ShowVideo()
    {
        videoManager.AddVideoLayer(target.name);
    }
}