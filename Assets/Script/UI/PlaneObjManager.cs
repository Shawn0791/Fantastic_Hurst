using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class PlaneObjManager : MonoBehaviour
{
    public GameObject ARSession;
    public ARPlaneManager planeManager;
    public GameObject[] flowers;

    public void Daffodil()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[0];
        //planeManager.requestedDetectionMode = UnityEngine.XR.ARSubsystems.PlaneDetectionMode.Horizontal;
    }
    public void DahliaPink()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[0];
    }
    public void Dandelion()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[1];
    }
    public void Delphinium()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[2];
    }
    public void flowerTallRed()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[3];
    }
    public void myosotisHeavy()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[4];
    }
    public void roseRed()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[5];
    }
    public void sunflower()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[6];
    }
    public void tulips()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[7];
    }
    public void violet()
    {
        ARSession.GetComponent<ARPlacementInteractable>().placementPrefab = flowers[8];
    }
}
