//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerEntity {

    public BigBattle.BattleUnitIdComponent battleUnitId { get { return (BigBattle.BattleUnitIdComponent)GetComponent(ServerComponentsLookup.BattleUnitId); } }
    public bool hasBattleUnitId { get { return HasComponent(ServerComponentsLookup.BattleUnitId); } }

    public void AddBattleUnitId(int newValue) {
        var index = ServerComponentsLookup.BattleUnitId;
        var component = (BigBattle.BattleUnitIdComponent)CreateComponent(index, typeof(BigBattle.BattleUnitIdComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleUnitId(int newValue) {
        var index = ServerComponentsLookup.BattleUnitId;
        var component = (BigBattle.BattleUnitIdComponent)CreateComponent(index, typeof(BigBattle.BattleUnitIdComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleUnitId() {
        RemoveComponent(ServerComponentsLookup.BattleUnitId);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerEntity : IBattleUnitIdEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherBattleUnitId;

    public static Entitas.IMatcher<ServerEntity> BattleUnitId {
        get {
            if (_matcherBattleUnitId == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.BattleUnitId);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherBattleUnitId = matcher;
            }

            return _matcherBattleUnitId;
        }
    }
}