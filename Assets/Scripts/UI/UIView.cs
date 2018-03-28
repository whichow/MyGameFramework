using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIView
{
	protected GameObject _gameObject;
	private bool _isVisiable;

	public UIView(GameObject gameObject)
	{
		_gameObject = gameObject;
	}

	public virtual void Init()
	{

	}

	public virtual void Release()
	{
		_gameObject = null;
		_isVisiable = false;
	}
	
	public virtual void Update()
	{

	}

	public virtual void Show()
	{
		_gameObject.SetActive(true);
		_isVisiable = true;
	}

	public virtual void Hide()
	{
		_gameObject.SetActive(false);
		_isVisiable = false;
	}

	public virtual bool IsVisiable()
	{
		return _isVisiable;
	}
}
