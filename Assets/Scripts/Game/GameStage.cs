
using System;
using System.Collections.Generic;

public class GameStage
{
    internal bool isOver;
    private List<Enemy> _enemies = new List<Enemy>();

    public GameStage(EnemyType enemyType, int enemyCount)
    {
        var enemyFactory = FactoryCenter.GetEnemyFactory(enemyType);
        for (int i = 0; i < enemyCount; i++)
        {
            var enemy = enemyFactory.CreateEnemy();
            _enemies.Add(enemy);
        }
    }

    internal void SetNextStage(GameStage stage, float time)
    {
        throw new NotImplementedException();
    }

    internal void Update()
    {
        throw new NotImplementedException();
    }

    public GameStage NextStage()
    {
        throw new NotImplementedException();
    }
}
