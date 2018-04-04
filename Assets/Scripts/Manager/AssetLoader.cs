using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AssetLoader
{
	public abstract GameObject LoadTower(string assetName);
	public abstract GameObject LoadEnemy(string assetName);
	public abstract Sprite LoadSprite(string assetName);
	public abstract AudioClip LoadAudio(string assetName);
	public abstract GameObject LoadMap(string assetName);
}
