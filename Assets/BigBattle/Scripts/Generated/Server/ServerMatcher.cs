//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServerMatcher {

    public static Entitas.IAllOfMatcher<ServerEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<ServerEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<ServerEntity> AllOf(params Entitas.IMatcher<ServerEntity>[] matchers) {
          return Entitas.Matcher<ServerEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<ServerEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<ServerEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<ServerEntity> AnyOf(params Entitas.IMatcher<ServerEntity>[] matchers) {
          return Entitas.Matcher<ServerEntity>.AnyOf(matchers);
    }
}
