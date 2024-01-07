using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneType : MonoBehaviour
{
    public static string sceneType;
    public void RecordType(string type)
    {
        sceneType = type;
    }

    private void Awake()
    {
        _instance = this;
    }
    private static SceneType _instance;
    public static SceneType Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SceneType();
            }
            return _instance;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
