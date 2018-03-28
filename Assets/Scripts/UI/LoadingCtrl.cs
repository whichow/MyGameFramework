using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingCtrl : Singleton<LoadingCtrl>
{
    private LoadingView _loadingView;

    public override void Init()
    {
        _loadingView = new LoadingView(UITool.FindUIGameObject("LoadingView"));
        _loadingView.Init();
    }

    public override void Release()
    {
        _loadingView.Release();
        _loadingView = null;
    }

	public override void Update()
	{
		_loadingView.SetProgress(SceneLoader.LoadingProgress);
	}
}
