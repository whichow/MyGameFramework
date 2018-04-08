using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : BaseCtrl<GameCtrl>
{
	private GameView _gameView;
	private float _time;
	private Tower _placingTower;

	public override void Init()
	{
		_gameView = new GameView(UITool.FindUIGameObject("GameView"));
		_gameView.Init();
	}

	public override void Release()
	{
		_gameView.Release();
		_gameView = null;
	}

	public override void Update()
	{
		_time += Time.deltaTime;
		if(_time > 3f)
		{
			LoseHeart();
			_time = 0f;
		}
	}

	public void LoseHeart()
	{
		_gameView.LoseHeart();
	}

	public void GetHeart()
	{
		_gameView.GetHeart();
	}

	public void BeginPlaceTower(TowerType tower)
	{
		var towerFactory = FactoryCenter.GetTowerFactory(tower);
		_placingTower = towerFactory.CreateTower();
		_placingTower.SetPlaceable(true);
	}

	public void EndPlaceTower()
	{
		if(_placingTower.CanPlace())
		{
			_placingTower.SetPlaceable(false);
		}
		else
		{
			_placingTower.Destroy();
		}
		_placingTower = null;
	}
}
