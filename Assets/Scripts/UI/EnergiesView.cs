using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergiesView : UIView
{
    private Button _closeButton;
    private InputField _energiessField;
    private Button _confirmButton;

    public EnergiesView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _closeButton = UITool.GetComponent<Button>(_gameObject, "Close");
        _closeButton.onClick.AddListener(OnCloseButtonClick);
        _energiessField = UITool.GetComponent<InputField>(_gameObject, "Energies");
        _confirmButton = UITool.GetComponent<Button>(_gameObject, "Confirm");
        _confirmButton.onClick.AddListener(OnConfirmButtonClick);
		Hide();
    }

    private void OnCloseButtonClick()
    {
        EnergiesCtrl.Instance.HideView();
    }

    private void OnConfirmButtonClick()
    {
        int energies;
        if (int.TryParse(_energiessField.text, out energies))
        {
			Debug.Log("AddEnergies:" + energies);
            EnergiesCtrl.Instance.AddEnergies(energies);
        }
    }
}
