//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerContext {

    public ServerEntity battleEndEntity { get { return GetGroup(ServerMatcher.BattleEnd).GetSingleEntity(); } }

    public bool isBattleEnd {
        get { return battleEndEntity != null; }
        set {
            var entity = battleEndEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isBattleEnd = true;
                } else {
                    entity.Destroy();
                }
            }
        }
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

    static readonly BigBattle.BattleEndComponent battleEndComponent = new BigBattle.BattleEndComponent();

    public bool isBattleEnd {
        get { return HasComponent(ServerComponentsLookup.BattleEnd); }
        set {
            if (value != isBattleEnd) {
                var index = ServerComponentsLookup.BattleEnd;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : battleEndComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public partial class ServerEntity : IBattleEndEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherBattleEnd;

    public static Entitas.IMatcher<ServerEntity> BattleEnd {
        get {
            if (_matcherBattleEnd == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.BattleEnd);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherBattleEnd = matcher;
            }

            return _matcherBattleEnd;
        }
    }
}
