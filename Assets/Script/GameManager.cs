using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("butterfly")]
    public ARPlacementInteractable placement;
    public GameObject[] placementUI;
    public GameObject deadParticle;
    public GameObject butterflyPrefab;
    public int butterflyMax;
    public int greenNum;
    private bool butterIsBorning;
    private int butterflyNum;
    [Header("tengwan")]
    public int tengwanNum = 2;
    public int newTengwanMax;
    public GameObject newTengwanPrefab;
    public float randomMin = 0.5f;
    public float randomMax = 1;
    public float bornArea = 3;
    [Header("Audio")]
    public AudioClip startBornAudio;
    public AudioClip clearBotton;
    public AudioClip vinesGrowAudio;


    public static GameManager instance;
    private void Awake()
    {
        instance = this;

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void ClearAllObj()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Object");
        for (int i = 0; i < obj.Length; i++)
        {
            Instantiate(deadParticle, obj[i].transform.position, Quaternion.identity);
            Destroy(obj[i]);
        }

        GameObject[] gift= GameObject.FindGameObjectsWithTag("Gift");
        for (int i = 0; i < gift.Length; i++)
        {
            Instantiate(deadParticle, gift[i].transform.position, Quaternion.identity);
            Destroy(gift[i]);
        }

        greenNum = 0;
        AudioSource.PlayClipAtPoint(clearBotton, Camera.main.transform.position);
    }

    public void Placement()
    {
        if (placement.enabled == false && SceneType.sceneType == "butterfly") 
        {
            placement.enabled = true;
            for (int i = 0; i < placementUI.Length; i++)
            {
                placementUI[i].SetActive(true);
            }
        }
        else if (placement.enabled == true) 
        {
            placement.enabled = false;
            for (int i = 0; i < placementUI.Length; i++)
            {
                placementUI[i].SetActive(false);
            }
        }
    }
    private void Update()
    {
        CheckEnvironment();
    }

    private void CheckEnvironment()
    {
        if (greenNum >= 6 && butterIsBorning == false)
        {
            butterIsBorning = true;
            StopCoroutine(killCoroutine);
            StartCoroutine(bornCoroutine);
        }
        else if (greenNum < 6 && butterIsBorning == true)
        {
            butterIsBorning = false;
            StopCoroutine(bornCoroutine);
            StartCoroutine(killCoroutine);
        }
    }
    private IEnumerator bornCoroutine;
    private IEnumerator killCoroutine;
    private void Start()
    {
        bornCoroutine = BornButterfly();
        killCoroutine = KillButterfly();
    }

    private IEnumerator BornButterfly()
    {
        AudioSource.PlayClipAtPoint(startBornAudio, Camera.main.transform.position);
        for (int i = butterflyNum; i < butterflyMax; i++)
        {
            Instantiate(butterflyPrefab, transform.position + Random.insideUnitSphere * 3, Quaternion.identity);
            butterflyNum++;
            yield return new WaitForSeconds(0.5f);
        }
    }
    private IEnumerator KillButterfly()
    {
        
        GameObject[] butterflys = GameObject.FindGameObjectsWithTag("butterfly");
        //kill butterfly
        for (int i = 0; i < butterflys.Length; i++)
        {
            Destroy(butterflys[i]);
            butterflyNum--;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public void TengWanBorn()
    {
        StartCoroutine(TengWanBorning());
    }

    private IEnumerator TengWanBorning()
    {
        for (int i = 0; i < newTengwanMax; i++)
        {
            Vector3 pos = new Vector3(Camera.main.transform.position.x + Random.insideUnitCircle.x * bornArea,
                0, Camera.main.transform.position.z + Random.insideUnitCircle.y * bornArea);
            Instantiate(newTengwanPrefab, pos, Quaternion.identity);

            AudioSource.PlayClipAtPoint(vinesGrowAudio, Camera.main.transform.position);
            yield return new WaitForSeconds(Random.Range(randomMin, randomMax));
        }
    }

    public void LoadBack()
    {
        SceneManager.LoadScene("P3");
    }
}
