# Class SpatialTarget

A target in a spatial location that can react to given SurfaceData.

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
  * [hoverHit]
  * [LastExited]
  * [selectedPayload]
* [Properties]
  * [ActivatingDispatcher]
  * [ApplySelectedTargetProperties]
  * [DeactivateOtherSpatialTargetsOnActivated]
  * [DeactivateSelfOnActivated]
  * [ExitAllHoveringOnActivated]
  * [HoveringElements]
  * [IsActivated]
  * [IsHovered]
  * [IsSelectable]
  * [SelectedTargetOverride]
  * [SourcePointOverride]
  * [SourceValidity]
  * [TargetContainer]
* [Methods]
  * [CreateHoverPayload(SurfaceData)]
  * [CreateSelectedPayload(SurfaceData)]
  * [Deselect(Boolean)]
  * [DoDeselect(Boolean)]
  * [DoEnter(SurfaceData)]
  * [DoExit(SurfaceData)]
  * [DoSelect(SurfaceData)]
  * [DoSelect(SpatialTargetDispatcher, SurfaceData)]
  * [Enter(SurfaceData)]
  * [Exit(SurfaceData)]
  * [IsValidData(SurfaceData, Boolean)]
  * [Select(SurfaceData)]
  * [Select(SpatialTargetDispatcher, SurfaceData)]

## Details

##### Inheritance

* System.Object
* SpatialTarget

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
public class SpatialTarget : MonoBehaviour
```

### Fields

#### Activated

Emitted when this [SpatialTarget] is activated.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Activated
```

#### Deactivated

Emitted when this [SpatialTarget] is deactivated.

##### Declaration

```
public UnityEvent Deactivated
```

#### Entered

Emitted when this [SpatialTarget] is entered.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Entered
```

#### Exited

Emitted when this [SpatialTarget] is exited.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent Exited
```

#### FirstEntered

