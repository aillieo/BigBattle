//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface ISpeedEntity {

    BigBattle.SpeedComponent speed { get; }
    bool hasSpeed { get; }

    void AddSpeed(float newValue);
    void ReplaceSpeed(float newValue);
    void RemoveSpeed();
}
