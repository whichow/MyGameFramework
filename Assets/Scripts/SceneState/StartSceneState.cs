using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneState : ISceneState
{
    private float _stayTime = 10f;

    public StartSceneState(SceneStateController controller) : base(controller)
    {
        StateName = "StartState";
        SceneName = "StartScene";
    }

    public override void StateBegin()
    {
        var startButton = UITool.GetUIComponent<Button>("StartButton");
        startButton.onClick.AddListener(() =>
        {
            _controller.SetState(new LoadingState(_controller, new MainSceneState(_controller)));
        });
    }

    public override void StateUpdate()
    {
        _stayTime -= Time.deltaTime;
        if (_stayTime < 0)
        {
            _controller.SetState(new LoadingState(_controller, new MainSceneState(_controller)));
        }
    }
}
