using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigBattle
{
    public static class Utils
    {

        public static string GetBattleReportPath(string battleReportName)
        {
            return string.Format("{0}{1}.br",AppConst.ReportPath,battleReportName);
        }

        public static string GetBattleConfigPath(string battleConfigName)
        {
            return string.Format("{0}{1}.json", AppConst.ConfigPath, battleConfigName);
        }

    }

}