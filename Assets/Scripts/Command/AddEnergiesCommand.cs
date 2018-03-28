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
		PlayerPrefs.SetInt("Energies", PlayerPrefs.GetInt("Energies", 0) + _eneriges);
		MainCtrl.Instance.SetEnergies(PlayerPrefs.GetInt("Energies", 0));
	}
}
