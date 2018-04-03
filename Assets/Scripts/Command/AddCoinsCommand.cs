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
		var coins = PlayerPrefs.GetInt("Coins", 0) + _coins;
		PlayerPrefs.SetInt("Coins", coins);
		MainCtrl.Instance.SetCoins(coins);
	}
}
