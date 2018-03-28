using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsView : UIView
{
    private Button _closeButton;
    private InputField _coinsField;
    private Button _confirmButton;

    public CoinsView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _closeButton = UITool.GetComponent<Button>(_gameObject, "Close");
        _closeButton.onClick.AddListener(OnCloseButtonClick);
        _coinsField = UITool.GetComponent<InputField>(_gameObject, "Coins");
        _confirmButton = UITool.GetComponent<Button>(_gameObject, "Confirm");
        _confirmButton.onClick.AddListener(OnConfirmButtonClick);
		Hide();
    }

    private void OnCloseButtonClick()
    {
        CoinsCtrl.Instance.HideView();
    }

    private void OnConfirmButtonClick()
    {
        int coins;
        if (int.TryParse(_coinsField.text, out coins))
        {
			Debug.Log("AddCoins:" + coins);
            CoinsCtrl.Instance.AddCoins(coins);
        }
    }
}
