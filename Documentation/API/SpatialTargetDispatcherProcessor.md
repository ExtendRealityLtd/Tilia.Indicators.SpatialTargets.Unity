# Class SpatialTargetDispatcherProcessor

A [SpatialTargetDispatcher] collection that can be used to process multiple dispatchers from a single entry point.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActiveDispatcherProcess]
  * [CeaseAfterFirstSourceProcessed]
  * [DispatcherTargets]
* [Methods]
  * [CallDispatchMethod(Dispatcher, SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)]
  * [Enter(SurfaceData)]
  * [Exit(SurfaceData)]
  * [IterateDispatchers(SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)]
  * [Select(SurfaceData)]

## Details

##### Inheritance

* System.Object
* [Dispatcher]
* SpatialTargetDispatcherProcessor

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
public class SpatialTargetDispatcherProcessor : Dispatcher
```

### Properties

#### ActiveDispatcherProcess

The current active [Dispatcher] being utilized.

##### Declaration

```
public virtual Dispatcher ActiveDispatcherProcess { get; protected set; }
```

#### CeaseAfterFirstSourceProcessed

Whether to cease the processing of the collection after the first valid [Dispatcher] is processed.

##### Declaration

```
public bool CeaseAfterFirstSourceProcessed { get; set; }
```

#### DispatcherTargets

The [Dispatcher] collection to attempt to process.

##### Declaration

```
public DispatcherObservableList DispatcherTargets { get; set; }
```

### Methods

#### CallDispatchMethod(Dispatcher, SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)

Calls the appropriate dispatcher method.

##### Declaration

```
protected virtual bool CallDispatchMethod(Dispatcher process, SurfaceData data, SpatialTargetDispatcherProcessor.DispatchMethod method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Dispatcher] | process | The dispatcher to process the call on. |
| SurfaceData | data | The data to process. |
| [SpatialTargetDispatcherProcessor.DispatchMethod] | method | The method to call. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

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

#### IterateDispatchers(SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)

Iterates through the [Dispatcher] collection and calls the given method for each dispatcher process found.

##### Declaration

```
protected virtual bool IterateDispatchers(SurfaceData data, SpatialTargetDispatcherProcessor.DispatchMethod method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to process. |
| [SpatialTargetDispatcherProcessor.DispatchMethod] | method | The method to call. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

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

[SpatialTargetDispatcher]: SpatialTargetDispatcher.md
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
[DispatcherObservableList]: Collection/DispatcherObservableList.md
[Dispatcher.Enter(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Enter_SurfaceData_
[Dispatcher.Exit(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Exit_SurfaceData_
[Dispatcher]: Dispatcher.md
[SpatialTargetDispatcherProcessor.DispatchMethod]: SpatialTargetDispatcherProcessor.DispatchMethod.md
[SpatialTarget]: SpatialTarget.md
[Dispatcher.Select(SurfaceData)]: Dispatcher.md#Tilia_Indicators_SpatialTargets_Dispatcher_Select_SurfaceData_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActiveDispatcherProcess]: #ActiveDispatcherProcess
[CeaseAfterFirstSourceProcessed]: #CeaseAfterFirstSourceProcessed
[DispatcherTargets]: #DispatcherTargets
[Methods]: #Methods
[CallDispatchMethod(Dispatcher, SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)]: #CallDispatchMethodDispatcher-SurfaceData-SpatialTargetDispatcherProcessor.DispatchMethod
[Enter(SurfaceData)]: #EnterSurfaceData
[Exit(SurfaceData)]: #ExitSurfaceData
[IterateDispatchers(SurfaceData, SpatialTargetDispatcherProcessor.DispatchMethod)]: #IterateDispatchersSurfaceData-SpatialTargetDispatcherProcessor.DispatchMethod
[Select(SurfaceData)]: #SelectSurfaceData
