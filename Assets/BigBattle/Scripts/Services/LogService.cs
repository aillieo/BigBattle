using UnityEngine;
using AillieoUtils;

namespace BigBattle
{
    public class UnityDebugService : ILogService
    {
        public UnityDebugService()
        {
            if(AppConst.AsyncServer)
            {
                ThreadHelper.CreateInstance();
            }
        }

        public void Log(string str)
        {
            if(AppConst.AsyncServer)
            {
                ThreadHelper.Instance.QueueMainThread(
                ()=> {
                    Debug.Log(str);
                });
            }
            else
            {
                Debug.Log(str);
            }
        }
    }
}