
using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
/// <summary>
/// 场景加载器
/// </summary>
public class SceneLoader
{
    // public static bool IsLoading
    // {
    //     get;
    //     private set;
    // }

    public static float LoadingProgress
    {
        get;
        private set;
    }
    
    /// <summary>
    /// 加载一个场景
    /// </summary>
    /// <param name="path">场景路径</param>
    public static void LoadScene(string path)
    {
        SceneManager.LoadScene(path);
    }
    /// <summary>
    /// 异步加载场景
    /// </summary>
    /// <param name="path">场景路径</param>
    /// <param name="onProgress">加载进度回调</param>
    /// <param name="onFinish">完成时的回调</param>
    public static void LoadSceneAsync(string path)
    {
        // if(IsLoading)
        // {
        //     Debug.LogWarning("Only could load one scene simultaneously!");
        //     return;
        // }
        // IsLoading = true;
        LoadingProgress = 0f;
        CoroutineManager.Instance.StartCoroutine(_LoadSceneAsync(path));
    }

    private static IEnumerator _LoadSceneAsync(string name)
    {
        var async = SceneManager.LoadSceneAsync(name);
        async.allowSceneActivation = false;
        while(async.progress < 0.9f)
        {
            LoadingProgress = async.progress;
            yield return null;
        }
        async.allowSceneActivation = true;
        LoadingProgress = 1f;
        yield return async;
        // IsLoading = false;
    }
}
