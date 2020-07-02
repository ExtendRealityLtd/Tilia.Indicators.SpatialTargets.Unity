# Class SpatialTargetConfigurator

Sets up the SpatialTarget Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActiveStateContainer]
  * [CollisionLogicContainer]
  * [DisabledStateContainer]
  * [DisabledTag]
  * [EnabledStateContainer]
  * [Facade]
  * [HideSourceCursorLogicContainer]
  * [LockSourceToOriginLogicContainer]
  * [TargetController]
* [Methods]
  * [ConfigureActivationActions()]
  * [ConfigureEnabledState()]
  * [ConfigureHoverActions()]
  * [ConfigureOverriedPoints()]
  * [ConfigureSourceValidity()]
  * [InvokeActivated(SurfaceData)]
  * [InvokeDeactivated()]
  * [InvokeEntered(SurfaceData)]
  * [InvokeExited(SurfaceData)]
  * [InvokeFirstEntered(SurfaceData)]
  * [InvokeLastExited(SurfaceData)]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* SpatialTargetConfigurator

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
public class SpatialTargetConfigurator : MonoBehaviour
```

### Properties

#### ActiveStateContainer

The GameObject container for the active visual states.

##### Declaration

```
public GameObject ActiveStateContainer { get; protected set; }
```

#### CollisionLogicContainer

The GameObject container for the collision volume management.

##### Declaration

```
public GameObject CollisionLogicContainer { get; protected set; }
```

#### DisabledStateContainer

The GameObject container for the disabled visual states.

##### Declaration

```
public GameObject DisabledStateContainer { get; protected set; }
```

#### DisabledTag

The tag that denotes if the collision volume should be in the disabled mode.

##### Declaration

```
public SpatialTargetDisabledTag DisabledTag { get; protected set; }
```

#### EnabledStateContainer

The GameObject container for the enabled visual states.

##### Declaration

```
public GameObject EnabledStateContainer { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public SpatialTargetFacade Facade { get; protected set; }
```

#### HideSourceCursorLogicContainer

The GameObject container for the hiding the source cursor.

##### Declaration

```
public GameObject HideSourceCursorLogicContainer { get; protected set; }
```

#### LockSourceToOriginLogicContainer

The GameObject container for the source locking to origin management.

##### Declaration

```
public GameObject LockSourceToOriginLogicContainer { get; protected set; }
```

#### TargetController

The [SpatialTarget] controller for this configuration.

##### Declaration

```
public SpatialTarget TargetController { get; protected set; }
```

### Methods

#### ConfigureActivationActions()

Configures the select actions.

##### Declaration

```
public virtual void ConfigureActivationActions()
```

#### ConfigureEnabledState()

Configures the enabled state.

##### Declaration

```
public virtual void ConfigureEnabledState()
```

#### ConfigureHoverActions()

Configures the hover actions.

##### Declaration

```
public virtual void ConfigureHoverActions()
```

#### ConfigureOverriedPoints()

Configures the enabled states of the override points.

##### Declaration

```
public virtual void ConfigureOverriedPoints()
```

#### ConfigureSourceValidity()

Configures the source validity.

##### Declaration

```
public virtual void ConfigureSourceValidity()
```

#### InvokeActivated(SurfaceData)

Invokes the Facade.Activated event.

##### Declaration

```
public virtual void InvokeActivated(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to invoke with. |

#### InvokeDeactivated()

Invokes the Facade.Deactivated event.

##### Declaration

```
public virtual void InvokeDeactivated()
```

#### InvokeEntered(SurfaceData)

Invokes the Facade.Entered event.

##### Declaration

```
public virtual void InvokeEntered(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to invoke with. |

#### InvokeExited(SurfaceData)

Invokes the Facade.Exited event.

##### Declaration

```
public virtual void InvokeExited(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to invoke with. |

#### InvokeFirstEntered(SurfaceData)

Invokes the Facade.FirstEntered event.

##### Declaration

```
public virtual void InvokeFirstEntered(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to invoke with. |

#### InvokeLastExited(SurfaceData)

Invokes the Facade.LastExited event.

##### Declaration

```
public virtual void InvokeLastExited(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to invoke with. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Indicators.SpatialTargets]: README.md
[SpatialTargetDisabledTag]: ComponentTags/SpatialTargetDisabledTag.md
[SpatialTargetFacade]: SpatialTargetFacade.md
[SpatialTarget]: SpatialTarget.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActiveStateContainer]: #ActiveStateContainer
[CollisionLogicContainer]: #CollisionLogicContainer
[DisabledStateContainer]: #DisabledStateContainer
[DisabledTag]: #DisabledTag
[EnabledStateContainer]: #EnabledStateContainer
[Facade]: #Facade
[HideSourceCursorLogicContainer]: #HideSourceCursorLogicContainer
[LockSourceToOriginLogicContainer]: #LockSourceToOriginLogicContainer
[TargetController]: #TargetController
[Methods]: #Methods
[ConfigureActivationActions()]: #ConfigureActivationActions
[ConfigureEnabledState()]: #ConfigureEnabledState
[ConfigureHoverActions()]: #ConfigureHoverActions
[ConfigureOverriedPoints()]: #ConfigureOverriedPoints
[ConfigureSourceValidity()]: #ConfigureSourceValidity
[InvokeActivated(SurfaceData)]: #InvokeActivatedSurfaceData
[InvokeDeactivated()]: #InvokeDeactivated
[InvokeEntered(SurfaceData)]: #InvokeEnteredSurfaceData
[InvokeExited(SurfaceData)]: #InvokeExitedSurfaceData
[InvokeFirstEntered(SurfaceData)]: #InvokeFirstEnteredSurfaceData
[InvokeLastExited(SurfaceData)]: #InvokeLastExitedSurfaceData
[OnEnable()]: #OnEnable
