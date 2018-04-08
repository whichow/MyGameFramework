using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : Singleton<GameSceneManager>
{
    private GameLevel gameLevel;
    private InputSystem inputSystem;
    private GameCtrl gameCtrl;

    public void Init(int level)
    {
        switch (level)
        {
            case 1:
                gameLevel = new Level_1();
                break;
            case 2:
                gameLevel = new Level_2();
                break;
            case 3:
                gameLevel = new Level_3();
                break;
        }
        inputSystem = new InputSystem();
        gameCtrl = GameCtrl.Instance;

        gameLevel.Init();
        gameCtrl.Init();
        inputSystem.Init();
    }

    public void Release()
    {
        gameLevel.Release();
        gameCtrl.Release();
        inputSystem.Release();
    }

    public void Update()
    {
        gameLevel.Update();
        gameCtrl.Update();
        inputSystem.Update();
    }

	public void ExitGame()
	{
		gameLevel.ExitGame();
	}

	public void StartGame()
	{
		gameLevel.StartGame();
	}
}
