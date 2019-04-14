//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerContext {

    public ServerEntity battleConfigEntity { get { return GetGroup(ServerMatcher.BattleConfig).GetSingleEntity(); } }
    public BigBattle.BattleConfigComponent battleConfig { get { return battleConfigEntity.battleConfig; } }
    public bool hasBattleConfig { get { return battleConfigEntity != null; } }

    public ServerEntity SetBattleConfig(BigBattle.BattleConfig newValue) {
        if (hasBattleConfig) {
            throw new Entitas.EntitasException("Could not set BattleConfig!\n" + this + " already has an entity with BigBattle.BattleConfigComponent!",
                "You should check if the context already has a battleConfigEntity before setting it or use context.ReplaceBattleConfig().");
        }
        var entity = CreateEntity();
        entity.AddBattleConfig(newValue);
        return entity;
    }

    public void ReplaceBattleConfig(BigBattle.BattleConfig newValue) {
        var entity = battleConfigEntity;
        if (entity == null) {
            entity = SetBattleConfig(newValue);
        } else {
            entity.ReplaceBattleConfig(newValue);
        }
    }

    public void RemoveBattleConfig() {
        battleConfigEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerEntity {

    public BigBattle.BattleConfigComponent battleConfig { get { return (BigBattle.BattleConfigComponent)GetComponent(ServerComponentsLookup.BattleConfig); } }
    public bool hasBattleConfig { get { return HasComponent(ServerComponentsLookup.BattleConfig); } }

    public void AddBattleConfig(BigBattle.BattleConfig newValue) {
        var index = ServerComponentsLookup.BattleConfig;
        var component = (BigBattle.BattleConfigComponent)CreateComponent(index, typeof(BigBattle.BattleConfigComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleConfig(BigBattle.BattleConfig newValue) {
        var index = ServerComponentsLookup.BattleConfig;
        var component = (BigBattle.BattleConfigComponent)CreateComponent(index, typeof(BigBattle.BattleConfigComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleConfig() {
        RemoveComponent(ServerComponentsLookup.BattleConfig);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherBattleConfig;

    public static Entitas.IMatcher<ServerEntity> BattleConfig {
        get {
            if (_matcherBattleConfig == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.BattleConfig);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherBattleConfig = matcher;
            }

            return _matcherBattleConfig;
        }
    }
}
