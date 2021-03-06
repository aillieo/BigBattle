//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServerContext {

    public ServerEntity frameCounterEntity { get { return GetGroup(ServerMatcher.FrameCounter).GetSingleEntity(); } }
    public BigBattle.FrameCounterComponent frameCounter { get { return frameCounterEntity.frameCounter; } }
    public bool hasFrameCounter { get { return frameCounterEntity != null; } }

    public ServerEntity SetFrameCounter(int newValue) {
        if (hasFrameCounter) {
            throw new Entitas.EntitasException("Could not set FrameCounter!\n" + this + " already has an entity with BigBattle.FrameCounterComponent!",
                "You should check if the context already has a frameCounterEntity before setting it or use context.ReplaceFrameCounter().");
        }
        var entity = CreateEntity();
        entity.AddFrameCounter(newValue);
        return entity;
    }

    public void ReplaceFrameCounter(int newValue) {
        var entity = frameCounterEntity;
        if (entity == null) {
            entity = SetFrameCounter(newValue);
        } else {
            entity.ReplaceFrameCounter(newValue);
        }
    }

    public void RemoveFrameCounter() {
        frameCounterEntity.Destroy();
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

    public BigBattle.FrameCounterComponent frameCounter { get { return (BigBattle.FrameCounterComponent)GetComponent(ServerComponentsLookup.FrameCounter); } }
    public bool hasFrameCounter { get { return HasComponent(ServerComponentsLookup.FrameCounter); } }

    public void AddFrameCounter(int newValue) {
        var index = ServerComponentsLookup.FrameCounter;
        var component = (BigBattle.FrameCounterComponent)CreateComponent(index, typeof(BigBattle.FrameCounterComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFrameCounter(int newValue) {
        var index = ServerComponentsLookup.FrameCounter;
        var component = (BigBattle.FrameCounterComponent)CreateComponent(index, typeof(BigBattle.FrameCounterComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFrameCounter() {
        RemoveComponent(ServerComponentsLookup.FrameCounter);
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
public partial class ServerEntity : IFrameCounterEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    static Entitas.IMatcher<ServerEntity> _matcherFrameCounter;

    public static Entitas.IMatcher<ServerEntity> FrameCounter {
        get {
            if (_matcherFrameCounter == null) {
                var matcher = (Entitas.Matcher<ServerEntity>)Entitas.Matcher<ServerEntity>.AllOf(ServerComponentsLookup.FrameCounter);
                matcher.componentNames = ServerComponentsLookup.componentNames;
                _matcherFrameCounter = matcher;
            }

            return _matcherFrameCounter;
        }
    }
}
