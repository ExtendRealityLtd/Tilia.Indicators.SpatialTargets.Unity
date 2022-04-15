namespace Tilia.Indicators.SpatialTargets
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Collection.List;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface into the SpatialTarget Prefab.
    /// </summary>
    public class SpatialTargetFacade : MonoBehaviour
    {
        /// <summary>
        /// Actions that can be performed when hovering.
        /// </summary>
        [Flags]
        public enum HoverActions
        {
            /// <summary>
            /// Locks the pointer cursor to the target origin.
            /// </summary>
            LockPointerCursor = 1 << 0,
            /// <summary>
            /// Hides the pointer cursor.
            /// </summary>
            HidePointerCursor = 1 << 1
        }

        /// <summary>
        /// Actions that can be performed when activating.
        /// </summary>
        [Flags]
        public enum ActivationActions
        {
            /// <summary>
            /// Clears any existing hover state on this target.
            /// </summary>
            ClearHoveringState = 1 << 0,
            /// <summary>
            /// De-selects this target upon activating this target.
            /// </summary>
            DeselectSelf = 1 << 1,
            /// <summary>
            /// De-selects any other activated targets associated with the calling dispatcher.
            /// </summary>
            DeselectOtherTargets = 1 << 2,
            /// <summary>
            /// Hides the target active visual state.
            /// </summary>
            HideActiveState = 1 << 3,
            /// <summary>
            /// Prevents the pointer from continuing to collide with the target when it is activated.
            /// </summary>
            DisableCollisionsOnActivate = 1 << 4
        }

        #region Target Settings
        [Header("Target Settings")]
        [Tooltip("Whether the SpatialTargetFacade is in the enabled state.")]
        [SerializeField]
        private bool isEnabled = true;
        /// <summary>
        /// Whether the <see cref="SpatialTargetFacade"/> is in the enabled state.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                isEnabled = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterIsEnabledChange();
                }
            }
        }
        [Tooltip("Whether to use the source point override GameObject to lock the pointer cursor to.")]
        [SerializeField]
        private bool useSourcePointOverride = true;
        /// <summary>
        /// Whether to use the source point override <see cref="GameObject"/> to lock the pointer cursor to.
        /// </summary>
        public bool UseSourcePointOverride
        {
            get
            {
                return useSourcePointOverride;
            }
            set
            {
                useSourcePointOverride = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterUseSourcePointOverrideChange();
                }
            }
        }
        [Tooltip("Whether to use the target override GameObject to use as the TransformData.Transform in the event payloads.")]
        [SerializeField]
        private bool useTargetOverride = true;
        /// <summary>
        /// Whether to use the target override <see cref="GameObject"/> to use as the <see cref="TransformData.Transform"/> in the event payloads.
        /// </summary>
        public bool UseTargetOverride
        {
            get
            {
                return useTargetOverride;
            }
            set
            {
                useTargetOverride = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterUseTargetOverrideChange();
                }
            }
        }
        [Tooltip("Actions to perform when the SpatialTargetFacade is hovered over.")]
        [SerializeField]
        [UnityFlags]
        private HoverActions actionsOnHover = (HoverActions)(-1);
        /// <summary>
        /// Actions to perform when the <see cref="SpatialTargetFacade"/> is hovered over.
        /// </summary>
        public HoverActions ActionsOnHover
        {
            get
            {
                return actionsOnHover;
            }
            set
            {
                actionsOnHover = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterActionsOnHoverChange();
                }
            }
        }
        [Tooltip("Actions to perform when the SpatialTargetFacade is activated.")]
        [SerializeField]
        [UnityFlags]
        private ActivationActions actionsOnActivate = (ActivationActions)(-1);
        /// <summary>
        /// Actions to perform when the <see cref="SpatialTargetFacade"/> is activated.
        /// </summary>
        public ActivationActions ActionsOnActivate
        {
            get
            {
                return actionsOnActivate;
            }
            set
            {
                actionsOnActivate = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterActionsOnActivateChange();
                }
            }
        }
        [Tooltip("The amount of time to delay de-selecting this Spatial Target after it has been activated if the ActionsOnActivate ActivationActions.DeselectSelf is enabled.")]
        [SerializeField]
        private float deselectSelfDelay;
        /// <summary>
        /// The amount of time to delay de-selecting this Spatial Target after it has been activated if the <see cref="ActionsOnActivate"/> <see cref="ActivationActions.DeselectSelf"/> is enabled.
        /// </summary>
        public float DeselectSelfDelay
        {
            get
            {
                return deselectSelfDelay;
            }
            set
            {
                deselectSelfDelay = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDeselectSelfDelayChange();
                }
            }
        }
        [Tooltip("Determine which SurfaceData sources can interact with this SpatialTargetFacade.")]
        [SerializeField]
        private RuleContainer sourceValidity;
        /// <summary>
        /// Determine which <see cref="SurfaceData"/> sources can interact with this <see cref="SpatialTargetFacade"/>.
        /// </summary>
        public RuleContainer SourceValidity
        {
            get
            {
                return sourceValidity;
            }
            set
            {
                sourceValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSourceValidityChange();
                }
            }
        }
        [Tooltip("A UnityEngine.Object collection of objects that can collide with the spatial target.")]
        [SerializeField]
        private UnityObjectObservableList collidableObjects;
        /// <summary>
        /// A <see cref="UnityEngine.Object"/> collection of objects that can collide with the spatial target.
        /// </summary>
        public UnityObjectObservableList CollidableObjects
        {
            get
            {
                return collidableObjects;
            }
            set
            {
                collidableObjects = value;
            }
        }
        #endregion

        #region Target Events
        /// <summary>
        /// Emitted when the target is entered for the first time.
        /// </summary>
        [Header("Target Events")]
        public SpatialTarget.SurfaceDataUnityEvent FirstEntered = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is entered.
        /// </summary>
        public SpatialTarget.SurfaceDataUnityEvent Entered = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is exited.
        /// </summary>
        public SpatialTarget.SurfaceDataUnityEvent Exited = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is exited for the last time.
        /// </summary>
        public SpatialTarget.SurfaceDataUnityEvent LastExited = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is activated.
        /// </summary>
        public SpatialTarget.SurfaceDataUnityEvent Activated = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is deactivated.
        /// </summary>
        public UnityEvent Deactivated = new UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private SpatialTargetConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public SpatialTargetConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="SourceValidity"/>.
        /// </summary>
        public virtual void ClearSourceValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            SourceValidity = default;
        }

        /// <summary>
        /// Clears <see cref="Configuration"/>.
        /// </summary>
        public virtual void ClearConfiguration()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Configuration = default;
        }

        /// <summary>
        /// De-selects the containing <see cref="SpatialTarget"/> if it is in a selected state.
        /// </summary>
        /// <param name="keepInActivatingDispatcher">Whether to keep this in the <see cref="ActivatingDispatcher.SelectedTargets"/> collection.</param>
        public virtual void Deselect(bool keepInActivatingDispatcher = false)
        {
            Configuration.TargetController.DoDeselect(keepInActivatingDispatcher);
        }

        /// <summary>
        /// Called after <see cref="IsEnabled"/> has been changed.
        /// </summary>
        protected virtual void OnAfterIsEnabledChange()
        {
            Configuration.ConfigureEnabledState();
        }

        /// <summary>
        /// Called after <see cref="UseSourcePointOverride"/> has been changed.
        /// </summary>
        protected virtual void OnAfterUseSourcePointOverrideChange()
        {
            Configuration.ConfigureOverriedPoints();
        }

        /// <summary>
        /// Called after <see cref="UseTargetOverride"/> has been changed.
        /// </summary>
        protected virtual void OnAfterUseTargetOverrideChange()
        {
            Configuration.ConfigureOverriedPoints();
        }

        /// <summary>
        /// Called after <see cref="ActionsOnHover"/> has been changed.
        /// </summary>
        protected virtual void OnAfterActionsOnHoverChange()
        {
            Configuration.ConfigureHoverActions();
        }

        [Obsolete("Use `OnAfterActionsOnHoverChange` instead.")]
        protected virtual void OnAfterActionOnHoverChange()
        {
            OnAfterActionsOnHoverChange();
        }

        /// <summary>
        /// Called after <see cref="ActionsOnActivate"/> has been changed.
        /// </summary>
        protected virtual void OnAfterActionsOnActivateChange()
        {
            Configuration.ConfigureActivationActions();
        }

        [Obsolete("Use `OnAfterActionsOnActivateChange` instead.")]
        protected virtual void OnAfterActionOnSelectChange()
        {
            OnAfterActionsOnActivateChange();
        }

        /// <summary>
        /// Called after <see cref="DeselectSelfDelay"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDeselectSelfDelayChange()
        {
            Configuration.ConfigureActivationActions();
        }

        /// <summary>
        /// Called after <see cref="SourceValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSourceValidityChange()
        {
            Configuration.ConfigureSourceValidity();
        }
    }
}