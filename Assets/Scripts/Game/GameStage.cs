
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameStage
{
    public bool isOver;

    private Queue<Enemy> _enemies = new Queue<Enemy>();
    private GameStage _nextStage;
    private float _nextStageTime;
    private float _currentTime;
    private static readonly float ENEMY_SPAWN_INTERVAL = 0.5f;
    private float _enemySpawnTime;

    public GameStage(EnemyType enemyType, int enemyCount)
    {
        var enemyFactory = FactoryCenter.GetEnemyFactory(enemyType);
        for (int i = 0; i < enemyCount; i++)
        {
            var enemy = enemyFactory.CreateEnemy();
            enemy.SetActive(false);
            _enemies.Enqueue(enemy);
        }
    }

    public void SetNextStage(GameStage stage, float time)
    {
        _nextStage = stage;
        _nextStageTime = time;
    }

    public void Update()
    {
        _currentTime += Time.deltaTime;
        if(_currentTime >= _nextStageTime)
        {
            isOver = true;
        }
        _enemySpawnTime += Time.deltaTime;
        if(_enemySpawnTime > ENEMY_SPAWN_INTERVAL && _enemies.Count > 0)
        {
            _enemySpawnTime = 0f;
            var enemy = _enemies.Dequeue();
            enemy.SetActive(true);
        }
    }

    public GameStage NextStage()
    {
        return _nextStage;
    }
}
