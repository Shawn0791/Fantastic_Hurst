using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class P2 : MonoBehaviour
{

    //加载时长
    public float maxTimer = 5f;


    //当前时长
    public float curTimer = 0f;

    //进度条
    public Slider m_Slider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (curTimer < maxTimer)
        {
            curTimer += Time.deltaTime;
            m_Slider.value = curTimer / maxTimer;
        }
        else
        {
            GameObject a = GameObject.FindGameObjectWithTag("bgm");
            Destroy(a);
            FindObjectOfType<SceneLoader>().NextScene();
        }
    }
}
