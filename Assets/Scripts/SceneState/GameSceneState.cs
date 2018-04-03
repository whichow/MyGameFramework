using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneState : ISceneState
{
    public int Level
    {
        get;
        private set;
    }

    public GameSceneState(SceneStateController controller, int level) : base(controller)
    {
        StateName = "GameState";
        SceneName = "GameScene";
        Level = level;
    }

    public override void StateBegin()
    {
        GameCtrl.Instance.Init();
    }

    public override void StateEnd()
    {
        GameCtrl.Instance.Release();
    }

    public override void StateUpdate()
    {
        GameCtrl.Instance.Update();
    }
}
