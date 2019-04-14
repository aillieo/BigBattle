//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ClientEntity {

    public BigBattle.BattleTeamComponent battleTeam { get { return (BigBattle.BattleTeamComponent)GetComponent(ClientComponentsLookup.BattleTeam); } }
    public bool hasBattleTeam { get { return HasComponent(ClientComponentsLookup.BattleTeam); } }

    public void AddBattleTeam(int newValue) {
        var index = ClientComponentsLookup.BattleTeam;
        var component = (BigBattle.BattleTeamComponent)CreateComponent(index, typeof(BigBattle.BattleTeamComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleTeam(int newValue) {
        var index = ClientComponentsLookup.BattleTeam;
        var component = (BigBattle.BattleTeamComponent)CreateComponent(index, typeof(BigBattle.BattleTeamComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleTeam() {
        RemoveComponent(ClientComponentsLookup.BattleTeam);
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
public partial class ClientEntity : IBattleTeamEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ClientMatcher {

    static Entitas.IMatcher<ClientEntity> _matcherBattleTeam;

    public static Entitas.IMatcher<ClientEntity> BattleTeam {
        get {
            if (_matcherBattleTeam == null) {
                var matcher = (Entitas.Matcher<ClientEntity>)Entitas.Matcher<ClientEntity>.AllOf(ClientComponentsLookup.BattleTeam);
                matcher.componentNames = ClientComponentsLookup.componentNames;
                _matcherBattleTeam = matcher;
            }

            return _matcherBattleTeam;
        }
    }
}
