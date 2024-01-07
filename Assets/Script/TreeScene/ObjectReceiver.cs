using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReceiver : MonoBehaviour
{
    public AudioClip receiveAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gift"))
        {
            other.GetComponent<ObjectThrow>().Arrived(transform);
            AudioSource.PlayClipAtPoint(receiveAudio, Camera.main.transform.position);
        }
    }
}
