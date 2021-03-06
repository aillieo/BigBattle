//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ClientPositionEventSystem : Entitas.ReactiveSystem<ClientEntity> {

    readonly System.Collections.Generic.List<IClientPositionListener> _listenerBuffer;

    public ClientPositionEventSystem(Contexts contexts) : base(contexts.client) {
        _listenerBuffer = new System.Collections.Generic.List<IClientPositionListener>();
    }

    protected override Entitas.ICollector<ClientEntity> GetTrigger(Entitas.IContext<ClientEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(ClientMatcher.Position)
        );
    }

    protected override bool Filter(ClientEntity entity) {
        return entity.hasPosition && entity.hasClientPositionListener;
    }

    protected override void Execute(System.Collections.Generic.List<ClientEntity> entities) {
        foreach (var e in entities) {
            var component = e.position;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.clientPositionListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnPosition(e, component.value);
            }
        }
    }
}
