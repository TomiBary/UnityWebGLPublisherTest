using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{

    public VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        var playerURL = Path.Combine(Application.streamingAssetsPath,"example.mp4");
        Debug.Log($"PlayerURL: {playerURL}");
        player.url = playerURL;
    }

    private void Update()
    {
        if(Input.anyKey)
            player.Play();
    }
}
