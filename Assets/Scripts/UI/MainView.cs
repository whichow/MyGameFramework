using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : UIView
{
	private Image _headIcon;
	private Button _headButton;
	private Text _coinsText;
	private Button _addCoinsButton;
	private Text _diamondsText;
	private Button _addDiamondsButton;
	private Text _energiesText;
	private Button _addEnergiesButton;
	
    public MainView(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Init()
    {
        _headIcon = UITool.GetComponent<Image>(_gameObject, "Head/Icon");
		_headButton = UITool.GetComponent<Button>(_gameObject, "Head");
		_headButton.onClick.AddListener(OnHeadButtonClick);
		_coinsText = UITool.GetComponent<Text>(_gameObject, "Coins/Text");
		_addCoinsButton = UITool.GetComponent<Button>(_gameObject, "Coins/Add");
		_addCoinsButton.onClick.AddListener(OnAddCoinsButtonClick);
		_diamondsText = UITool.GetComponent<Text>(_gameObject, "Diamonds/Text");
		_addDiamondsButton = UITool.GetComponent<Button>(_gameObject, "Diamonds/Add");
		_addDiamondsButton.onClick.AddListener(OnAddDiamondsButtonClick);
		_energiesText = UITool.GetComponent<Text>(_gameObject, "Energies/Text");
		_addEnergiesButton = UITool.GetComponent<Button>(_gameObject, "Energies/Add");
		_addEnergiesButton.onClick.AddListener(OnAddEnergiesButtonClick);
    }

    private void OnHeadButtonClick()
    {
        MainCtrl.Instance.ShowPlayerInfo();
    }

    private void OnAddCoinsButtonClick()
    {
        MainCtrl.Instance.ShowAddCoins();
    }

    private void OnAddEnergiesButtonClick()
    {
        MainCtrl.Instance.ShowAddEnergies();
    }

    private void OnAddDiamondsButtonClick()
    {
        MainCtrl.Instance.ShowAddDiamonds();
    }

    public void SetHeadIcon(string path)
	{
		_headIcon.sprite = ResourceManager.Load<Sprite>(path);
	}

	public void SetCoins(int coins)
	{
		_coinsText.text = coins.ToString();
	}

	public void SetDiamonds(int diamonds)
	{
		_diamondsText.text = diamonds.ToString();
	}

	public void SetEnergies(int energies)
	{
		_energiesText.text = energies.ToString();
	}
}
