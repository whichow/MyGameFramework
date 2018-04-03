using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCtrl : BaseCtrl<CombatCtrl>
{
	public Action<int> OnEnterGame;
	private CombatView _combatView;

	public override void Init()
	{
		_combatView = new CombatView(UITool.FindUIGameObject("CombatView"));
		_combatView.Init();
	}

	public override void Release()
	{
		_combatView.Release();
		_combatView = null;
	}

	public void ShowView()
	{
		_combatView.Show();
	}

    public void HideView()
    {
        _combatView.Hide();
    }

    public void EnterGame()
    {
        if(OnEnterGame != null)
		{
			OnEnterGame(_combatView.CurrentLevel);
		}
    }

    public void SelectPrevious()
    {
        _combatView.PreviousLevel();
    }

    public void SelectNext()
    {
        _combatView.NextLevel();
    }
}
