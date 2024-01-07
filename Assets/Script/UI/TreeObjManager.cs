using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeObjManager : MonoBehaviour
{
    public GameObject[] objs;
    public Transform objPoint;

    public void Obj_0()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[0], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_1()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[1], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_2()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[2], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_3()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[3], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_4()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[4], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_5()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[5], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_6()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[6], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_7()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[7], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }
    public void Obj_8()
    {
        ClearGift();
        GameObject obj = Instantiate(objs[8], objPoint.position, Quaternion.identity);
        obj.transform.SetParent(objPoint);
    }

    private void ClearGift()
    {
        if (objPoint.childCount != 0)
            Destroy(objPoint.GetChild(0).gameObject);
    }
}
