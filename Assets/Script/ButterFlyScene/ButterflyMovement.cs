using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyMovement : MonoBehaviour
{
    public Transform ARcamera;
    public float flySpeed;
    public float floatSpeed;
    public float floatRange;
    public float AreaSize;

    private float heightMin;
    private float heightMax;
    private Vector3 target;
    private bool isArrived;
    private float time;

    void Start()
    {
        ARcamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        target = ARcamera.transform.position + Random.insideUnitSphere * AreaSize;
        heightMin = ARcamera.transform.position.y - 1;
        heightMax = ARcamera.transform.position.y + 5;
    }

    void Update()
    {
        time += Time.deltaTime*floatSpeed;

        if (!isArrived)
        {
            //float X = Mathf.MoveTowards(transform.position.x, target.x, flySpeed * Time.deltaTime);
            //float Y = Mathf.MoveTowards(transform.position.y, Mathf.Cos(time) * target.y, floatRange * Time.deltaTime);
            //float Z = Mathf.MoveTowards(transform.position.z, target.z, flySpeed * Time.deltaTime);
            //transform.position = new Vector3(X, Y, Z);

            transform.Translate(Vector3.forward * flySpeed * Time.deltaTime);
            transform.Translate(Vector3.right * floatRange * Time.deltaTime * Mathf.Sin(time));
            transform.Translate(Vector3.up * floatRange * Time.deltaTime * Mathf.Sin(time));
        }

        if (Vector3.Distance(transform.position, target) < 0.5f)
        {
            float X = ARcamera.transform.position.x + Random.insideUnitSphere.x * AreaSize;
            float Y = ARcamera.transform.position.y + Mathf.Clamp(Random.insideUnitSphere.y * AreaSize, heightMin, heightMax);
            float Z = ARcamera.transform.position.z + Random.insideUnitSphere.z * AreaSize;
            target = new Vector3(X, Y, Z);
            //target = ARcamera.transform.position + Random.insideUnitSphere * AreaSize;
            isArrived = false;
        }

        transform.LookAt(target);
    }
}
