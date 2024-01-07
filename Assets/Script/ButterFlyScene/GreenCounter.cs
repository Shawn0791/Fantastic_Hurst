using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCounter : MonoBehaviour
{
    public AudioClip flowerAudio;
    void Start()
    {
        GameManager.instance.greenNum++;
        AudioSource.PlayClipAtPoint(flowerAudio, Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
