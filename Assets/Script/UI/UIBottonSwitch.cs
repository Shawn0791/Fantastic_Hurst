using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBottonSwitch : MonoBehaviour
{
    public GameObject[] ui;
    public AudioClip menuAudio;

    private void Start()
    {
        CloseAllUI();
    }
    public void SwitchVisible()
    {
        AudioSource.PlayClipAtPoint(menuAudio, Camera.main.transform.position);

        switch (SceneType.sceneType)
        {
            case "butterfly":
                ui[0].SetActive(!ui[0].activeSelf);
                break;
            case "tengwan":
                ui[1].SetActive(!ui[1].activeSelf);
                break;
            case "flowerwall":
                ui[2].SetActive(!ui[2].activeSelf);
                break;
            case "tree":
                ui[3].SetActive(!ui[3].activeSelf);
                break;
            default:
                break;
        }
    }

    private void CloseAllUI()
    {
        for (int i = 0; i < ui.Length; i++)
        {
            ui[i].SetActive(false);
        }
    }
}
