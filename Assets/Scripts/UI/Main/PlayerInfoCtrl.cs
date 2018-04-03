using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoCtrl : BaseCtrl<PlayerInfoCtrl>
{
	private PlayerInfoView _playerInfoView;

	public override void Init()
	{
		_playerInfoView = new PlayerInfoView(UITool.FindUIGameObject("PlayerInfoView"));
		_playerInfoView.Init();
	}

	public override void Release()
	{
		_playerInfoView.Release();
		_playerInfoView = null;
	}

	public void ShowView()
	{
		_playerInfoView.Show();
	}

	public void HideView()
	{
		_playerInfoView.Hide();
	}
}
