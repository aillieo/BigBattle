using UnityEngine;

namespace BigBattle
{
    public interface IGameObjectCreateService
    {
        GameObject CreateGameObject(AssetNamePair assetNamePair);
    }
}
