using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatView : UIView
{
    private Button _closeButton;
    private Button _enterButton;
    private Button _previousButton;
    private Button _nextButton;
    private Pages _levelSelect;

    public int CurrentLevel
    {
        get
        {
            return _levelSelect.CurrentIndex + 1;
        }
    }

    public CombatView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _closeButton = UITool.GetComponent<Button>(_gameObject, "Close");
        _closeButton.onClick.AddListener(OnCloseButtonClick);

        _enterButton = UITool.GetComponent<Button>(_gameObject, "Enter");
        _enterButton.onClick.AddListener(OnEnterButtonClick);

        _previousButton = UITool.GetComponent<Button>(_gameObject, "Previous");
        _previousButton.onClick.AddListener(OnPreviousButtonClick);

        _nextButton = UITool.GetComponent<Button>(_gameObject, "Next");
        _nextButton.onClick.AddListener(OnNextButtonClick);

        _levelSelect = UITool.GetComponent<Pages>(_gameObject, "LevelSelect");

        Hide();
    }

    public void NextLevel()
    {
        _levelSelect.Next();
    }

    public void PreviousLevel()
    {
        _levelSelect.Previous();
    }

    private void OnNextButtonClick()
    {
        CombatCtrl.Instance.SelectNext();
    }

    private void OnPreviousButtonClick()
    {
        CombatCtrl.Instance.SelectPrevious();
    }

    private void OnEnterButtonClick()
    {
        CombatCtrl.Instance.EnterGame();
    }

    private void OnCloseButtonClick()
    {
        CombatCtrl.Instance.HideView();
    }
}
