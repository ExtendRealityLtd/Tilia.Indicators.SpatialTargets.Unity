# Class SpatialTargetFacade

The public interface into the SpatialTarget Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Activated]
  * [Deactivated]
  * [Entered]
  * [Exited]
  * [FirstEntered]
  * [LastExited]
* [Properties]
  * [ActionsOnActivate]
  * [ActionsOnHover]
  * [Configuration]
  * [IsEnabled]
  * [SourceValidity]
  * [UseSourcePointOverride]
  * [UseTargetOverride]
* [Methods]
  * [OnAfterActionOnHoverChange()]
  * [OnAfterActionOnSelectChange()]
  * [OnAfterIsEnabledChange()]
  * [OnAfterSourceValidityChange()]
  * [OnAfterUseSourcePointOverrideChange()]
  * [OnAfterUseTargetOverrideChange()]

## Details

##### Inheritance

* System.Object
* SpatialTargetFacade

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
public class SpatialTargetFacade : MonoBehaviour
```

### Fields

#### Activated

Emitted when the target is activated.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Activated
```

#### Deactivated

Emitted when the target is deactivated.

##### Declaration

```
public UnityEvent Deactivated
```

#### Entered

Emitted when the target is entered.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Entered
```

#### Exited

Emitted when the target is exited.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Exited
```

#### FirstEntered

Emitted when the target is entered for the first time.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent FirstEntered
```

#### LastExited

Emitted when the target is exited for the last time.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent LastExited
```

### Properties

#### ActionsOnActivate

Actions to perform when the [SpatialTargetFacade] is activated.

##### Declaration

```
public SpatialTargetFacade.ActivationActions ActionsOnActivate { get; set; }
```

#### ActionsOnHover

Actions to perform when the [SpatialTargetFacade] is hovered over.

##### Declaration

```
public SpatialTargetFacade.HoverActions ActionsOnHover { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public SpatialTargetConfigurator Configuration { get; protected set; }
```

#### IsEnabled

Whether the [SpatialTargetFacade] is in the enabled state.

##### Declaration

```
public bool IsEnabled { get; set; }
```

#### SourceValidity

Determine which SurfaceData sources can interact with this [SpatialTargetFacade].

##### Declaration

```
public RuleContainer SourceValidity { get; set; }
```

#### UseSourcePointOverride

Whether to use the source point override GameObject to lock the pointer cursor to.

##### Declaration

```
public bool UseSourcePointOverride { get; set; }
```

#### UseTargetOverride

Whether to use the target override GameObject to use as the TransformData.Transform in the event payloads.

##### Declaration

```
public bool UseTargetOverride { get; set; }
```

### Methods

#### OnAfterActionOnHoverChange()

Called after [ActionsOnHover] has been changed.

##### Declaration

```
protected virtual void OnAfterActionOnHoverChange()
```

#### OnAfterActionOnSelectChange()

Called after [ActionsOnActivate] has been changed.

##### Declaration

```
protected virtual void OnAfterActionOnSelectChange()
```

#### OnAfterIsEnabledChange()

Called after [IsEnabled] has been changed.

##### Declaration

```
protected virtual void OnAfterIsEnabledChange()
```

#### OnAfterSourceValidityChange()

Called after [SourceValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceValidityChange()
```

#### OnAfterUseSourcePointOverrideChange()

Called after [UseSourcePointOverride] has been changed.

##### Declaration

```
protected virtual void OnAfterUseSourcePointOverrideChange()
```

#### OnAfterUseTargetOverrideChange()

Called after [UseTargetOverride] has been changed.

##### Declaration

```
protected virtual void OnAfterUseTargetOverrideChange()
```

[Tilia.Indicators.SpatialTargets]: README.md
[SpatialTarget.SurfaceDataUnityEvent]: SpatialTarget.SurfaceDataUnityEvent.md
[SpatialTargetFacade.ActivationActions]: SpatialTargetFacade.ActivationActions.md
[SpatialTargetFacade.HoverActions]: SpatialTargetFacade.HoverActions.md
[SpatialTargetConfigurator]: SpatialTargetConfigurator.md
[SpatialTargetFacade]: SpatialTargetFacade.md
[ActionsOnHover]: SpatialTargetFacade.md#ActionsOnHover
[ActionsOnActivate]: SpatialTargetFacade.md#ActionsOnActivate
[IsEnabled]: SpatialTargetFacade.md#IsEnabled
[SourceValidity]: SpatialTargetFacade.md#SourceValidity
[UseSourcePointOverride]: SpatialTargetFacade.md#UseSourcePointOverride
[UseTargetOverride]: SpatialTargetFacade.md#UseTargetOverride
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Activated]: #Activated
[Deactivated]: #Deactivated
[Entered]: #Entered
[Exited]: #Exited
[FirstEntered]: #FirstEntered
[LastExited]: #LastExited
[Properties]: #Properties
[ActionsOnActivate]: #ActionsOnActivate
[ActionsOnHover]: #ActionsOnHover
[Configuration]: #Configuration
[IsEnabled]: #IsEnabled
[SourceValidity]: #SourceValidity
[UseSourcePointOverride]: #UseSourcePointOverride
[UseTargetOverride]: #UseTargetOverride
[Methods]: #Methods
[OnAfterActionOnHoverChange()]: #OnAfterActionOnHoverChange
[OnAfterActionOnSelectChange()]: #OnAfterActionOnSelectChange
[OnAfterIsEnabledChange()]: #OnAfterIsEnabledChange
[OnAfterSourceValidityChange()]: #OnAfterSourceValidityChange
[OnAfterUseSourcePointOverrideChange()]: #OnAfterUseSourcePointOverrideChange
[OnAfterUseTargetOverrideChange()]: #OnAfterUseTargetOverrideChange
