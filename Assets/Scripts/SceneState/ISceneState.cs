using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ISceneState
{
	public string StateName
	{
		get;
		protected set;
	}

	public string SceneName
	{
		get;
		protected set;
	}

	protected SceneStateController _controller;

	public ISceneState(SceneStateController controller)
	{
		_controller = controller;
	}

	public virtual void StateBegin()
	{

	}

	public virtual void StateUpdate()
	{

	}

	public virtual void StateEnd()
	{

	}

	public override string ToString()
	{
		return string.Format("StateName: {0}", StateName);
	}
}
