//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ClientEntity {

    public BigBattle.BattleActionComponent battleAction { get { return (BigBattle.BattleActionComponent)GetComponent(ClientComponentsLookup.BattleAction); } }
    public bool hasBattleAction { get { return HasComponent(ClientComponentsLookup.BattleAction); } }

    public void AddBattleAction(BigBattle.BattleAction newValue) {
        var index = ClientComponentsLookup.BattleAction;
        var component = (BigBattle.BattleActionComponent)CreateComponent(index, typeof(BigBattle.BattleActionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleAction(BigBattle.BattleAction newValue) {
        var index = ClientComponentsLookup.BattleAction;
        var component = (BigBattle.BattleActionComponent)CreateComponent(index, typeof(BigBattle.BattleActionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleAction() {
        RemoveComponent(ClientComponentsLookup.BattleAction);
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
public partial class ClientEntity : IBattleActionEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ClientMatcher {

    static Entitas.IMatcher<ClientEntity> _matcherBattleAction;

    public static Entitas.IMatcher<ClientEntity> BattleAction {
        get {
            if (_matcherBattleAction == null) {
                var matcher = (Entitas.Matcher<ClientEntity>)Entitas.Matcher<ClientEntity>.AllOf(ClientComponentsLookup.BattleAction);
                matcher.componentNames = ClientComponentsLookup.componentNames;
                _matcherBattleAction = matcher;
            }

            return _matcherBattleAction;
        }
    }
}
