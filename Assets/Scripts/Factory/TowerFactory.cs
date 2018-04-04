using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerType
{
    Laser
}

public abstract class TowerFactory
{
	public abstract Tower CreateTower();
}
