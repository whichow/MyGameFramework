using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergiesCtrl : BaseCtrl<EnergiesCtrl>
{
	private EnergiesView _energiesView;

	public override void Init()
	{
		_energiesView = new EnergiesView(UITool.FindUIGameObject("EnergiesView"));
		_energiesView.Init();
	}

	public override void Release()
	{
		_energiesView.Release();
	}

	public void ShowView()
	{
		_energiesView.Show();
	}

	public void HideView()
	{
		_energiesView.Hide();
	}

	public void AddEnergies(int energies)
	{
		AddEnergiesCommand addEnergiesCommand = new AddEnergiesCommand(energies);
		addEnergiesCommand.Execute();
	}
}
