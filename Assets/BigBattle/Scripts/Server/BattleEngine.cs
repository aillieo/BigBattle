using System.Collections;
using System.Collections.Generic;
using System;
using AillieoUtils;
using Entitas;

namespace BigBattle.Server
{
    public class BattleEngine
    {
        Feature _systems;

        ServerContext _context;

        public void Init(BattleConfig battleConfig)
        {
            Service.Instance.InitInjections();

            var contexts = Contexts.sharedInstance;
            contexts.server.CreateEntity().AddBattleConfig(battleConfig);
            _systems = new Feature("Server");
            _systems.Add(new SBattleInitSystem(contexts));
            _systems.Add(new STimerSystem(contexts));
            _systems.Add(new SBattleStateSystem(contexts));
            _systems.Add(new STargetingSystem(contexts));
            _systems.Add(new SDirectionSystem(contexts));
            _systems.Add(new SSpeedSystem(contexts));
            _systems.Add(new SMoveSystem(contexts));
            _systems.Add(new SBattleActionSystem(contexts));
            _systems.Add(new SBattleActionCleanUpSystem(contexts));

            _systems.Initialize();
        }

        public BattleReport DoPlayBattle()
        {
            _context = Contexts.sharedInstance.server;

            while (!_context.isBattleEnd)
            {
                _systems.Execute();
                _systems.Cleanup();
            }

            BattleReport battleReport = _context.battleReport.value;

            OnBattleEnd();

            return battleReport;
        }

        private void OnBattleEnd()
        {
            _systems.TearDown();
        }

    }
}

