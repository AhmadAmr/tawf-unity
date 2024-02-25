using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))] // Ensure there's a VideoPlayer component on the GameObject
public class VideoAutoLoader1 : MonoBehaviour
{
    private VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    private Renderer quadRenderer;   // Reference to the Renderer component



    void Start()
    {
        GameObject video = GameObject.Find("video_plane_1");
        videoPlayer = video.GetComponent<VideoPlayer>(); // Automatically get the VideoPlayer component
        quadRenderer = video.GetComponent<Renderer>();
        // Initially hide the quad by disabling its Renderer
        if (quadRenderer != null)
        {
            quadRenderer.enabled = false;
        }
        else
        {
            Debug.LogError("Renderer component missing.");
            return;
        }

        // Subscribe to the prepareCompleted event
        videoPlayer.prepareCompleted += OnVideoPrepared;

        // Start preparing the video
        videoPlayer.Prepare();
    }

    private void Update()
    {
        GameObject video = GameObject.Find("video_plane_1");
        videoPlayer = video.GetComponent<VideoPlayer>(); // Automatically get the VideoPlayer component
        quadRenderer = video.GetComponent<Renderer>();
        // Initially hide the quad by disabling its Renderer
        if (quadRenderer != null)
        {
            quadRenderer.enabled = false;
        }
        else
        {
            Debug.LogError("Renderer component missing.");
            return;
        }

        // Subscribe to the prepareCompleted event
        videoPlayer.prepareCompleted += OnVideoPrepared;

        // Start preparing the video
        videoPlayer.Prepare();
    }



    void OnVideoPrepared(VideoPlayer source)
    {
        // Video is ready. Show the quad by enabling its Renderer and play the video.
        quadRenderer.enabled = true;
        videoPlayer.Play();
    }

    void OnDestroy()
    {
        // Unsubscribe from the event to avoid memory leaks
        if (videoPlayer != null)
        {
            videoPlayer.prepareCompleted -= OnVideoPrepared;
        }
    }
}
