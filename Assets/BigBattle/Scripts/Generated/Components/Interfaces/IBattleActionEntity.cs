//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IBattleActionEntity {

    BigBattle.BattleActionComponent battleAction { get; }
    bool hasBattleAction { get; }

    void AddBattleAction(BigBattle.BattleAction newValue);
    void ReplaceBattleAction(BigBattle.BattleAction newValue);
    void RemoveBattleAction();
}
