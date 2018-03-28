using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingState : ISceneState
{
    private ISceneState _loadState;

    public LoadingState(SceneStateController controller, ISceneState loadState) : base(controller)
    {
        StateName = "LoadingState";
        SceneName = "LoadingScene";
        _loadState = loadState;
    }

    public override void StateBegin()
    {
        LoadingCtrl.Instance.Init();
        _controller.SetState(_loadState);
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
