using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P4 : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite[] sprites;
    public Sprite[] maps;
    public Loading loadManager;
    public GameObject loadCanvas;
    private GameObject bgmSinger;

    public Image bg;
    public Image map;
    public GameObject mapUI;
    void Start()
    {
        bgmSinger = GameObject.FindGameObjectWithTag("bgm");

        switch (SceneLoader.Parameter)
        {
            case "P5":
                bg.sprite = sprites[0];
                map.sprite = maps[0];
                SceneType.Instance.RecordType("butterfly");
                break;
            case "P6":
                bg.sprite = sprites[1];
                map.sprite = maps[1];
                SceneType.Instance.RecordType("tengwan");
                break;
            case "P7":
                bg.sprite = sprites[2];
                map.sprite = maps[2];
                SceneType.Instance.RecordType("flowerwall");
                break;
            case "P8":
                bg.sprite = sprites[3];
                map.sprite = maps[3];
                SceneType.Instance.RecordType("tree");
                break;
        }
    }

    public void GameStart()
    {
        loadManager.StartLoading();
        loadCanvas.SetActive(true);
        bgmSinger.SetActive(false);
    }
    
    public void MapBotton()
    {
        mapUI.SetActive(!mapUI.activeSelf);
    }
}
