using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public AudioClip click;

    //场景传参
    public static string Parameter;
    ///根据名称切换场景
    public void LoadScene(string sname)
    {
        SceneManager.LoadScene(sname);
    }

    //跨场景传递一个参数
    public void RecordParmeter(string parameter)
    {

        Parameter = parameter;
    }
    ///根据索引切换场景
    public void LoadScene(int sindex)
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        var cursceneName = SceneManager.GetActiveScene().name;

        if (sindex == 2 && !GameScene.completeList.Contains(cursceneName))
        {
            GameScene.completeList.Add(cursceneName);
        }
        SceneManager.LoadScene(sindex);
    }

    ///根据顺序加载下一个场景
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    ///根据顺序加载上一个场景
    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    ///重载当前场景
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
