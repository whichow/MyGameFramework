
public class EnemyCreeperFactory : EnemyFactory
{
    private string asset = "Enm_Creeper";

    public override Enemy CreateEnemy()
    {
        var assetLoader = App.Instance.GetManager<AssetLoader>();
        var go = assetLoader.LoadEnemy(asset);
        go.AddComponent<TweenPath>();
        EnemyCreeper enemy = new EnemyCreeper(go);
        return enemy;
    }
}
