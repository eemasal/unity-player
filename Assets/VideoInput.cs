using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;



public class VideoInput : MonoBehaviour {

    VideoPlayer videoPlayer;
    PathAbsorber pathAbsorber;

    

    public void Start()
    {
        pathAbsorber = FindObjectOfType<PathAbsorber>();
            // Will attach a VideoPlayer to the main camera.
            GameObject sphere = GameObject.Find("Sphere");

            // VideoPlayer automatically targets the camera backplane when it is added
            // to a camera object, no need to change videoPlayer.targetCamera.
             videoPlayer = sphere.AddComponent<UnityEngine.Video.VideoPlayer>();

            // Play on awake defaults to true. Set it to false to avoid the url set
            // below to auto-start playback since we're in Start().
            videoPlayer.playOnAwake = true;


        // By default, VideoPlayers added to a camera will use the far plane.
        // Let's target the near plane instead.

        // This will cause our scene to be visible through the video being played.

        // Set the video to play. URL supports local absolute or relative paths.
        // Here, using absolute.
        
        videoPlayer.url = pathAbsorber.path;
           
            

            // Restart from beginning when done.
            videoPlayer.isLooping = false;

            // Each time we reach the end, we slow down the playback by a factor of 10.
            

            // Start playback. This means the VideoPlayer may have to prepare (reserve
            // resources, pre-load a few frames, etc.). To better control the delays
            // associated with this preparation one can use videoPlayer.Prepare() along with
            // its prepareCompleted event.
            videoPlayer.Play();
        }

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePlay();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentIndex - 1);
        }
        
    }

    void TogglePlay()
    {
        if (!videoPlayer.isPlaying)
            videoPlayer.Play();
        else
            videoPlayer.Pause();
    }

   
}





    

