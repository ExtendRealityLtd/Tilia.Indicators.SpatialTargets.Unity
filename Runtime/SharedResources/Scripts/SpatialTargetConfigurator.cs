namespace Tilia.Indicators.SpatialTargets
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
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
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public SpatialTargetFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="GameObject"/> container for the enabled visual states.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public GameObject EnabledStateContainer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> container for the disabled visual states.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject DisabledStateContainer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> container for the active visual states.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject ActiveStateContainer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> container for the collision volume management.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject CollisionLogicContainer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> container for the source locking to origin management.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject LockSourceToOriginLogicContainer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> container for the hiding the source cursor.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject HideSourceCursorLogicContainer { get; protected set; }
        /// <summary>
        /// The tag that denotes if the collision volume should be in the disabled mode.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public SpatialTargetDisabledTag DisabledTag { get; protected set; }
        /// <summary>
        /// The <see cref="SpatialTarget"/> controller for this configuration.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public SpatialTarget TargetController { get; protected set; }
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