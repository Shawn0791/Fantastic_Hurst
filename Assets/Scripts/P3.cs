using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3 : MonoBehaviour
{

    public GameObject completeIcon1,completeIcon2,completeIcon3,completeIcon4;
    // Start is called before the first frame update
    void Start()
    {
        if(GameScene.completeList.Contains("P5")){
            completeIcon1.SetActive(true);
        }

        if(GameScene.completeList.Contains("P6")){
            completeIcon2.SetActive(true);
        }

        if(GameScene.completeList.Contains("P7")){
            completeIcon3.SetActive(true);
        }

        if(GameScene.completeList.Contains("P8")){
            completeIcon4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
