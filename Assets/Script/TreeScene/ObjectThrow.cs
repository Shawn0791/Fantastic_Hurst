using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectThrow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float forceX = 1;
    public float forceY = 1;
    public float forceZ = 1;
    public GameObject blink;
    public float floatSpeed;
    public AudioClip throwAudio;

    private Rigidbody rb;
    private Vector2 mouseDown;
    private Vector2 mouseUp;
    private bool swinging = true;
    private float time;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (swinging)
            Swinging();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = Input.mousePosition;
        swinging = false;
        transform.SetParent(transform.root);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseUp = Input.mousePosition;
        rb.useGravity = true;
        ThrowAway();

        AudioSource.PlayClipAtPoint(throwAudio, Camera.main.transform.position);
    }

    private void ThrowAway()
    {
        float dis = Vector2.Distance(mouseUp, mouseDown);
        Vector2 vector = mouseUp - mouseDown;
        rb.AddForce(0, vector.y * forceY,0 );
        rb.AddForce((transform.position - Camera.main.transform.position) * dis * forceZ);
        Debug.Log(mouseUp+" "+mouseDown+" "+dis);
    }

    public void Arrived(Transform tree)
    {
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        blink.SetActive(true);
        transform.parent = tree;
        enabled = false;
    }

    private void Swinging()
    {
        time += Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y + floatSpeed * Mathf.Sin(time) * Time.deltaTime, transform.position.z);
    }
}
