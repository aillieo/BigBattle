//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IDirectionEntity {

    BigBattle.DirectionComponent direction { get; }
    bool hasDirection { get; }

    void AddDirection(BigBattle.Vec2 newValue);
    void ReplaceDirection(BigBattle.Vec2 newValue);
    void RemoveDirection();
}
