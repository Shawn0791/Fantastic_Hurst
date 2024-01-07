using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSinger : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


}
