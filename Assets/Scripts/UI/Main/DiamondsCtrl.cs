using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondsCtrl : BaseCtrl<DiamondsCtrl>
{
	private DiamondsView _diamondsView;

	public override void Init()
	{
		_diamondsView = new DiamondsView(UITool.FindUIGameObject("DiamondsView"));
		_diamondsView.Init();
	}

	public override void Release()
	{
		_diamondsView.Release();
	}

	public void ShowView()
	{
		_diamondsView.Show();
	}

	public void HideView()
	{
		_diamondsView.Hide();
	}

	public void AddDiamonds(int diamonds)
	{
		AddDiamondsCommand addDiamondsCommand = new AddDiamondsCommand(diamonds);
		addDiamondsCommand.Execute();
	}
}
