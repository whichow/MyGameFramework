using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : UIView
{
	private Animator[] _heartAnims;
	private int _index;
	
    public GameView(GameObject gameObject) : base(gameObject)
    {
    }

	public override void Init()
	{
		_heartAnims = _gameObject.GetComponentsInChildren<Animator>();
		_index = _heartAnims.Length - 1;
	}

	public void LoseHeart()
	{
		if(_index >= 0)
		{
			_heartAnims[_index].SetTrigger("Lose");
			_index--;
		}
	}

	public void GetHeart()
	{
		if(_index <= _heartAnims.Length - 1)
		{
			_heartAnims[_index].SetTrigger("Get");
			_index++;
		}
	}
}
