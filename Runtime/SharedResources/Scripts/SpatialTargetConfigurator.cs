namespace Tilia.Indicators.SpatialTargets
{
    using Tilia.Indicators.SpatialTargets.ComponentTags;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;

    /// <summary>
    /// Sets up the SpatialTarget Prefab based on the provided user settings.
    /// </summary>
    public class SpatialTargetConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private SpatialTargetFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public SpatialTargetFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The GameObject container for the enabled visual states.")]
        [SerializeField]
        [Restricted]
        private GameObject enabledStateContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the enabled visual states.
        /// </summary>
        public GameObject EnabledStateContainer
        {
            get
            {
                return enabledStateContainer;
            }
            protected set
            {
                enabledStateContainer = value;
            }
        }
        [Tooltip("The GameObject container for the disabled visual states.")]
        [SerializeField]
        [Restricted]
        private GameObject disabledStateContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the disabled visual states.
        /// </summary>
        public GameObject DisabledStateContainer
        {
            get
            {
                return disabledStateContainer;
            }
            protected set
            {
                disabledStateContainer = value;
            }
        }
        [Tooltip("The GameObject container for the active visual states.")]
        [SerializeField]
        [Restricted]
        private GameObject activeStateContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the active visual states.
        /// </summary>
        public GameObject ActiveStateContainer
        {
            get
            {
                return activeStateContainer;
            }
            protected set
            {
                activeStateContainer = value;
            }
        }
        [Tooltip("The GameObject container for the collision volume management.")]
        [SerializeField]
        [Restricted]
        private GameObject collisionLogicContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the collision volume management.
        /// </summary>
        public GameObject CollisionLogicContainer
        {
            get
            {
                return collisionLogicContainer;
            }
            protected set
            {
                collisionLogicContainer = value;
            }
        }
        [Tooltip("The GameObject container for the source locking to origin management.")]
        [SerializeField]
        [Restricted]
        private GameObject lockSourceToOriginLogicContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the source locking to origin management.
        /// </summary>
        public GameObject LockSourceToOriginLogicContainer
        {
            get
            {
                return lockSourceToOriginLogicContainer;
            }
            protected set
            {
                lockSourceToOriginLogicContainer = value;
            }
        }
        [Tooltip("The GameObject container for the hiding the source cursor.")]
        [SerializeField]
        [Restricted]
        private GameObject hideSourceCursorLogicContainer;
        /// <summary>
        /// The <see cref="GameObject"/> container for the hiding the source cursor.
        /// </summary>
        public GameObject HideSourceCursorLogicContainer
        {
            get
            {
                return hideSourceCursorLogicContainer;
            }
            protected set
            {
                hideSourceCursorLogicContainer = value;
            }
        }
        [Tooltip("The tag that denotes if the collision volume should be in the disabled mode.")]
        [SerializeField]
        [Restricted]
        private SpatialTargetDisabledTag disabledTag;
        /// <summary>
        /// The tag that denotes if the collision volume should be in the disabled mode.
        /// </summary>
        public SpatialTargetDisabledTag DisabledTag
        {
            get
            {
                return disabledTag;
            }
            protected set
            {
                disabledTag = value;
            }
        }
        [Tooltip("The SpatialTarget controller for this configuration.")]
        [SerializeField]
        [Restricted]
        private SpatialTarget targetController;
        /// <summary>
        /// The <see cref="SpatialTarget"/> controller for this configuration.
        /// </summary>
        public SpatialTarget TargetController
        {
            get
            {
                return targetController;
            }
            protected set
            {
                targetController = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the enabled state.
        /// </summary>
        public virtual void ConfigureEnabledState()
        {
            EnabledStateContainer.SetActive(Facade.IsEnabled);
            DisabledStateContainer.SetActive(!Facade.IsEnabled);
            DisabledTag.enabled = !Facade.IsEnabled;
            TargetController.IsSelectable = Facade.IsEnabled;
        }

        /// <summary>
        /// Configures the enabled states of the override points.
        /// </summary>
        public virtual void ConfigureOverriedPoints()
        {
            TargetController.SourcePointOverride.SetActive(Facade.UseSourcePointOverride);
            TargetController.SelectedTargetOverride.SetActive(Facade.UseTargetOverride);
        }

        /// <summary>
        /// Configures the hover actions.
        /// </summary>
        public virtual void ConfigureHoverActions()
        {
            LockSourceToOriginLogicContainer.SetActive((Facade.ActionsOnHover & SpatialTargetFacade.HoverActions.LockPointerCursor) != 0);
            HideSourceCursorLogicContainer.SetActive((Facade.ActionsOnHover & SpatialTargetFacade.HoverActions.HidePointerCursor) != 0);
        }

        /// <summary>
        /// Configures the select actions.
        /// </summary>
        public virtual void ConfigureActivationActions()
        {
            TargetController.ExitAllHoveringOnActivated = (Facade.ActionsOnActivate & SpatialTargetFacade.ActivationActions.ClearHoveringState) != 0;
            TargetController.DeactivateSelfOnActivated = (Facade.ActionsOnActivate & SpatialTargetFacade.ActivationActions.DeselectSelf) != 0;
            TargetController.DeactivateDelay = Facade.DeselectSelfDelay;
            TargetController.DeactivateOtherSpatialTargetsOnActivated = (Facade.ActionsOnActivate & SpatialTargetFacade.ActivationActions.DeselectOtherTargets) != 0;
            ActiveStateContainer.SetActive((Facade.ActionsOnActivate & SpatialTargetFacade.ActivationActions.HideActiveState) == 0);
            CollisionLogicContainer.SetActive((Facade.ActionsOnActivate & SpatialTargetFacade.ActivationActions.DisableCollisionsOnActivate) != 0);
        }

        /// <summary>
        /// Configures the source validity.
        /// </summary>
        public virtual void ConfigureSourceValidity()
        {
            TargetController.SourceValidity = Facade.SourceValidity;
        }

        /// <summary>
        /// Invokes the <see cref="Facade.FirstEntered"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeFirstEntered(SurfaceData data)
        {
            Facade.FirstEntered?.Invoke(data);
        }

        /// <summary>
        /// Invokes the <see cref="Facade.Entered"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeEntered(SurfaceData data)
        {
            Facade.Entered?.Invoke(data);
        }

        /// <summary>
        /// Invokes the <see cref="Facade.Exited"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeExited(SurfaceData data)
        {
            Facade.Exited?.Invoke(data);
        }

        /// <summary>
        /// Invokes the <see cref="Facade.LastExited"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeLastExited(SurfaceData data)
        {
            Facade.LastExited?.Invoke(data);
        }

        /// <summary>
        /// Invokes the <see cref="Facade.Activated"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeActivated(SurfaceData data)
        {
            Facade.Activated?.Invoke(data);
        }

        /// <summary>
        /// Invokes the <see cref="Facade.Deactivated"/> event.
        /// </summary>
        /// <param name="data">The data to invoke with.</param>
        public virtual void InvokeDeactivated()
        {
            Facade.Deactivated?.Invoke();
        }

        protected virtual void OnEnable()
        {
            ConfigureEnabledState();
            ConfigureOverriedPoints();
            ConfigureHoverActions();
            ConfigureActivationActions();
            ConfigureSourceValidity();
        }
    }
}