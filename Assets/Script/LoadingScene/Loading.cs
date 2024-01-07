using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;   //进度条
    public Text text;      //加载进度文本

    private IEnumerator LoadLeaver()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("ForestCampus"); //获取场景编号
                                                                                                              //operation.allowSceneActivation = false;
        while (!operation.isDone)   //当场景没有加载完毕
        {
            slider.value = operation.progress;  //进度条与场景加载进度对应
            text.text = (operation.progress * 100).ToString() + "%";
            yield return null;
        }
    }

    public void StartLoading()
    {
        StartCoroutine(LoadLeaver());
    }

}
