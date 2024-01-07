using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanTip : MonoBehaviour
{
    public float disappearTime = 3;
    public GameObject menu;
    public AudioSource bgmAudio;

    private float timer;

    void Start()
    {
        timer = disappearTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            menu.SetActive(true);
            bgmAudio.enabled = true;
            Destroy(gameObject);
        }
    }
}
