//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity timeEntity { get { return GetGroup(InputMatcher.Time).GetSingleEntity(); } }
    public Entitas.Data.TimeComponent time { get { return timeEntity.time; } }
    public bool hasTime { get { return timeEntity != null; } }

    public InputEntity SetTime(float newValue) {
        if (hasTime) {
            throw new Entitas.EntitasException("Could not set Time!\n" + this + " already has an entity with Entitas.Data.TimeComponent!",
                "You should check if the context already has a timeEntity before setting it or use context.ReplaceTime().");
        }
        var entity = CreateEntity();
        entity.AddTime(newValue);
        return entity;
    }

    public void ReplaceTime(float newValue) {
        var entity = timeEntity;
        if (entity == null) {
            entity = SetTime(newValue);
        } else {
            entity.ReplaceTime(newValue);
        }
    }

    public void RemoveTime() {
        timeEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity realTimeSinceStartupEntity { get { return GetGroup(InputMatcher.RealTimeSinceStartup).GetSingleEntity(); } }
    public Entitas.Data.RealTimeSinceStartupComponent realTimeSinceStartup { get { return realTimeSinceStartupEntity.realTimeSinceStartup; } }
    public bool hasRealTimeSinceStartup { get { return realTimeSinceStartupEntity != null; } }

    public InputEntity SetRealTimeSinceStartup(float newValue) {
        if (hasRealTimeSinceStartup) {
            throw new Entitas.EntitasException("Could not set RealTimeSinceStartup!\n" + this + " already has an entity with Entitas.Data.RealTimeSinceStartupComponent!",
                "You should check if the context already has a realTimeSinceStartupEntity before setting it or use context.ReplaceRealTimeSinceStartup().");
        }
        var entity = CreateEntity();
        entity.AddRealTimeSinceStartup(newValue);
        return entity;
    }

    public void ReplaceRealTimeSinceStartup(float newValue) {
        var entity = realTimeSinceStartupEntity;
        if (entity == null) {
            entity = SetRealTimeSinceStartup(newValue);
        } else {
            entity.ReplaceRealTimeSinceStartup(newValue);
        }
    }

    public void RemoveRealTimeSinceStartup() {
        realTimeSinceStartupEntity.Destroy();
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
public partial class InputEntity {

    public Entitas.Data.TimeComponent time { get { return (Entitas.Data.TimeComponent)GetComponent(InputComponentsLookup.Time); } }
    public bool hasTime { get { return HasComponent(InputComponentsLookup.Time); } }

    public void AddTime(float newValue) {
        var index = InputComponentsLookup.Time;
        var component = CreateComponent<Entitas.Data.TimeComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTime(float newValue) {
        var index = InputComponentsLookup.Time;
        var component = CreateComponent<Entitas.Data.TimeComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTime() {
        RemoveComponent(InputComponentsLookup.Time);
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
public partial class InputEntity {

    public Entitas.Data.RealTimeSinceStartupComponent realTimeSinceStartup { get { return (Entitas.Data.RealTimeSinceStartupComponent)GetComponent(InputComponentsLookup.RealTimeSinceStartup); } }
    public bool hasRealTimeSinceStartup { get { return HasComponent(InputComponentsLookup.RealTimeSinceStartup); } }

    public void AddRealTimeSinceStartup(float newValue) {
        var index = InputComponentsLookup.RealTimeSinceStartup;
        var component = CreateComponent<Entitas.Data.RealTimeSinceStartupComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRealTimeSinceStartup(float newValue) {
        var index = InputComponentsLookup.RealTimeSinceStartup;
        var component = CreateComponent<Entitas.Data.RealTimeSinceStartupComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRealTimeSinceStartup() {
        RemoveComponent(InputComponentsLookup.RealTimeSinceStartup);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherTime;

    public static Entitas.IMatcher<InputEntity> Time {
        get {
            if (_matcherTime == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Time);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherTime = matcher;
            }

            return _matcherTime;
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherRealTimeSinceStartup;

    public static Entitas.IMatcher<InputEntity> RealTimeSinceStartup {
        get {
            if (_matcherRealTimeSinceStartup == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.RealTimeSinceStartup);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherRealTimeSinceStartup = matcher;
            }

            return _matcherRealTimeSinceStartup;
        }
    }
}
