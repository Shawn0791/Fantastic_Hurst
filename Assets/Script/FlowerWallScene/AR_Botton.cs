using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AR_Botton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
{
    public GameObject bottonUp;
    public GameObject bottonDown;
    public GameObject phonogramPrefab;
    public float pressTimeMax = 0.3f;
    public AudioClip[] audios;

    private float pressTimer;
    private bool isPressed;

    public BottonType type;
    public enum BottonType
    {
        Do,
        Re,
        Mi,
        Fa,
        Sol,
        La,
        Ti,
    }

    private void Update()
    {
        if (isPressed)
            pressTimer += Time.deltaTime;

        if (pressTimer > pressTimeMax && isPressed) 
        {
            PlayAudio(true);
            isPressed = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressTimer = 0;
        isPressed = true;

        bottonUp.SetActive(false);
        bottonDown.SetActive(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        if (pressTimer < pressTimeMax)
            PlayAudio(false);

        bottonUp.SetActive(true);
        bottonDown.SetActive(false);
    }

    private void PlayAudio(bool isLong)
    {
        if (!isLong)
        {
            switch (type)
            {
                case BottonType.Do:
                    AudioSource.PlayClipAtPoint(audios[0], Camera.main.transform.position);
                    break;
                case BottonType.Re:
                    AudioSource.PlayClipAtPoint(audios[1], Camera.main.transform.position);
                    break;
                case BottonType.Mi:
                    AudioSource.PlayClipAtPoint(audios[2], Camera.main.transform.position);
                    break;
                case BottonType.Fa:
                    AudioSource.PlayClipAtPoint(audios[3], Camera.main.transform.position);
                    break;
                case BottonType.Sol:
                    AudioSource.PlayClipAtPoint(audios[4], Camera.main.transform.position);
                    break;
                case BottonType.La:
                    AudioSource.PlayClipAtPoint(audios[5], Camera.main.transform.position);
                    break;
                case BottonType.Ti:
                    AudioSource.PlayClipAtPoint(audios[6], Camera.main.transform.position);
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (type)
            {
                case BottonType.Do:
                    AudioSource.PlayClipAtPoint(audios[7], Camera.main.transform.position);
                    break;
                case BottonType.Re:
                    AudioSource.PlayClipAtPoint(audios[8], Camera.main.transform.position);
                    break;
                case BottonType.Mi:
                    AudioSource.PlayClipAtPoint(audios[9], Camera.main.transform.position);
                    break;
                case BottonType.Fa:
                    AudioSource.PlayClipAtPoint(audios[10], Camera.main.transform.position);
                    break;
                case BottonType.Sol:
                    AudioSource.PlayClipAtPoint(audios[11], Camera.main.transform.position);
                    break;
                case BottonType.La:
                    AudioSource.PlayClipAtPoint(audios[12], Camera.main.transform.position);
                    break;
                case BottonType.Ti:
                    AudioSource.PlayClipAtPoint(audios[13], Camera.main.transform.position);
                    break;
                default:
                    break;
            }
        }

        Instantiate(phonogramPrefab, transform.position, Quaternion.identity);
    }
}
