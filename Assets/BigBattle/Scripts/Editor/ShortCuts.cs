using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UObject = UnityEngine.Object;
using Process = System.Diagnostics.Process;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine.UI;

namespace BigBattle
{

    public class ShortCuts
    {

        [MenuItem("BigBattle/ShortCuts/SwitchToServer")]
        static void SwitchToServer()
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/BigBattle/Scenes/SceneServer.unity");
        }

        [MenuItem("BigBattle/ShortCuts/SwitchToClient")]
        static void SwitchToClient()
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/BigBattle/Scenes/SceneClient.unity");
        }

        [MenuItem("BigBattle/ShortCuts/RunServer")]
        static void RunServer()
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/BigBattle/Scenes/SceneServer.unity");
            EditorApplication.isPlaying = true;
        }

        [MenuItem("BigBattle/ShortCuts/RunClient")]
        static void RunClient()
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/BigBattle/Scenes/SceneClient.unity");
            EditorApplication.isPlaying = true;
        }


#if !ENTITAS_DISABLE_VISUAL_DEBUGGING
        [MenuItem("BigBattle/ShortCuts/DisableEntitasVisualDebug")]
        static void DisableEntitasVisualDebug()
        {
            var str = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
            str += ";ENTITAS_DISABLE_VISUAL_DEBUGGING";
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, str);
        }
#else
        [MenuItem("BigBattle/ShortCuts/EnableEntitasVisualDebug")]
        static void EnableEntitasVisualDebug()
        {
            var str = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
            str.Replace("ENTITAS_DISABLE_VISUAL_DEBUGGING", string.Empty);
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, str);
        }
#endif

    }

}
