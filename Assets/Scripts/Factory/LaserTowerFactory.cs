using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTowerFactory : TowerFactory
{
	private string asset = "Tow_Laser3";

    public override Tower CreateTower()
    {
		var assetLoader = App.Instance.GetManager<AssetLoader>();
        var go = assetLoader.LoadTower(asset);
		go.layer = LayerMask.NameToLayer("Tower");
		go.AddComponent<Placeable>();
		go.AddComponent<Clickable>();
		LaserTower laser = new LaserTower(go);
		return laser;
    }
}
