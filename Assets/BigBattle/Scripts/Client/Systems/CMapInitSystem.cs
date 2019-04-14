using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace BigBattle.Client
{
    public class CMapInitSystem : IInitializeSystem
    {
        readonly ClientContext _context;

        public CMapInitSystem(Contexts contexts)
        {
            _context = contexts.client;
        }

        public void Initialize()
        {
            var map = Service.Instance.gameObjectCreateService.CreateGameObject(new AssetNamePair("Prefabs/Maps", "MapQuad"));
            var size = _context.battleReport.value.battleMeta.battleConfig.mapSize;
            map.transform.localScale = new Vector3(size.x, 1, size.y);
            map.transform.localPosition = new Vector3(size.x /2 , 0 , size.y/2);
        }
    }
}
