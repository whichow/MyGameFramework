using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneState : ISceneState
{
    private GameSceneManager _sceneManager;
    private int _level;

    public GameSceneState(int level)
    {
        StateName = "GameState";
        SceneName = "GameScene";

        _sceneManager = GameSceneManager.Instance;
        _level = level;
    }

    public override void StateBegin()
    {
        _sceneManager.Init(_level);
    }

    public override void StateEnd()
    {
        _sceneManager.Release();
    }

    public override void StateUpdate()
    {
        _sceneManager.Update();
    }
}
