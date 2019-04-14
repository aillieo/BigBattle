using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace BigBattle
{

    public enum FileFormat
    {
        Json,
        Bytes,
    }

    public class AppConst : ScriptableObject
    {
        private readonly static string assetPath = "Assets/BigBattle/Configs/@AppConst.asset";

        private static AppConst Instance
        { 
            get {
                if (mInstance == null)
                {
#if UNITY_EDITOR
                    mInstance = AssetDatabase.LoadAssetAtPath<AppConst>(assetPath);
                    if(mInstance == null)
                    {
                        mInstance = ScriptableObject.CreateInstance<AppConst>();
                        AssetDatabase.CreateAsset(mInstance, assetPath);
                        AssetDatabase.SaveAssets();
                        AssetDatabase.Refresh();
                    }
#endif
                }
                return mInstance;
            }
        }

        private static AppConst mInstance = null;


        [SerializeField]
        string reportPath = "";
        public static string ReportPath
        {
            get { return Application.dataPath + "/" + Instance.reportPath; }
        }


        [SerializeField]
        string configPath = "";
        public static string ConfigPath
        {
            get { return Application.dataPath + "/" + Instance.configPath; }
        }

        [SerializeField]
        Vector2 maxMapSize = new Vector2(100,100);
        public static Vector2 MaxMapSize
        {
            get { return Instance.maxMapSize; }
        }


        [SerializeField]
        float maxTimeCost = 60f;
        public static float MaxTimeCost
        {
            get { return Instance.maxTimeCost; }
        }

        [SerializeField]
        int maxFrameCount = 100;
        public static int MaxFrameCount
        {
            get { return Instance.maxFrameCount; }
        }


        [SerializeField]
        float timeStep = 0.1f;
        public static float TimeStep
        {
            get { return Instance.timeStep; }
        }

        [SerializeField]
        float rvoTimeStep = 0.3f;
        public static float RVOTimeStep
        {
            get { return Instance.rvoTimeStep; }
        }

        [SerializeField]
        float epsilon = 0.00001F;
        public static float Epsilon
        {
            get { return Instance.epsilon; }
        }

        [SerializeField]
        FileFormat battleReportFormat = FileFormat.Json;
        public static FileFormat BattleReportFormat
        {
            get { return Instance.battleReportFormat; }
        }
        
        [SerializeField]
        bool asyncServer = false;
        public static bool AsyncServer
        {
#if !ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR
            get { return false; }
#else
            get { return Instance.asyncServer; }
#endif
        }
    }
}