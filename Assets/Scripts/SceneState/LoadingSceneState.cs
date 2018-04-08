using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneState : ISceneState
{
    private ISceneState _loadState;

    public LoadingSceneState(ISceneState loadState)
    {
        StateName = "LoadingState";
        SceneName = "LoadingScene";
        _loadState = loadState;
    }

    public override void StateBegin()
    {
        LoadingCtrl.Instance.Init();
        SceneStateController.Instance.SetState(_loadState);
    }

    public override void StateEnd()
    {
        LoadingCtrl.Instance.Release();
    }

    public override void StateUpdate()
    {
        LoadingCtrl.Instance.Update();
    }
}
