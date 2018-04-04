using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : BaseCtrl<GameCtrl>
{
	private GameView _gameView;
	private float _time;
	private Tower _placingTower;
	private TowerFactory _towerFactory;

	public override void Init()
	{
		_gameView = new GameView(UITool.FindUIGameObject("GameView"));
		_gameView.Init();

		_towerFactory = FactoryCenter.GetTowerFactory(TowerType.Laser);
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

	public void BeginPlaceTower()
	{
		_placingTower = _towerFactory.CreateTower();
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
