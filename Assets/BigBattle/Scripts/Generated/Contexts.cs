//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if (_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public ClientContext client { get; set; }
    public ServerContext server { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { client, server }; } }

    public Contexts() {
        client = new ClientContext();
        server = new ServerContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach (var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string BattleTeam = "BattleTeam";
    public const string BattleUnitId = "BattleUnitId";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        server.AddEntityIndex(new Entitas.EntityIndex<ServerEntity, int>(
            BattleTeam,
            server.GetGroup(ServerMatcher.BattleTeam),
            (e, c) => ((BigBattle.BattleTeamComponent)c).value));
        client.AddEntityIndex(new Entitas.EntityIndex<ClientEntity, int>(
            BattleTeam,
            client.GetGroup(ClientMatcher.BattleTeam),
            (e, c) => ((BigBattle.BattleTeamComponent)c).value));

        server.AddEntityIndex(new Entitas.PrimaryEntityIndex<ServerEntity, int>(
            BattleUnitId,
            server.GetGroup(ServerMatcher.BattleUnitId),
            (e, c) => ((BigBattle.BattleUnitIdComponent)c).value));
        client.AddEntityIndex(new Entitas.PrimaryEntityIndex<ClientEntity, int>(
            BattleUnitId,
            client.GetGroup(ClientMatcher.BattleUnitId),
            (e, c) => ((BigBattle.BattleUnitIdComponent)c).value));
    }
}

public static class ContextsExtensions {

    public static System.Collections.Generic.HashSet<ServerEntity> GetEntitiesWithBattleTeam(this ServerContext context, int value) {
        return ((Entitas.EntityIndex<ServerEntity, int>)context.GetEntityIndex(Contexts.BattleTeam)).GetEntities(value);
    }

    public static System.Collections.Generic.HashSet<ClientEntity> GetEntitiesWithBattleTeam(this ClientContext context, int value) {
        return ((Entitas.EntityIndex<ClientEntity, int>)context.GetEntityIndex(Contexts.BattleTeam)).GetEntities(value);
    }

    public static ServerEntity GetEntityWithBattleUnitId(this ServerContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<ServerEntity, int>)context.GetEntityIndex(Contexts.BattleUnitId)).GetEntity(value);
    }

    public static ClientEntity GetEntityWithBattleUnitId(this ClientContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<ClientEntity, int>)context.GetEntityIndex(Contexts.BattleUnitId)).GetEntity(value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContextObservers() {
        try {
            CreateContextObserver(client);
            CreateContextObserver(server);
        } catch(System.Exception) {
        }
    }

    public void CreateContextObserver(Entitas.IContext context) {
        if (UnityEngine.Application.isPlaying) {
            var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
            UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
        }
    }

#endif
}