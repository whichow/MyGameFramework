using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower
{
	protected GameObject _gameObject;
    protected Placeable _placeable;
    protected Clickable _clickable;

    public Tower(GameObject gameObject)
    {
        _gameObject = gameObject;
        _placeable = gameObject.GetComponent<Placeable>();
        _clickable = gameObject.GetComponent<Clickable>();
        _clickable.onClick += OnClick;
    }

    private void OnClick()
    {
        
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