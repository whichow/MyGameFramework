
public class FactoryCenter
{
    private static EnemyCreeperFactory enemyCreeperFactory = new EnemyCreeperFactory();
    private static LaserTowerFactory laserTowerFactory = new LaserTowerFactory();

    public static EnemyFactory GetEnemyFactory(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Creeper:
                return enemyCreeperFactory;
            default:
                return null;
        }
    }

    public static TowerFactory GetTowerFactory(TowerType towerType)
    {
        switch (towerType)
        {
            case TowerType.Laser:
                return laserTowerFactory;
            default:
                return null;
        }
    }
}
