using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController : Singleton<SceneStateController>
{
    private ISceneState _state;
    private ISceneState _loadState;

    public SceneStateController()
    {
        SceneManager.sceneUnloaded += OnSceneUnload;
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    private void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        _state = _loadState;
        if (_state != null)
        {
            // Debug.Log("StateBegin " + _state.ToString());
            _state.StateBegin();
        }
    }

    private void OnSceneUnload(Scene scene)
    {
        if (_state != null)
        {
            // Debug.Log("StateEnd " + _state.ToString());
            _state.StateEnd();
        }
        _state = null;
    }

    public void SetState(ISceneState state)
    {
        _loadState = state;
        // SceneManager.LoadSceneAsync(state.SceneName);
        SceneLoader.LoadSceneAsync(state.SceneName);
    }

    public void StateUpdate()
    {
        if (_state != null)
        {
            // Debug.Log("StateUpdate " + _state.ToString());
            _state.StateUpdate();
        }
    }
}
