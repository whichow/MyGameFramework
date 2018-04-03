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
		var diamonds = PlayerPrefs.GetInt("Diamonds", 0) + _diamonds;
		PlayerPrefs.SetInt("Diamonds", diamonds);
		MainCtrl.Instance.SetDiamonds(diamonds);
	}
}
