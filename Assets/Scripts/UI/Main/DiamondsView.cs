using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondsView : UIView
{
    private Button _closeButton;
    private InputField _diamondsField;
    private Button _confirmButton;

    public DiamondsView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _closeButton = UITool.GetComponent<Button>(_gameObject, "Close");
        _closeButton.onClick.AddListener(OnCloseButtonClick);
        _diamondsField = UITool.GetComponent<InputField>(_gameObject, "Diamonds");
        _confirmButton = UITool.GetComponent<Button>(_gameObject, "Confirm");
        _confirmButton.onClick.AddListener(OnConfirmButtonClick);
		Hide();
    }

    private void OnCloseButtonClick()
    {
        DiamondsCtrl.Instance.HideView();
    }

    private void OnConfirmButtonClick()
    {
        int diamonds;
        if (int.TryParse(_diamondsField.text, out diamonds))
        {
			Debug.Log("AddDiamonds:" + diamonds);
            DiamondsCtrl.Instance.AddDiamonds(diamonds);
        }
    }
}
