using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDiamondsCommand : Command {
	private int _diamonds;

	public AddDiamondsCommand(int diamonds)
	{
		_diamonds = diamonds;
	}

	public override void Execute()
	{
		PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds", 0) + _diamonds);
		MainCtrl.Instance.SetDiamonds(PlayerPrefs.GetInt("Diamonds", 0));
	}
}
