using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TengWanTouch : MonoBehaviour,IPointerClickHandler
{
    public AudioClip disappearAudio;
    public AudioClip shakeAudio;

    private Animator anim;
    private int touchNum;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TengwanDisappear()
    {
        gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (touchNum < 2)
        {
            anim.SetTrigger("shake");
            touchNum++;

            AudioSource.PlayClipAtPoint(shakeAudio, Camera.main.transform.position);
        }
        else
        {
            anim.SetTrigger("disappear");
            AudioSource.PlayClipAtPoint(disappearAudio, Camera.main.transform.position);
            GameManager.instance.tengwanNum--;
            if (GameManager.instance.tengwanNum == 0)
                GameManager.instance.TengWanBorn();
            GetComponent<TengWanTouch>().enabled = false;
        }
    }
}
