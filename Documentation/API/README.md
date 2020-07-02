# Namespace Tilia.Indicators.SpatialTargets

### Classes

#### [Dispatcher]

The basis for all dispatcher types for the spatial targets.

#### [SpatialTarget]

A target in a spatial location that can react to given SurfaceData.

#### [SpatialTarget.SurfaceDataUnityEvent]

Defines the event with the specified SurfaceData.

#### [SpatialTargetConfigurator]

Sets up the SpatialTarget Prefab based on the provided user settings.

#### [SpatialTargetDispatcher]

A Dispatcher that finds the appropriate [SpatialTarget] on the given data and dispatches the relevant call.

#### [SpatialTargetDispatcherProcessor]

A [SpatialTargetDispatcher] collection that can be used to process multiple dispatchers from a single entry point.

#### [SpatialTargetFacade]

The public interface into the SpatialTarget Prefab.

### Enums

#### [SpatialTargetDispatcherProcessor.DispatchMethod]

The dispatch method to call.

#### [SpatialTargetFacade.ActivationActions]

Actions that can be performed when activating.

#### [SpatialTargetFacade.HoverActions]

Actions that can be performed when hovering.

[Dispatcher]: Dispatcher.md
[SpatialTarget.SurfaceDataUnityEvent]: SpatialTarget.SurfaceDataUnityEvent.md
[SpatialTargetConfigurator]: SpatialTargetConfigurator.md
[SpatialTarget]: SpatialTarget.md
[SpatialTargetDispatcherProcessor]: SpatialTargetDispatcherProcessor.md
[SpatialTargetDispatcher]: SpatialTargetDispatcher.md
[SpatialTargetFacade]: SpatialTargetFacade.md
[SpatialTargetDispatcherProcessor.DispatchMethod]: SpatialTargetDispatcherProcessor.DispatchMethod.md
[SpatialTargetFacade.ActivationActions]: SpatialTargetFacade.ActivationActions.md
[SpatialTargetFacade.HoverActions]: SpatialTargetFacade.HoverActions.md
