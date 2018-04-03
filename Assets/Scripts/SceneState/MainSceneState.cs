using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneState : ISceneState
{
    public MainSceneState(SceneStateController controller) : base(controller)
    {
        StateName = "MainState";
        SceneName = "MainScene";
    }

    public override void StateBegin()
    {
        MainCtrl.Instance.Init();
        CoinsCtrl.Instance.Init();
        DiamondsCtrl.Instance.Init();
        EnergiesCtrl.Instance.Init();
        PlayerInfoCtrl.Instance.Init();
        CombatCtrl.Instance.Init();
        CombatCtrl.Instance.OnEnterGame += (level) =>
        {
            _controller.SetState(new LoadingSceneState(_controller, new GameSceneState(_controller, level)));
        };
    }

    public override void StateEnd()
    {
        MainCtrl.Instance.Release();
        CoinsCtrl.Instance.Release();
        DiamondsCtrl.Instance.Release();
        EnergiesCtrl.Instance.Release();
        PlayerInfoCtrl.Instance.Release();
        CombatCtrl.Instance.Release();
    }

    public override void StateUpdate()
    {
        MainCtrl.Instance.Update();
        CoinsCtrl.Instance.Update();
        DiamondsCtrl.Instance.Update();
        EnergiesCtrl.Instance.Update();
        PlayerInfoCtrl.Instance.Update();
        CombatCtrl.Instance.Update();
    }
}
