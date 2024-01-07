using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunDownBGM : MonoBehaviour
{
    public float volume;
    void Start()
    {
        Camera.main.transform.GetChild(0).GetComponent<AudioSource>().volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
