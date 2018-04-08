
using UnityEngine;

public abstract class Enemy
{
    protected GameObject _gameObject;
    protected TweenPath _tweenPath;

    public Enemy(GameObject gameObject)
    {
        _gameObject = gameObject;
        _tweenPath = gameObject.GetComponent<TweenPath>();
    }

    public void SetActive(bool active)
    {
        _gameObject.SetActive(active);
    }
}