Emitted when this [SpatialTarget] is entered for the first time.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent FirstEntered
```

#### hoverHit

A container to store and mutate RaycastHit data from the hovering SurfaceData.

##### Declaration

```
protected RaycastHit hoverHit
```

#### LastExited

Emitted when this [SpatialTarget] is exited for the last time.

##### Declaration

```
public SpatialTarget.SurfaceDataUnityEvent LastExited
```

#### selectedPayload

A container to store and mutate the given SurfaceData on selection.

##### Declaration

```
protected SurfaceData selectedPayload
```

### Properties

#### ActivatingDispatcher

The [SpatialTargetDispatcher] that has activated this [SpatialTarget].

##### Declaration

```
public SpatialTargetDispatcher ActivatingDispatcher { get; protected set; }
```

#### ApplySelectedTargetProperties

The Transform properties to apply the selected target overrides on.

##### Declaration

```
public TransformProperties ApplySelectedTargetProperties { get; set; }
```

#### DeactivateOtherSpatialTargetsOnActivated

Deactivates any other [SpatialTarget] connected to the same [SpatialTargetDispatcher] when this [SpatialTarget] is activated.

##### Declaration

```
public bool DeactivateOtherSpatialTargetsOnActivated { get; set; }
```

#### DeactivateSelfOnActivated

Deactivates this [SpatialTarget] when this [SpatialTarget] is activated.

##### Declaration

```
public bool DeactivateSelfOnActivated { get; set; }
```

#### ExitAllHoveringOnActivated

Exits all [HoveringElements] when [Select(SurfaceData)] is executed successfully.

##### Declaration

```
public bool ExitAllHoveringOnActivated { get; set; }
```

#### HoveringElements

A collection of SurfaceData elements that are currently hovering over this [SpatialTarget].

##### Declaration

```
public List<SurfaceData> HoveringElements { get; protected set; }
```

#### IsActivated

Whether this [SpatialTarget] is currently activated.

##### Declaration

```
public bool IsActivated { get; protected set; }
```

#### IsHovered

Whether this [SpatialTarget] is currently being hovered over.

##### Declaration

```
public bool IsHovered { get; protected set; }
```

#### IsSelectable

Whether this [SpatialTarget] is selectable.

##### Declaration

```
public bool IsSelectable { get; set; }
```

#### SelectedTargetOverride

Overrides the selected target.

##### Declaration

```
public GameObject SelectedTargetOverride { get; set; }
```

#### SourcePointOverride

Overrides the point at which SurfaceData source originally collided with this [SpatialTarget].

##### Declaration

```
public GameObject SourcePointOverride { get; set; }
```

#### SourceValidity

Determine which SurfaceData sources can interact with this [SpatialTarget].

##### Declaration

```
public RuleContainer SourceValidity { get; set; }
```

#### TargetContainer

Specifies a GameObject that contains this [SpatialTarget].

##### Declaration

```
public GameObject TargetContainer { get; set; }
```

### Methods

#### CreateHoverPayload(SurfaceData)

Creates the payload to emit on the hovering events of [FirstEntered], [Entered], [Exited] and [LastExited].

##### Declaration

```
protected virtual SurfaceData CreateHoverPayload(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that is mutating the hover state. |

##### Returns

| Type | Description |
| --- | --- |
| SurfaceData | The mutated data to emit. |

#### CreateSelectedPayload(SurfaceData)

Creates the payload to emit on the [Activated] event.

##### Declaration

```
protected virtual SurfaceData CreateSelectedPayload(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The default data to potentially mutate. |

##### Returns

| Type | Description |
| --- | --- |
| SurfaceData | The mutated data to emit. |

#### Deselect(Boolean)

Deselects this [SpatialTarget] if it is in a selected state.

##### Declaration

```
public virtual bool Deselect(bool keepInActivatingDispatcher = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | keepInActivatingDispatcher | Whether to keep this in the ActivatingDispatcher.SelectedTargets collection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the deselect was successful. |

#### DoDeselect(Boolean)

Deselects this [SpatialTarget] if it is in a selected state.

##### Declaration

```
public virtual void DoDeselect(bool keepInActivatingDispatcher = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | keepInActivatingDispatcher | Whether to keep this in the ActivatingDispatcher.SelectedTargets collection. |

#### DoEnter(SurfaceData)

Reacts to SurfaceData entering the target spatial location.

##### Declaration

```
public virtual void DoEnter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The entering data. |

#### DoExit(SurfaceData)

Reacts to SurfaceData exiting from the target spatial location.

##### Declaration

```
public virtual void DoExit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The exiting data. |

#### DoSelect(SurfaceData)

Reacts to SurfaceData selecting on target spatial location.

##### Declaration

```
public virtual void DoSelect(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The selecting data. |

#### DoSelect(SpatialTargetDispatcher, SurfaceData)

Reacts to SurfaceData selecting on target spatial location.

##### Declaration

```
public virtual void DoSelect(SpatialTargetDispatcher dispatcher, SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpatialTargetDispatcher] | dispatcher | The dispatcher calling the method. |
| SurfaceData | data | The selecting data. |

#### Enter(SurfaceData)

Reacts to SurfaceData entering the target spatial location.

##### Declaration

```
public virtual bool Enter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The entering data. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the enter was successful. |

#### Exit(SurfaceData)

Reacts to SurfaceData exiting from the target spatial location.

##### Declaration

```
public virtual bool Exit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The exiting data. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the exit was successful. |

#### IsValidData(SurfaceData, Boolean)

Whether the given data is valid.

##### Declaration

```
protected virtual bool IsValidData(SurfaceData data, bool checkIfHovered = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to check. |
| System.Boolean | checkIfHovered | Whether to check if the hover state is active. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the data is valid. |

#### Select(SurfaceData)

Reacts to SurfaceData selecting on target spatial location.

##### Declaration

```
public virtual bool Select(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The selecting data. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the select was successful. |

#### Select(SpatialTargetDispatcher, SurfaceData)

Reacts to SurfaceData selecting on target spatial location.

##### Declaration

```
public virtual bool Select(SpatialTargetDispatcher dispatcher, SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpatialTargetDispatcher] | dispatcher | The dispatcher calling the method. |
| SurfaceData | data | The selecting data. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the select was successful. |

[Tilia.Indicators.SpatialTargets]: README.md
[SpatialTarget.SurfaceDataUnityEvent]: SpatialTarget.SurfaceDataUnityEvent.md
[HoveringElements]: SpatialTarget.md#HoveringElements
[Select(SurfaceData)]: SpatialTarget.md#Select_SurfaceData_
[FirstEntered]: SpatialTarget.md#FirstEntered
[Entered]: SpatialTarget.md#Entered
[Exited]: SpatialTarget.md#Exited
[LastExited]: SpatialTarget.md#LastExited
[Activated]: SpatialTarget.md#Activated
[SpatialTarget]: SpatialTarget.md
[SpatialTargetDispatcher]: SpatialTargetDispatcher.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Activated]: #Activated
[Deactivated]: #Deactivated
[Entered]: #Entered
[Exited]: #Exited
[FirstEntered]: #FirstEntered
[hoverHit]: #hoverHit
[LastExited]: #LastExited
[selectedPayload]: #selectedPayload
[Properties]: #Properties
[ActivatingDispatcher]: #ActivatingDispatcher
[ApplySelectedTargetProperties]: #ApplySelectedTargetProperties
[DeactivateOtherSpatialTargetsOnActivated]: #DeactivateOtherSpatialTargetsOnActivated
[DeactivateSelfOnActivated]: #DeactivateSelfOnActivated
[ExitAllHoveringOnActivated]: #ExitAllHoveringOnActivated
[HoveringElements]: #HoveringElements
[IsActivated]: #IsActivated
[IsHovered]: #IsHovered
[IsSelectable]: #IsSelectable
[SelectedTargetOverride]: #SelectedTargetOverride
[SourcePointOverride]: #SourcePointOverride
[SourceValidity]: #SourceValidity
[TargetContainer]: #TargetContainer
[Methods]: #Methods
[CreateHoverPayload(SurfaceData)]: #CreateHoverPayloadSurfaceData
[CreateSelectedPayload(SurfaceData)]: #CreateSelectedPayloadSurfaceData
[Deselect(Boolean)]: #DeselectBoolean
[DoDeselect(Boolean)]: #DoDeselectBoolean
[DoEnter(SurfaceData)]: #DoEnterSurfaceData
[DoExit(SurfaceData)]: #DoExitSurfaceData
[DoSelect(SurfaceData)]: #DoSelectSurfaceData
[DoSelect(SpatialTargetDispatcher, SurfaceData)]: #DoSelectSpatialTargetDispatcher-SurfaceData
[Enter(SurfaceData)]: #EnterSurfaceData
[Exit(SurfaceData)]: #ExitSurfaceData
[IsValidData(SurfaceData, Boolean)]: #IsValidDataSurfaceData-Boolean
[Select(SurfaceData)]: #SelectSurfaceData
[Select(SpatialTargetDispatcher, SurfaceData)]: #SelectSpatialTargetDispatcher-SurfaceData