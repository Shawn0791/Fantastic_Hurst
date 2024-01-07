using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;   //������
    public Text text;      //���ؽ����ı�

    private IEnumerator LoadLeaver()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("ForestCampus"); //��ȡ�������
                                                                                                              //operation.allowSceneActivation = false;
        while (!operation.isDone)   //������û�м������
        {
            slider.value = operation.progress;  //�������볡�����ؽ��ȶ�Ӧ
            text.text = (operation.progress * 100).ToString() + "%";
            yield return null;
        }
    }

    public void StartLoading()
    {
        StartCoroutine(LoadLeaver());
    }

}
