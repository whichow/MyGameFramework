using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneState : ISceneState
{
    public GameSceneState(SceneStateController controller) : base(controller)
    {
        StateName = "GameState";
        SceneName = "GameScene";
    }
}
