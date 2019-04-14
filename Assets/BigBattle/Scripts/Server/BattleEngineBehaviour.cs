using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AillieoUtils;
using System.Threading.Tasks;

namespace BigBattle.Server
{
    public class BattleEngineBehaviour : MonoBehaviour
    {
        public string battleReportName;

        public string battleConfigName;

        private void Start()
        {
            if(!string.IsNullOrEmpty(battleConfigName))
            {
                BeginSimulation();
            }
        }

        private void BeginSimulation()
        {
            BattleConfig battleConfig = null;

            SerializeHelper.DeserializeJsonToData(Utils.GetBattleConfigPath(battleConfigName), out battleConfig);

            BattleEngine battleEngine = new BattleEngine();

            battleEngine.Init(battleConfig);

            if (AppConst.AsyncServer)
            {
                Task<BattleReport> task = new Task<BattleReport>(battleEngine.DoPlayBattle);

                task.Start();

                task.GetAwaiter().OnCompleted(() => EndSimulation(task));
            }
            else
            {
                BattleReport battleReport = battleEngine.DoPlayBattle();

                EndSimulation(battleReport);
            }

        }

        private void EndSimulation(Task<BattleReport> task)
        {
            if(task.IsCompleted)
            {
                EndSimulation(task.Result);
            }
            else
            {
                Debug.LogError("task failed ->  " + task.ToString());
            }
        }

        private void EndSimulation(BattleReport battleReport)
        {
            if (!string.IsNullOrEmpty(battleReportName))
            {
                SerializeHelper.SerializeDataToBytes<BattleReport>(battleReport, Utils.GetBattleReportPath(battleReportName));
                SerializeHelper.SerializeDataToJson<BattleReport>(battleReport, Utils.GetBattleReportPath(battleReportName) + ".json");
            }
            Debug.LogWarning("result ->  " + battleReportName);
        }
    }
}
