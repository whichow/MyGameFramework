using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoinsCommand : Command
{
	private int _coins;

	public AddCoinsCommand(int coins)
	{
		_coins = coins;
	}

	public override void Execute()
	{
		PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) + _coins);
		MainCtrl.Instance.SetCoins(PlayerPrefs.GetInt("Coins", 0));
	}
}
