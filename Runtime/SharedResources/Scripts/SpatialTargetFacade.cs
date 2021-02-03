namespace Tilia.Indicators.SpatialTargets
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Collection.List;
    using Zinnia.Data.Type;
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
        /// <summary>
        /// Whether the <see cref="SpatialTargetFacade"/> is in the enabled state.
        /// </summary>
        [Serialized]
        [field: Header("Target Settings"), DocumentedByXml]
        public bool IsEnabled { get; set; } = true;
        /// <summary>
        /// Whether to use the source point override <see cref="GameObject"/> to lock the pointer cursor to.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool UseSourcePointOverride { get; set; } = true;
        /// <summary>
        /// Whether to use the target override <see cref="GameObject"/> to use as the <see cref="TransformData.Transform"/> in the event payloads.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool UseTargetOverride { get; set; } = true;
        /// <summary>
        /// Actions to perform when the <see cref="SpatialTargetFacade"/> is hovered over.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, UnityFlags]
        public HoverActions ActionsOnHover { get; set; } = (HoverActions)(-1);
        /// <summary>
        /// Actions to perform when the <see cref="SpatialTargetFacade"/> is activated.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, UnityFlags]
        public ActivationActions ActionsOnActivate { get; set; } = (ActivationActions)(-1);
        /// <summary>
        /// The amount of time to delay de-selecting this Spatial Target after it has been activated if the <see cref="ActionsOnActivate"/> <see cref="ActivationActions.DeselectSelf"/> is enabled.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float DeselectSelfDelay { get; set; }
        /// <summary>
        /// Determine which <see cref="SurfaceData"/> sources can interact with this <see cref="SpatialTargetFacade"/>.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public RuleContainer SourceValidity { get; set; }
        /// <summary>
        /// A <see cref="UnityEngine.Object"/> collection of objects that can collide with the spatial target.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public UnityObjectObservableList CollidableObjects { get; set; }
        #endregion

        #region Target Events
        /// <summary>
        /// Emitted when the target is entered for the first time.
        /// </summary>
        [Header("Target Events"), DocumentedByXml]
        public SpatialTarget.SurfaceDataUnityEvent FirstEntered = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is entered.
        /// </summary>
        [DocumentedByXml]
        public SpatialTarget.SurfaceDataUnityEvent Entered = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is exited.
        /// </summary>
        [DocumentedByXml]
        public SpatialTarget.SurfaceDataUnityEvent Exited = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is exited for the last time.
        /// </summary>
        [DocumentedByXml]
        public SpatialTarget.SurfaceDataUnityEvent LastExited = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is activated.
        /// </summary>
        [DocumentedByXml]
        public SpatialTarget.SurfaceDataUnityEvent Activated = new SpatialTarget.SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when the target is deactivated.
        /// </summary>
        [DocumentedByXml]
        public UnityEvent Deactivated = new UnityEvent();
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public SpatialTargetConfigurator Configuration { get; protected set; }
        #endregion

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
        [CalledAfterChangeOf(nameof(IsEnabled))]
        protected virtual void OnAfterIsEnabledChange()
        {
            Configuration.ConfigureEnabledState();
        }

        /// <summary>
        /// Called after <see cref="UseSourcePointOverride"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(UseSourcePointOverride))]
        protected virtual void OnAfterUseSourcePointOverrideChange()
        {
            Configuration.ConfigureOverriedPoints();
        }

        /// <summary>
        /// Called after <see cref="UseTargetOverride"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(UseTargetOverride))]
        protected virtual void OnAfterUseTargetOverrideChange()
        {
            Configuration.ConfigureOverriedPoints();
        }

        /// <summary>
        /// Called after <see cref="ActionsOnHover"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ActionsOnHover))]
        protected virtual void OnAfterActionOnHoverChange()
        {
            Configuration.ConfigureHoverActions();
        }

        /// <summary>
        /// Called after <see cref="ActionsOnActivate"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ActionsOnActivate))]
        protected virtual void OnAfterActionOnSelectChange()
        {
            Configuration.ConfigureActivationActions();
        }

        /// <summary>
        /// Called after <see cref="DeselectSelfDelay"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DeselectSelfDelay))]
        protected virtual void OnAfterDeselectSelfDelayChange()
        {
            Configuration.ConfigureActivationActions();
        }

        /// <summary>
        /// Called after <see cref="SourceValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(SourceValidity))]
        protected virtual void OnAfterSourceValidityChange()
        {
            Configuration.ConfigureSourceValidity();
        }
    }
}