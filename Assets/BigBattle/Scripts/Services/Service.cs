using System.Collections;
using System.Collections.Generic;
using AillieoUtils;
using Zenject;

namespace BigBattle
{
    public class Service :Singleton<Service>
    {
        [Inject]
        public ILogService logService;

        [Inject]
        public IGameObjectCreateService gameObjectCreateService;


        public void InitInjections()
        {
            DiContainer container = new DiContainer();
            container.Bind<ILogService>().To<UnityDebugService>().AsSingle();
            container.Bind<IGameObjectCreateService>().To<GameObjectCreateService>().AsSingle();
            container.Inject(this);
        }
    }

}


