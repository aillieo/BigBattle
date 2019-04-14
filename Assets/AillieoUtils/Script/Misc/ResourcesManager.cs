using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AillieoUtils
{
    public class ResourcesManager : Singleton<ResourcesManager>
    {
        public T LoadAsset<T>(string bundleName, string assetName) where T : UnityEngine.Object
        {
#if UNITY_EDITOR
            if (typeof(T) == typeof(GameObject))
            {
                assetName += ".prefab";
            }

            string assetPath = string.Format("Assets/BigBattle/ArtAssets/{0}/{1}", bundleName,assetName);
            return AssetDatabase.LoadAssetAtPath<T>(assetPath);
#else
            bundleName = bundleName.ToLower();
            AssetBundle bundle = AssetBundle.LoadFromStream(null);
            return bundle.LoadAsset<T>(assetName);
#endif
        }

        public GameObject LoadPrefab(string bundleName, string assetName)
        {
            GameObject go = LoadAsset<GameObject>(bundleName,assetName);
            return Object.Instantiate(go);
        }

    }
}
