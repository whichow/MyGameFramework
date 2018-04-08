
public class Level_1 : GameLevel
{
    private string mapAsset = "Level1";
    private GameStage currentStage;
    private bool gameStart;

    public override void Init()
    {
        AssetLoader assetLoader = App.Instance.GetManager<AssetLoader>();
        assetLoader.LoadMap(mapAsset);

        var stage = new GameStage(EnemyType.Creeper, 10);
        currentStage = stage;

        stage.SetNextStage(new GameStage(EnemyType.Creeper, 12), 15f);
        stage = stage.NextStage();

        // stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        // stage = stage.NextStage();

        // stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        // stage = stage.NextStage();

        // stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        // stage = stage.NextStage();
    }

    public override void Release()
    {
        currentStage = null;
        gameStart = false;
    }

    public override void Update()
    {
        if(!gameStart)
        {
            return;
        }
        if (currentStage == null)
        {
            GameSceneManager.Instance.ExitGame();
            gameStart = false;
            return;
        }
        if (currentStage.isOver)
        {
            currentStage = currentStage.NextStage();
        }
        if (currentStage != null)
        {
            currentStage.Update();
        }
    }

    public override void StartGame()
    {
        gameStart = true;
    }
}
