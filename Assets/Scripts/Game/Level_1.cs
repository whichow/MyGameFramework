
public class Level_1 : GameLevel
{
    private string mapAsset = "Level1";
    private GameStage currentStage;

    public override void Init()
    {
        AssetLoader assetLoader = App.Instance.GetManager<AssetLoader>();
        assetLoader.LoadMap(mapAsset);

        var stage = new GameStage(EnemyType.Creeper, 10);
        currentStage = stage;

        stage.SetNextStage(new GameStage(EnemyType.Creeper, 12), 15f);
        stage = stage.NextStage();

        stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        stage = stage.NextStage();

        stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        stage = stage.NextStage();

        stage.SetNextStage(new GameStage(EnemyType.Creeper, 13), 12f);
        stage = stage.NextStage();
    }

    public override void Update()
    {
        if (currentStage == null)
        {
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
}
