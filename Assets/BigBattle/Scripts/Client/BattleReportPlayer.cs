using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Client
{
    public class BattleReportPlayer
    {
        Feature _systems;

        public void Init(BattleReport battleReport)
        {

            Service.Instance.InitInjections();

            var contexts = Contexts.sharedInstance;
            contexts.client.CreateEntity().AddBattleReport(battleReport);
            _systems = new Feature("Client");
            _systems.Add(new CBattleInitSystem(contexts));
            _systems.Add(new CMapInitSystem(contexts));
            _systems.Add(new CTimerSystem(contexts));
            _systems.Add(new CBattleUnitCreateSystem(contexts));
            _systems.Add(new CDirectionSystem(contexts));
            _systems.Add(new CReportReaderSystem(contexts));
            _systems.Add(new CBattleActionHandlerSystem(contexts));
            _systems.Add(new CMoveSystem(contexts));
            _systems.Add(new ClientEventSystems(contexts));
            _systems.Add(new CBattleActionCleanUpSystem(contexts));

            _systems.Initialize();
        }

        public void Execute()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        public void OnPlayEnd()
        {
            _systems.TearDown();
        }

    }
}
