//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerEntity {

    public BigBattle.BattleUnitComponent battleUnit { get { return (BigBattle.BattleUnitComponent)GetComponent(ServerComponentsLookup.BattleUnit); } }
    public bool hasBattleUnit { get { return HasComponent(ServerComponentsLookup.BattleUnit); } }

    public void AddBattleUnit(BigBattle.BattleUnitData newValue) {
        var index = ServerComponentsLookup.BattleUnit;
        var component = (BigBattle.BattleUnitComponent)CreateComponent(index, typeof(BigBattle.BattleUnitComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleUnit(BigBattle.BattleUnitData newValue) {
        var index = ServerComponentsLookup.BattleUnit;
        var component = (BigBattle.BattleUnitComponent)CreateComponent(index, typeof(BigBattle.BattleUnitComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleUnit() {
        RemoveComponent(ServerComponentsLookup.BattleUnit);
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
public partial class ServerEntity : IBattleUnitEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherBattleUnit;

    public static Entitas.IMatcher<ServerEntity> BattleUnit {
        get {
            if (_matcherBattleUnit == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.BattleUnit);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherBattleUnit = matcher;
            }

            return _matcherBattleUnit;
        }
    }
}
