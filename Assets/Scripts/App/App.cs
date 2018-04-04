using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class App : Singleton<App>
{
    public bool HasInit
    {
        get;
        private set;
    }

    public Action InitCallBack;

    private Dictionary<Type, object> managers = new Dictionary<Type, object>();

    public T GetManager<T>()
    {
        return (T)managers[typeof(T)];
    }

    public void Init()
    {
        managers[typeof(AssetLoader)] = new ResourceAssetLoader();

		OnInit();
    }

    private void OnInit()
    {
        HasInit = true;
        if (InitCallBack != null)
        {
            InitCallBack();
        }
    }

    private void OnFailed()
    {
        Debug.LogError("Init orbbec device failed");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
    }
}
