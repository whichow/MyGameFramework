using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : UIView
{
    private Animator[] _heartAnims;
    private int _heartIndex;
    private Dragable[] _towerItems;
    private Button _startGameButton;
    private TowerType[] _towers = new TowerType[] { TowerType.Laser, TowerType.Laser, TowerType.Laser, TowerType.Laser, TowerType.Laser };

    public GameView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _heartAnims = UITool.GetComponentsInChildren<Animator>(_gameObject, "Health");
        _heartIndex = _heartAnims.Length - 1;

        _towerItems = UITool.GetComponentsInChildren<Dragable>(_gameObject, "Towers");

        for (int i = 0; i < _towerItems.Length; i++)
        {
            var index = i;
            _towerItems[i].onDragBegin.AddListener(() =>
            {
                OnDragBegin(_towers[index]);
            });
            _towerItems[i].onDragEnd.AddListener(OnDragEnd);
        }

        _startGameButton = UITool.GetComponent<Button>(_gameObject, "StartGame");
        _startGameButton.onClick.AddListener(OnStartGameButtonClick);
    }

    private void OnStartGameButtonClick()
    {
        GameSceneManager.Instance.StartGame();
    }

    public void LoseHeart()
    {
        if (_heartIndex >= 0)
        {
            _heartAnims[_heartIndex].SetTrigger("Lose");
            _heartIndex--;
        }
    }

    public void GetHeart()
    {
        if (_heartIndex <= _heartAnims.Length - 1)
        {
            _heartAnims[_heartIndex].SetTrigger("Get");
            _heartIndex++;
        }
    }

    private void OnDragBegin(TowerType tower)
    {
        GameCtrl.Instance.BeginPlaceTower(tower);
    }

    private void OnDragEnd()
    {
        GameCtrl.Instance.EndPlaceTower();
    }
}
