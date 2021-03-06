//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ClientContext {

    public ClientEntity randomEntity { get { return GetGroup(ClientMatcher.Random).GetSingleEntity(); } }
    public BigBattle.RandomComponent random { get { return randomEntity.random; } }
    public bool hasRandom { get { return randomEntity != null; } }

    public ClientEntity SetRandom(BigBattle.Random newValue) {
        if (hasRandom) {
            throw new Entitas.EntitasException("Could not set Random!\n" + this + " already has an entity with BigBattle.RandomComponent!",
                "You should check if the context already has a randomEntity before setting it or use context.ReplaceRandom().");
        }
        var entity = CreateEntity();
        entity.AddRandom(newValue);
        return entity;
    }

    public void ReplaceRandom(BigBattle.Random newValue) {
        var entity = randomEntity;
        if (entity == null) {
            entity = SetRandom(newValue);
        } else {
            entity.ReplaceRandom(newValue);
        }
    }

    public void RemoveRandom() {
        randomEntity.Destroy();
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
public partial class ClientEntity {

    public BigBattle.RandomComponent random { get { return (BigBattle.RandomComponent)GetComponent(ClientComponentsLookup.Random); } }
    public bool hasRandom { get { return HasComponent(ClientComponentsLookup.Random); } }

    public void AddRandom(BigBattle.Random newValue) {
        var index = ClientComponentsLookup.Random;
        var component = (BigBattle.RandomComponent)CreateComponent(index, typeof(BigBattle.RandomComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRandom(BigBattle.Random newValue) {
        var index = ClientComponentsLookup.Random;
        var component = (BigBattle.RandomComponent)CreateComponent(index, typeof(BigBattle.RandomComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRandom() {
        RemoveComponent(ClientComponentsLookup.Random);
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
public partial class ClientEntity : IRandomEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ClientMatcher {

    static Entitas.IMatcher<ClientEntity> _matcherRandom;

    public static Entitas.IMatcher<ClientEntity> Random {
        get {
            if (_matcherRandom == null) {
                var matcher = (Entitas.Matcher<ClientEntity>)Entitas.Matcher<ClientEntity>.AllOf(ClientComponentsLookup.Random);
                matcher.componentNames = ClientComponentsLookup.componentNames;
                _matcherRandom = matcher;
            }

            return _matcherRandom;
        }
    }
}
