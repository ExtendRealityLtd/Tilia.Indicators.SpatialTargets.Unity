## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]

## Details

# Enum SpatialTargetFacade.ActivationActions

Actions that can be performed when activating.

##### Namespace

* [Tilia.Indicators.SpatialTargets]

##### Syntax

```
[Flags]
public enum ActivationActions
```

### Fields

| Name | Description |
| --- | --- |
| ClearHoveringState | Clears any existing hover state on this target. |
| DeselectOtherTargets | De-selects any other activated targets associated with the calling dispatcher. |
| DeselectSelf | De-selects this target upon activating this target. |
| DisableCollisionsOnActivate | Prevents the pointer from continuing to collide with the target when it is activated. |
| HideActiveState | Hides the target active visual state. |

[Tilia.Indicators.SpatialTargets]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
