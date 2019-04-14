using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AillieoUtils;

namespace BigBattle
{
    public class GameObjectCreateService : IGameObjectCreateService
    {
        public GameObject CreateGameObject(AssetNamePair assetNamePair)
        {
            return ResourcesManager.Instance.LoadPrefab(assetNamePair.bundleName,assetNamePair.assetName);
        }
    }
}
