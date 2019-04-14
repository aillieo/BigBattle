using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif    
using AillieoUtils;

namespace BigBattle
{
    public class BattleConfigHelper : ScriptableObject
    {

        public string configName = "default";

        public BattleConfig battleConfig;

    }


#if UNITY_EDITOR

    [CustomEditor(typeof(BattleConfigHelper))]
    public class BattleConfigHelperEditor : Editor
    {

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Save"))
            {
                BattleConfigHelper config = (BattleConfigHelper)target;
                SerializeHelper.SerializeDataToJson(config.battleConfig, Utils.GetBattleConfigPath(config.configName));
                AssetDatabase.Refresh();
            }

            if (GUILayout.Button("Load"))
            {
                BattleConfigHelper config = (BattleConfigHelper)target;
                BattleConfig battleConfig = null;
                SerializeHelper.DeserializeJsonToData<BattleConfig>(Utils.GetBattleConfigPath(config.configName), out battleConfig);
                if(battleConfig != null)
                {
                    config.battleConfig = battleConfig;
                }
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
#endif

}