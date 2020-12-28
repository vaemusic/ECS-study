//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly PhysicsComp physicsCompComponent = new PhysicsComp();

    public bool isPhysicsComp {
        get { return HasComponent(GameComponentsLookup.PhysicsComp); }
        set {
            if (value != isPhysicsComp) {
                var index = GameComponentsLookup.PhysicsComp;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : physicsCompComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPhysicsComp;

    public static Entitas.IMatcher<GameEntity> PhysicsComp {
        get {
            if (_matcherPhysicsComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PhysicsComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPhysicsComp = matcher;
            }

            return _matcherPhysicsComp;
        }
    }
}