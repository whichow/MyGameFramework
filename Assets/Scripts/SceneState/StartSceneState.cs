using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneState : ISceneState
{
    // private float _stayTime = 10f;

    public StartSceneState()
    {
        StateName = "StartState";
        SceneName = "StartScene";
    }

    public override void StateBegin()
    {
        var startButton = UITool.GetUIComponent<Button>("StartButton");
        startButton.onClick.AddListener(() =>
        {
            SceneStateController.Instance.SetState(new LoadingSceneState(new MainSceneState()));
        });
    }

    // public override void StateUpdate()
    // {
    //     _stayTime -= Time.deltaTime;
    //     if (_stayTime < 0)
    //     {
    //         _controller.SetState(new LoadingSceneState(_controller, new MainSceneState(_controller)));
    //     }
    // }
}
