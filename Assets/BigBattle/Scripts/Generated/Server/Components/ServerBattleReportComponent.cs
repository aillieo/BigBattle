//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerContext {

    public ServerEntity battleReportEntity { get { return GetGroup(ServerMatcher.BattleReport).GetSingleEntity(); } }
    public BigBattle.BattleReportComponent battleReport { get { return battleReportEntity.battleReport; } }
    public bool hasBattleReport { get { return battleReportEntity != null; } }

    public ServerEntity SetBattleReport(BigBattle.BattleReport newValue) {
        if (hasBattleReport) {
            throw new Entitas.EntitasException("Could not set BattleReport!\n" + this + " already has an entity with BigBattle.BattleReportComponent!",
                "You should check if the context already has a battleReportEntity before setting it or use context.ReplaceBattleReport().");
        }
        var entity = CreateEntity();
        entity.AddBattleReport(newValue);
        return entity;
    }

    public void ReplaceBattleReport(BigBattle.BattleReport newValue) {
        var entity = battleReportEntity;
        if (entity == null) {
            entity = SetBattleReport(newValue);
        } else {
            entity.ReplaceBattleReport(newValue);
        }
    }

    public void RemoveBattleReport() {
        battleReportEntity.Destroy();
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

    public BigBattle.BattleReportComponent battleReport { get { return (BigBattle.BattleReportComponent)GetComponent(ServerComponentsLookup.BattleReport); } }
    public bool hasBattleReport { get { return HasComponent(ServerComponentsLookup.BattleReport); } }

    public void AddBattleReport(BigBattle.BattleReport newValue) {
        var index = ServerComponentsLookup.BattleReport;
        var component = (BigBattle.BattleReportComponent)CreateComponent(index, typeof(BigBattle.BattleReportComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBattleReport(BigBattle.BattleReport newValue) {
        var index = ServerComponentsLookup.BattleReport;
        var component = (BigBattle.BattleReportComponent)CreateComponent(index, typeof(BigBattle.BattleReportComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBattleReport() {
        RemoveComponent(ServerComponentsLookup.BattleReport);
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
public partial class ServerEntity : IBattleReportEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherBattleReport;

    public static Entitas.IMatcher<ServerEntity> BattleReport {
        get {
            if (_matcherBattleReport == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.BattleReport);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherBattleReport = matcher;
            }

            return _matcherBattleReport;
        }
    }
}
