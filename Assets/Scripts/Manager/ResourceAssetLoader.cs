using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceAssetLoader : AssetLoader
{
    public const string TowerPath = "Prefabs/Tower/";
    public const string EnemyPath = "Prefabs/Enemy/";
    public const string MapPath = "Prefabs/Map/";
    public const string AudioPath = "Audios/";
    public const string SpritePath = "Sprites/";

    public override GameObject LoadEnemy(string assetName)
    {
        GameObject prefab = Load(EnemyPath + assetName) as GameObject;
        GameObject go = null;
        if (prefab != null)
        {
            go = Object.Instantiate<GameObject>(prefab);
        }
        return go;
    }

    public override GameObject LoadTower(string assetName)
    {
        GameObject prefab = Load(TowerPath + assetName) as GameObject;
        GameObject go = null;
        if (prefab != null)
        {
            go = Object.Instantiate<GameObject>(prefab);
        }
        return go;
    }

    public override GameObject LoadMap(string assetName)
    {
        GameObject prefab = Load(MapPath + assetName) as GameObject;
        GameObject go = null;
        if (prefab != null)
        {
            go = Object.Instantiate<GameObject>(prefab);
        }
        return go;
    }

    public override AudioClip LoadAudio(string assetName)
    {
        return Load(AudioPath + assetName) as AudioClip;
    }

    public override Sprite LoadSprite(string assetName)
    {
        return Load(SpritePath + assetName) as Sprite;
    }

    private Object Load(string path)
    {
        return Resources.Load(path);
    }
}
