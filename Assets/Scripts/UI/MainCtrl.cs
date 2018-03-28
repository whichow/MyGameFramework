
using UnityEngine;

public class MainCtrl : Singleton<MainCtrl>
{
    private MainView _mainView;

    public override void Init()
    {
        _mainView = new MainView(UITool.FindUIGameObject("MainView"));
        _mainView.Init();
        SetCoins(PlayerPrefs.GetInt("Coins", 0));
        SetDiamonds(PlayerPrefs.GetInt("Diamonds", 0));
        SetEnergies(PlayerPrefs.GetInt("Energies", 0));
    }

    public override void Release()
    {
        _mainView.Release();
        _mainView = null;
    }

    public override void Update()
    {
        
    }

    public void SetHeadIcon(string path)
    {
        _mainView.SetHeadIcon(path);
    }

    public void SetCoins(int coins)
    {
        _mainView.SetCoins(coins);
    }

    public void SetDiamonds(int diamonds)
    {
        _mainView.SetDiamonds(diamonds);
    }

    public void SetEnergies(int energies)
    {
        _mainView.SetEnergies(energies);
    }

    public void ShowAddCoins()
    {
        HideAll();
        CoinsCtrl.Instance.ShowView();
    }

    public void ShowAddDiamonds()
    {
        HideAll();
        DiamondsCtrl.Instance.ShowView();
    }

    public void ShowAddEnergies()
    {
        HideAll();
        EnergiesCtrl.Instance.ShowView();
    }

    public void ShowPlayerInfo()
    {
        HideAll();
        PlayerInfoCtrl.Instance.ShowView();
    }

    public void HideAll()
    {
        CoinsCtrl.Instance.HideView();
        DiamondsCtrl.Instance.HideView();
        EnergiesCtrl.Instance.HideView();
        PlayerInfoCtrl.Instance.HideView();
    }
}
