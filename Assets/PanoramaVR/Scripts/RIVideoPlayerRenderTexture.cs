using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Unity.VRTemplate
{
    [RequireComponent(typeof(VideoPlayer))]
    public class VideoPlayerRenderTextureRawImage : MonoBehaviour
    {
        [SerializeField]
        RawImage rawImageTarget;  // Assign your RawImage here in Inspector

        [SerializeField]
        int renderTextureWidth = 1920;

        [SerializeField]
        int renderTextureHeight = 1080;

        [SerializeField]
        int renderTextureDepth;

        RenderTexture renderTexture;
        VideoPlayer videoPlayer;

        void Start()
        {
            renderTexture = new RenderTexture(renderTextureWidth, renderTextureHeight, renderTextureDepth);
            renderTexture.Create();

            videoPlayer = GetComponent<VideoPlayer>();
            videoPlayer.targetTexture = renderTexture;

            if (rawImageTarget != null)
            {
                rawImageTarget.texture = renderTexture;
            }
        }
    }
}
