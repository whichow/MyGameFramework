using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoView : UIView
{
	private Button _closeButton;

    public PlayerInfoView(GameObject gameObject) : base(gameObject)
    {
    }

	public override void Init()
	{
		_closeButton = UITool.GetComponent<Button>(_gameObject, "Close");
		_closeButton.onClick.AddListener(OnCloseButtonClick);
		Hide();
	}

    private void OnCloseButtonClick()
    {
        PlayerInfoCtrl.Instance.HideView();
    }
}
