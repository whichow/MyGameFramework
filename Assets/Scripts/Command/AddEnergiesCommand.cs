using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnergiesCommand : Command
{
	private int _eneriges;

	public AddEnergiesCommand(int eneriges)
	{
		_eneriges = eneriges;
	}

	public override void Execute()
	{
		var eneriges = PlayerPrefs.GetInt("Energies", 0) + _eneriges;
		PlayerPrefs.SetInt("Energies", eneriges);
		MainCtrl.Instance.SetEnergies(eneriges);
	}
}
