using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower
{
	protected GameObject _gameObject;
    protected Placeable _placeable;

    public Tower(GameObject gameObject)
    {
        _gameObject = gameObject;
        _placeable = gameObject.GetComponent<Placeable>();
    }

    public void SetPlaceable(bool placeable)
    {
        _placeable.isPlacing = placeable;
    }

    public bool CanPlace()
    {
        return _placeable.CanPlace();
    }

    public void Destroy()
    {
        GameObject.Destroy(_gameObject);
        _gameObject = null;
        _placeable = null;
    }
}