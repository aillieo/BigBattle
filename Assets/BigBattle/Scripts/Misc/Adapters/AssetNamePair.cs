using System.Collections;
using System.Collections.Generic;
using System;

namespace BigBattle
{

    [Serializable]
    public struct AssetNamePair
    {
        public string bundleName;
        public string assetName;

        public AssetNamePair(string bundle, string asset)
        {
            this.bundleName = bundle;
            this.assetName = asset;
        }
    }
}