using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameLevel
{
    public virtual void Init() { }
    public virtual void Update() { }
    public virtual void Release() { }
    public virtual void StartGame() { }
    public virtual void ExitGame()
    {
        SceneStateController.Instance.SetState(new LoadingSceneState(new MainSceneState()));
    }
}
