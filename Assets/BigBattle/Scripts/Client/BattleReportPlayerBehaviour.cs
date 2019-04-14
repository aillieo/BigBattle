using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AillieoUtils;

namespace BigBattle.Client
{
    public class BattleReportPlayerBehaviour : MonoBehaviour
    {
        public string battleReportName;

        BattleReportPlayer battleReportPlayer;

        private void Start()
        {
            if(!string.IsNullOrEmpty(battleReportName))
            {
                BattleReport battleReport = null;

                SerializeHelper.DeserializeBytesToData<BattleReport>(Utils.GetBattleReportPath(battleReportName), out battleReport);

                battleReportPlayer = new BattleReportPlayer();

                battleReportPlayer.Init(battleReport);
            }

        }

        private void Update()
        {
            battleReportPlayer.Execute();
        }
    }
}
