using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioClip flower;
    public AudioClip wall;
    public AudioClip vines;
    public AudioClip tree;
    void Start()
    {
        switch (SceneType.sceneType)
        {
            case "butterfly":
                bgm.clip = flower;
                break;
            case "tengwan":
                bgm.clip = vines;
                break;
            case "flowerwall":
                bgm.clip = wall;
                break;
            case "tree":
                bgm.clip = tree;
                break;
            default:
                break;
        }
    }


    void Update()
    {
        
    }
}
