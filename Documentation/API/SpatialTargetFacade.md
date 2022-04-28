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
  * [CollidableObjects]
  * [Configuration]
  * [DeselectSelfDelay]
  * [IsEnabled]
  * [SourceValidity]
  * [UseSourcePointOverride]
  * [UseTargetOverride]
* [Methods]
  * [ClearConfiguration()]
  * [ClearSourceValidity()]
  * [Deselect(Boolean)]
  * [OnAfterActionOnHoverChange()]
  * [OnAfterActionOnSelectChange()]
  * [OnAfterActionsOnActivateChange()]
  * [OnAfterActionsOnHoverChange()]
  * [OnAfterDeselectSelfDelayChange()]
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

#### CollidableObjects

A UnityEngine.Object collection of objects that can collide with the spatial target.

##### Declaration

```
public UnityObjectObservableList CollidableObjects { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public SpatialTargetConfigurator Configuration { get; protected set; }
```

#### DeselectSelfDelay

The amount of time to delay de-selecting this Spatial Target after it has been activated if the [ActionsOnActivate] [DeselectSelf] is enabled.

##### Declaration

```
public float DeselectSelfDelay { get; set; }
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

#### ClearConfiguration()

Clears [Configuration].

##### Declaration

```
public virtual void ClearConfiguration()
```

#### ClearSourceValidity()

Clears [SourceValidity].

##### Declaration

```
public virtual void ClearSourceValidity()
```

#### Deselect(Boolean)

De-selects the containing [SpatialTarget] if it is in a selected state.

##### Declaration

```
public virtual void Deselect(bool keepInActivatingDispatcher = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | keepInActivatingDispatcher | Whether to keep this in the ActivatingDispatcher.SelectedTargets collection. |

#### OnAfterActionOnHoverChange()

##### Declaration

```
[Obsolete("Use `OnAfterActionsOnHoverChange` instead.")]
protected virtual void OnAfterActionOnHoverChange()
```

#### OnAfterActionOnSelectChange()

##### Declaration

```
[Obsolete("Use `OnAfterActionsOnActivateChange` instead.")]
protected virtual void OnAfterActionOnSelectChange()
```

#### OnAfterActionsOnActivateChange()

Called after [ActionsOnActivate] has been changed.

##### Declaration

```
protected virtual void OnAfterActionsOnActivateChange()
```

#### OnAfterActionsOnHoverChange()

Called after [ActionsOnHover] has been changed.

##### Declaration

```
protected virtual void OnAfterActionsOnHoverChange()
```

#### OnAfterDeselectSelfDelayChange()

Called after [DeselectSelfDelay] has been changed.

##### Declaration

```
protected virtual void OnAfterDeselectSelfDelayChange()
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
[ActionsOnActivate]: SpatialTargetFacade.md#ActionsOnActivate
[DeselectSelf]: SpatialTargetFacade.ActivationActions.md#ActivationActions_DeselectSelf
[SpatialTargetFacade]: SpatialTargetFacade.md
[Configuration]: SpatialTargetFacade.md#Configuration
[SourceValidity]: SpatialTargetFacade.md#SourceValidity
[SpatialTarget]: SpatialTarget.md
[ActionsOnActivate]: SpatialTargetFacade.md#ActionsOnActivate
[ActionsOnHover]: SpatialTargetFacade.md#ActionsOnHover
[DeselectSelfDelay]: SpatialTargetFacade.md#DeselectSelfDelay
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
[CollidableObjects]: #CollidableObjects
[Configuration]: #Configuration
[DeselectSelfDelay]: #DeselectSelfDelay
[IsEnabled]: #IsEnabled
[SourceValidity]: #SourceValidity
[UseSourcePointOverride]: #UseSourcePointOverride
[UseTargetOverride]: #UseTargetOverride
[Methods]: #Methods
[ClearConfiguration()]: #ClearConfiguration
[ClearSourceValidity()]: #ClearSourceValidity
[Deselect(Boolean)]: #DeselectBoolean
[OnAfterActionOnHoverChange()]: #OnAfterActionOnHoverChange
[OnAfterActionOnSelectChange()]: #OnAfterActionOnSelectChange
[OnAfterActionsOnActivateChange()]: #OnAfterActionsOnActivateChange
[OnAfterActionsOnHoverChange()]: #OnAfterActionsOnHoverChange
[OnAfterDeselectSelfDelayChange()]: #OnAfterDeselectSelfDelayChange
[OnAfterIsEnabledChange()]: #OnAfterIsEnabledChange
[OnAfterSourceValidityChange()]: #OnAfterSourceValidityChange
[OnAfterUseSourcePointOverrideChange()]: #OnAfterUseSourcePointOverrideChange
[OnAfterUseTargetOverrideChange()]: #OnAfterUseTargetOverrideChange
