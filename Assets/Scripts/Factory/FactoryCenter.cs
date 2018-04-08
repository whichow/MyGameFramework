
using System.Collections.Generic;

public class FactoryCenter
{
    private static Dictionary<TowerType, TowerFactory> _towerFactorys = new Dictionary<TowerType, TowerFactory>();
    private static Dictionary<EnemyType, EnemyFactory> _enemyFactorys = new Dictionary<EnemyType, EnemyFactory>();

    public static TowerFactory GetTowerFactory(TowerType towerType)
    {
        if(!_towerFactorys.ContainsKey(towerType))
        {
            _towerFactorys.Add(towerType, CreateTowerFactory(towerType));
        }
        return _towerFactorys[towerType];
    }

    public static EnemyFactory GetEnemyFactory(EnemyType enemyType)
    {
        if (!_enemyFactorys.ContainsKey(enemyType))
        {
            _enemyFactorys.Add(enemyType, CreateEnemyFactory(enemyType));
        }
        return _enemyFactorys[enemyType];
    }

    public static TowerFactory CreateTowerFactory(TowerType towerType)
    {
        switch (towerType)
        {
            case TowerType.Laser:
                return new LaserTowerFactory();
            default:
                return null;
        }
    }

    public static EnemyFactory CreateEnemyFactory(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Creeper:
                return new EnemyCreeperFactory();
            default:
                return null;
        }
    }
}
