# Class SpatialTargetDispatcher

A Dispatcher that finds the appropriate [SpatialTarget] on the given data and dispatches the relevant call.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [DelselectAllOnEmptyTarget]
  * [SelectedTargets]
  * [TargetValidity]
* [Methods]
  * [ClearTargetValidity()]
  * [DeselectOtherTargetsOnSelect(SpatialTarget)]
  * [DoRemoveFromSelectedTargets(SpatialTarget)]
  * [Enter(SurfaceData)]
  * [Exit(SurfaceData)]
  * [GetSpatialTarget(SurfaceData)]
  * [RemoveFromSelectedTargets(SpatialTarget)]
  * [Select(SurfaceData)]

## Details

##### Inheritance

* System.Object
* [Dispatcher]
* SpatialTargetDispatcher

##### Inherited Members

[Dispatcher.SourceValidity]

[Dispatcher.ClearSourceValidity()]

[Dispatcher.DispatchEnter(SurfaceData)]

[Dispatcher.DoDispatchEnter(SurfaceData)]

[Dispatcher.DispatchExit(SurfaceData)]

[Dispatcher.DoDispatchExit(SurfaceData)]

[Dispatcher.DispatchSelect(SurfaceData)]

[Dispatcher.DoDispatchSelect(SurfaceData)]

[Dispatcher.IsValidData(SurfaceData)]

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
public class SpatialTargetDispatcher : Dispatcher
```

### Properties

#### DelselectAllOnEmptyTarget

Whether to de-select all selected targets when an empty target is selected.

##### Declaration

```
public bool DelselectAllOnEmptyTarget { get; set; }
```

#### SelectedTargets

A [SpatialTarget] collection of the currently selected targets.

##### Declaration

```
public List<SpatialTarget> SelectedTargets { get; protected set; }
```

#### TargetValidity

Determine if the [SpatialTarget] can be dispatched to.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

### Methods

#### ClearTargetValidity()

Clears [TargetValidity].

##### Declaration

```
public virtual void ClearTargetValidity()
```

#### DeselectOtherTargetsOnSelect(SpatialTarget)

Deselects all other selected targets that are associated with this dispatcher.

##### Declaration

```
protected virtual void DeselectOtherTargetsOnSelect(SpatialTarget target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpatialTarget] | target | The current [SpatialTarget] which will be ignored in the deselect. |

#### DoRemoveFromSelectedTargets(SpatialTarget)

Removes the given target from the [SelectedTargets] collection.

##### Declaration

```
public virtual void DoRemoveFromSelectedTargets(SpatialTarget target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpatialTarget] | target | The target to remove. |

#### Enter(SurfaceData)

Processes the given data as an Enter command on a [SpatialTarget].

##### Declaration

```
protected override bool Enter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been entered. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

##### Overrides

[Dispatcher.Enter(SurfaceData)]

#### Exit(SurfaceData)

Processes the given data as an Exit command on a [SpatialTarget].

##### Declaration

```
protected override bool Exit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been exited. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

##### Overrides

[Dispatcher.Exit(SurfaceData)]

#### GetSpatialTarget(SurfaceData)

Gets the [SpatialTarget] related to the given data.

##### Declaration

```
protected virtual SpatialTarget GetSpatialTarget(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to look on. |

##### Returns

| Type | Description |
| --- | --- |
| [SpatialTarget] | The found [SpatialTarget]. |

#### RemoveFromSelectedTargets(SpatialTarget)

Removes the given target from the [SelectedTargets] collection.

##### Declaration

```
public virtual bool RemoveFromSelectedTargets(SpatialTarget target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpatialTarget] | target | The target to remove. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the remove was successful. |

#### Select(SurfaceData)

Processes the given data as an Select command on a [SpatialTarget].

##### Declaration

```
protected override bool Select(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been selected. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

##### Overrides

[Dispatcher.Select(SurfaceData)]

[Dispatcher]: Dispatcher.md
[Dispatcher.SourceValidity]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_SourceValidity
[Dispatcher.ClearSourceValidity()]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_ClearSourceValidity
[Dispatcher.DispatchEnter(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DispatchEnter_SurfaceData_
[Dispatcher.DoDispatchEnter(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DoDispatchEnter_SurfaceData_
[Dispatcher.DispatchExit(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DispatchExit_SurfaceData_
[Dispatcher.DoDispatchExit(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DoDispatchExit_SurfaceData_
[Dispatcher.DispatchSelect(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DispatchSelect_SurfaceData_
[Dispatcher.DoDispatchSelect(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_DoDispatchSelect_SurfaceData_
[Dispatcher.IsValidData(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_IsValidData_SurfaceData_
[Tilia.Indicators.SpatialTargets]: README.md
[TargetValidity]: SpatialTargetDispatcher.md#TargetValidity
[SelectedTargets]: SpatialTargetDispatcher.md#SelectedTargets
[Dispatcher.Enter(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Enter_SurfaceData_
[Dispatcher.Exit(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Exit_SurfaceData_
[SelectedTargets]: SpatialTargetDispatcher.md#SelectedTargets
[SpatialTarget]: SpatialTarget.md
[Dispatcher.Select(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Select_SurfaceData_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[DelselectAllOnEmptyTarget]: #DelselectAllOnEmptyTarget
[SelectedTargets]: #SelectedTargets
[TargetValidity]: #TargetValidity
[Methods]: #Methods
[ClearTargetValidity()]: #ClearTargetValidity
[DeselectOtherTargetsOnSelect(SpatialTarget)]: #DeselectOtherTargetsOnSelectSpatialTarget
[DoRemoveFromSelectedTargets(SpatialTarget)]: #DoRemoveFromSelectedTargetsSpatialTarget
[Enter(SurfaceData)]: #EnterSurfaceData
[Exit(SurfaceData)]: #ExitSurfaceData
[GetSpatialTarget(SurfaceData)]: #GetSpatialTargetSurfaceData
[RemoveFromSelectedTargets(SpatialTarget)]: #RemoveFromSelectedTargetsSpatialTarget
[Select(SurfaceData)]: #SelectSurfaceData
