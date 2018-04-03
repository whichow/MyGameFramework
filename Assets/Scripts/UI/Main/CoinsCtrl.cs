using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCtrl : BaseCtrl<CoinsCtrl>
{
	private CoinsView _coinsView;

	public override void Init()
	{
		_coinsView = new CoinsView(UITool.FindUIGameObject("CoinsView"));
		_coinsView.Init();
	}

	public override void Release()
	{
		_coinsView.Release();
	}

	public void ShowView()
	{
		_coinsView.Show();
	}

	public void HideView()
	{
		_coinsView.Hide();
	}

	public void AddCoins(int coins)
	{
		AddCoinsCommand addCoinsCommand = new AddCoinsCommand(coins);
		addCoinsCommand.Execute();
	}
}
