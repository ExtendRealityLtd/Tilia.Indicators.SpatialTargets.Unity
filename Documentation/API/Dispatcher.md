# Class Dispatcher

The basis for all dispatcher types for the spatial targets.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [SourceValidity]
* [Methods]
  * [ClearSourceValidity()]
  * [DispatchEnter(SurfaceData)]
  * [DispatchExit(SurfaceData)]
  * [DispatchSelect(SurfaceData)]
  * [DoDispatchEnter(SurfaceData)]
  * [DoDispatchExit(SurfaceData)]
  * [DoDispatchSelect(SurfaceData)]
  * [Enter(SurfaceData)]
  * [Exit(SurfaceData)]
  * [IsValidData(SurfaceData)]
  * [Select(SurfaceData)]

## Details

##### Inheritance

* System.Object
* Dispatcher
* [SpatialTargetDispatcher]
* [SpatialTargetDispatcherProcessor]

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
public abstract class Dispatcher : MonoBehaviour
```

### Properties

#### SourceValidity

Determine which SurfaceData sources can interact with this [Dispatcher].

##### Declaration

```
public RuleContainer SourceValidity { get; set; }
```

### Methods

#### ClearSourceValidity()

Clears [SourceValidity].

##### Declaration

```
public virtual void ClearSourceValidity()
```

#### DispatchEnter(SurfaceData)

Dispatches the Enter command for the given data.

##### Declaration

```
public virtual bool DispatchEnter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been entered. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the dispatch was successful. |

#### DispatchExit(SurfaceData)

Dispatches the Exit command for the given data.

##### Declaration

```
public virtual bool DispatchExit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been exited. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the dispatch was successful. |

#### DispatchSelect(SurfaceData)

Dispatches the Select command for the given data.

##### Declaration

```
public virtual bool DispatchSelect(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been selected. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the dispatch was successful. |

#### DoDispatchEnter(SurfaceData)

Dispatches the Enter command for the given data.

##### Declaration

```
public virtual void DoDispatchEnter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been entered. |

#### DoDispatchExit(SurfaceData)

Dispatches the Exit command for the given data.

##### Declaration

```
public virtual void DoDispatchExit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been exited. |

#### DoDispatchSelect(SurfaceData)

Dispatches the Select command for the given data.

##### Declaration

```
public virtual void DoDispatchSelect(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been selected. |

#### Enter(SurfaceData)

Processes the given data as an Enter command on a [SpatialTarget].

##### Declaration

```
protected abstract bool Enter(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been entered. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

#### Exit(SurfaceData)

Processes the given data as an Exit command on a [SpatialTarget].

##### Declaration

```
protected abstract bool Exit(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been exited. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

#### IsValidData(SurfaceData)

Whether the given data is valid.

##### Declaration

```
protected virtual bool IsValidData(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data to check. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the data is valid. |

#### Select(SurfaceData)

Processes the given data as an Select command on a [SpatialTarget].

##### Declaration

```
protected abstract bool Select(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The data that has been selected. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the process was successful. |

[SpatialTargetDispatcher]: SpatialTargetDispatcher.md
[SpatialTargetDispatcherProcessor]: SpatialTargetDispatcherProcessor.md
[Tilia.Indicators.SpatialTargets]: README.md
[Dispatcher]: Dispatcher.md
[SourceValidity]: Dispatcher.md#SourceValidity
[SpatialTarget]: SpatialTarget.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[SourceValidity]: #SourceValidity
[Methods]: #Methods
[ClearSourceValidity()]: #ClearSourceValidity
[DispatchEnter(SurfaceData)]: #DispatchEnterSurfaceData
[DispatchExit(SurfaceData)]: #DispatchExitSurfaceData
[DispatchSelect(SurfaceData)]: #DispatchSelectSurfaceData
[DoDispatchEnter(SurfaceData)]: #DoDispatchEnterSurfaceData
[DoDispatchExit(SurfaceData)]: #DoDispatchExitSurfaceData
[DoDispatchSelect(SurfaceData)]: #DoDispatchSelectSurfaceData
[Enter(SurfaceData)]: #EnterSurfaceData
[Exit(SurfaceData)]: #ExitSurfaceData
[IsValidData(SurfaceData)]: #IsValidDataSurfaceData
[Select(SurfaceData)]: #SelectSurfaceData
