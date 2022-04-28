namespace Tilia.Indicators.SpatialTargets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Enum;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// A target in a spatial location that can react to given <see cref="SurfaceData"/>.
    /// </summary>
    public class SpatialTarget : MonoBehaviour
    {
        /// <summary>
        /// Defines the event with the specified <see cref="SurfaceData"/>.
        /// </summary>
        [Serializable]
        public class SurfaceDataUnityEvent : UnityEvent<SurfaceData> { }

        #region Target Settings
        [Header("Target Settings")]
        [Tooltip("Whether this SpatialTarget is selectable.")]
        [SerializeField]
        private bool isSelectable = true;
        /// <summary>
        /// Whether this <see cref="SpatialTarget"/> is selectable.
        /// </summary>
        public bool IsSelectable
        {
            get
            {
                return isSelectable;
            }
            set
            {
                isSelectable = value;
            }
        }
        [Tooltip("Exits all HoveringElements when Select(SurfaceData) is executed successfully.")]
        [SerializeField]
        private bool exitAllHoveringOnActivated = true;
        /// <summary>
        /// Exits all <see cref="HoveringElements"/> when <see cref="Select(SurfaceData)"/> is executed successfully.
        /// </summary>
        public bool ExitAllHoveringOnActivated
        {
            get
            {
                return exitAllHoveringOnActivated;
            }
            set
            {
                exitAllHoveringOnActivated = value;
            }
        }
        [Tooltip("Deactivates this SpatialTarget when this SpatialTarget is activated.")]
        [SerializeField]
        private bool deactivateSelfOnActivated = true;
        /// <summary>
        /// Deactivates this <see cref="SpatialTarget"/> when this <see cref="SpatialTarget"/> is activated.
        /// </summary>
        public bool DeactivateSelfOnActivated
        {
            get
            {
                return deactivateSelfOnActivated;
            }
            set
            {
                deactivateSelfOnActivated = value;
            }
        }
        [Tooltip("The delay duration to wait before deactivating.")]
        [SerializeField]
        private float deactivateDelay;
        /// <summary>
        /// The delay duration to wait before deactivating.
        /// </summary>
        public float DeactivateDelay
        {
            get
            {
                return deactivateDelay;
            }
            set
            {
                deactivateDelay = value;
            }
        }
        [Tooltip("Deactivates any other SpatialTarget connected to the same SpatialTargetDispatcher when this SpatialTarget is activated.")]
        [SerializeField]
        private bool deactivateOtherSpatialTargetsOnActivated = true;
        /// <summary>
        /// Deactivates any other <see cref="SpatialTarget"/> connected to the same <see cref="SpatialTargetDispatcher"/> when this <see cref="SpatialTarget"/> is activated.
        /// </summary>
        public bool DeactivateOtherSpatialTargetsOnActivated
        {
            get
            {
                return deactivateOtherSpatialTargetsOnActivated;
            }
            set
            {
                deactivateOtherSpatialTargetsOnActivated = value;
            }
        }
        [Tooltip("Determine which SurfaceData sources can interact with this SpatialTarget.")]
        [SerializeField]
        private RuleContainer sourceValidity;
        /// <summary>
        /// Determine which <see cref="SurfaceData"/> sources can interact with this <see cref="SpatialTarget"/>.
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
            }
        }
        [Tooltip("Specifies a GameObject that contains this SpatialTarget.")]
        [SerializeField]
        private GameObject targetContainer;
        /// <summary>
        /// Specifies a <see cref="GameObject"/> that contains this <see cref="SpatialTarget"/>.
        /// </summary>
        public GameObject TargetContainer
        {
            get
            {
                return targetContainer;
            }
            set
            {
                targetContainer = value;
            }
        }
        [Tooltip("Overrides the point at which SurfaceData source originally collided with this SpatialTarget.")]
        [SerializeField]
        private GameObject sourcePointOverride;
        /// <summary>
        /// Overrides the point at which <see cref="SurfaceData"/> source originally collided with this <see cref="SpatialTarget"/>.
        /// </summary>
        public GameObject SourcePointOverride
        {
            get
            {
                return sourcePointOverride;
            }
            set
            {
                sourcePointOverride = value;
            }
        }
        [Tooltip("Overrides the selected target.")]
        [SerializeField]
        private GameObject selectedTargetOverride;
        /// <summary>
        /// Overrides the selected target.
        /// </summary>
        public GameObject SelectedTargetOverride
        {
            get
            {
                return selectedTargetOverride;
            }
            set
            {
                selectedTargetOverride = value;
            }
        }
        [Tooltip("The Transform properties to apply the selected target overrides on.")]
        [SerializeField]
        [UnityFlags]
        private TransformProperties applySelectedTargetProperties = TransformProperties.Position | TransformProperties.Rotation;
        /// <summary>
        /// The <see cref="Transform"/> properties to apply the selected target overrides on.
        /// </summary>
        public TransformProperties ApplySelectedTargetProperties
        {
            get
            {
                return applySelectedTargetProperties;
            }
            set
            {
                applySelectedTargetProperties = value;
            }
        }
        #endregion

        #region Target Events
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is entered for the first time.
        /// </summary>
        [Header("Target Events")]
        public SurfaceDataUnityEvent FirstEntered = new SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is entered.
        /// </summary>
        public SurfaceDataUnityEvent Entered = new SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is exited.
        /// </summary>
        public SurfaceDataUnityEvent Exited = new SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is exited for the last time.
        /// </summary>
        public SurfaceDataUnityEvent LastExited = new SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is activated.
        /// </summary>
        public SurfaceDataUnityEvent Activated = new SurfaceDataUnityEvent();
        /// <summary>
        /// Emitted when this <see cref="SpatialTarget"/> is deactivated.
        /// </summary>
        public UnityEvent Deactivated = new UnityEvent();
        #endregion

        /// <summary>
        /// Whether this <see cref="SpatialTarget"/> is currently being hovered over.
        /// </summary>
        public bool IsHovered { get; protected set; }
        /// <summary>
        /// Whether this <see cref="SpatialTarget"/> is currently activated.
        /// </summary>
        public bool IsActivated { get; protected set; }
        /// <summary>
        /// A collection of <see cref="SurfaceData"/> elements that are currently hovering over this <see cref="SpatialTarget"/>.
        /// </summary>
        public List<SurfaceData> HoveringElements { get; protected set; } = new List<SurfaceData>();
        /// <summary>
        /// The <see cref="SpatialTargetDispatcher"/> that has activated this <see cref="SpatialTarget"/>.
        /// </summary>
        public SpatialTargetDispatcher ActivatingDispatcher { get; protected set; }

        /// <summary>
        /// A container to store and mutate <see cref="RaycastHit"/> data from the hovering <see cref="SurfaceData"/>.
        /// </summary>
        protected RaycastHit hoverHit = new RaycastHit();
        /// <summary>
        /// A container to store and mutate the given <see cref="SurfaceData"/> on selection.
        /// </summary>
        protected SurfaceData selectedPayload = new SurfaceData();

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
        /// Clears <see cref="TargetContainer"/>.
        /// </summary>
        public virtual void ClearTargetContainer()
        {
            if (!this.IsValidState())
            {
                return;
            }

            TargetContainer = default;
        }

        /// <summary>
        /// Clears <see cref="SourcePointOverride"/>.
        /// </summary>
        public virtual void ClearSourcePointOverride()
        {
            if (!this.IsValidState())
            {
                return;
            }

            SourcePointOverride = default;
        }

        /// <summary>
        /// Clears <see cref="SelectedTargetOverride"/>.
        /// </summary>
        public virtual void ClearSelectedTargetOverride()
        {
            if (!this.IsValidState())
            {
                return;
            }

            SelectedTargetOverride = default;
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> entering the target spatial location.
        /// </summary>
        /// <param name="data">The entering data.</param>
        /// <returns>Whether the enter was successful.</returns>
        public virtual bool Enter(SurfaceData data)
        {
            if (!this.IsValidState() || !IsValidData(data))
            {
                return false;
            }

            SurfaceData hoverPayload = CreateHoverPayload(data);
            IsHovered = true;

            if (!HoveringElements.Any(element => element.Transform.Equals(data.Transform)))
            {
                HoveringElements.Add(data);

                if (HoveringElements.Count == 1)
                {
                    FirstEntered?.Invoke(hoverPayload);
                }
            }

            Entered?.Invoke(hoverPayload);

            return true;
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> entering the target spatial location.
        /// </summary>
        /// <param name="data">The entering data.</param>
        public virtual void DoEnter(SurfaceData data)
        {
            Enter(data);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> entering the target spatial location.
        /// </summary>
        /// <param name="enteringObject">The entering object.</param>
        /// <returns>Whether the enter was successful.</returns>
        public virtual bool Enter(GameObject enteringObject)
        {
            if (!this.IsValidState() || enteringObject == null)
            {
                return false;
            }

            SurfaceData surfaceData = new SurfaceData(enteringObject.transform);
            return Enter(surfaceData);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> entering the target spatial location.
        /// </summary>
        /// <param name="enteringObject">The entering object.</param>
        public virtual void DoEnter(GameObject enteringObject)
        {
            Enter(enteringObject);
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> exiting from the target spatial location.
        /// </summary>
        /// <param name="data">The exiting data.</param>
        /// <returns>Whether the exit was successful.</returns>
        public virtual bool Exit(SurfaceData data)
        {
            if (!this.IsValidState() || !IsValidData(data, true))
            {
                return false;
            }

            if (HoveringElements.RemoveAll(element => element.Transform.Equals(data.Transform)) > 0)
            {
                SurfaceData hoverPayload = CreateHoverPayload(data);

                Exited?.Invoke(hoverPayload);

                if (HoveringElements.Count == 0)
                {
                    IsHovered = false;
                    LastExited?.Invoke(hoverPayload);
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> exiting from the target spatial location.
        /// </summary>
        /// <param name="data">The exiting data.</param>
        public virtual void DoExit(SurfaceData data)
        {
            Exit(data);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> exiting from the target spatial location.
        /// </summary>
        /// <param name="exitingObject">The exiting object.</param>
        /// <returns>Whether the exit was successful.</returns>
        public virtual bool Exit(GameObject exitingObject)
        {
            if (!this.IsValidState() || exitingObject == null)
            {
                return false;
            }

            SurfaceData surfaceData = new SurfaceData(exitingObject.transform);
            return Exit(surfaceData);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> exiting from the target spatial location.
        /// </summary>
        /// <param name="exitingObject">The exiting object.</param>
        public virtual void DoExit(GameObject exitingObject)
        {
            Exit(exitingObject);
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> selecting on target spatial location.
        /// </summary>
        /// <param name="dispatcher">The dispatcher calling the method.</param>
        /// <param name="data">The selecting data.</param>
        /// <returns>Whether the select was successful.</returns>
        public virtual bool Select(SpatialTargetDispatcher dispatcher, SurfaceData data)
        {
            if (!this.IsValidState() || !IsSelectable)
            {
                return false;
            }

            if (ActivatingDispatcher != null && ActivatingDispatcher != dispatcher)
            {
                ActivatingDispatcher.RemoveFromSelectedTargets(this);
            }

            ActivatingDispatcher = dispatcher;
            return Select(data);
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> selecting on target spatial location.
        /// </summary>
        /// <param name="dispatcher">The dispatcher calling the method.</param>
        /// <param name="data">The selecting data.</param>
        public virtual void DoSelect(SpatialTargetDispatcher dispatcher, SurfaceData data)
        {
            Select(dispatcher, data);
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> selecting on target spatial location.
        /// </summary>
        /// <param name="data">The selecting data.</param>
        /// <returns>Whether the select was successful.</returns>
        public virtual bool Select(SurfaceData data)
        {
            if (!this.IsValidState() || !IsSelectable || !IsValidData(data, true))
            {
                return false;
            }

            if (IsActivated)
            {
                return Deselect();
            }

            IsActivated = true;
            Activated?.Invoke(CreateSelectedPayload(data));

            if (ExitAllHoveringOnActivated)
            {
                for (int index = HoveringElements.Count - 1; index >= 0; index--)
                {
                    Exit(HoveringElements[index]);
                }

                HoveringElements.Clear();
            }

            if (DeactivateSelfOnActivated)
            {
                if (DeactivateDelay.ApproxEquals(0f))
                {
                    return Deselect();
                }
                else
                {
                    Invoke("DoDeselect", DeactivateDelay);
                    return true;
                }
            }

            return true;
        }

        /// <summary>
        /// Reacts to <see cref="SurfaceData"/> selecting on target spatial location.
        /// </summary>
        /// <param name="data">The selecting data.</param>
        public virtual void DoSelect(SurfaceData data)
        {
            Select(data);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> selecting on target spatial location.
        /// </summary>
        /// <param name="selectingObject">The selecting object.</param>
        /// <returns>Whether the select was successful.</returns>
        public virtual bool Select(GameObject selectingObject)
        {
            if (!this.IsValidState() || selectingObject == null)
            {
                return false;
            }

            SurfaceData surfaceData = new SurfaceData(selectingObject.transform);
            return Select(surfaceData);
        }

        /// <summary>
        /// Reacts to a <see cref="GameObject"/> selecting on target spatial location.
        /// </summary>
        /// <param name="selectingObject">The selecting object.</param>
        public virtual void DoSelect(GameObject selectingObject)
        {
            Select(selectingObject);
        }

        /// <summary>
        /// De-selects this <see cref="SpatialTarget"/> if it is in a selected state.
        /// </summary>
        /// <param name="keepInActivatingDispatcher">Whether to keep this in the <see cref="ActivatingDispatcher.SelectedTargets"/> collection.</param>
        /// <returns>Whether the de-select was successful.</returns>
        public virtual bool Deselect(bool keepInActivatingDispatcher = false)
        {
            if (!this.IsValidState() || !IsSelectable || !IsActivated)
            {
                return false;
            }

            IsActivated = false;
            if (ActivatingDispatcher != null)
            {
                if (!keepInActivatingDispatcher)
                {
                    ActivatingDispatcher.RemoveFromSelectedTargets(this);
                }
                ActivatingDispatcher = null;
            }
            Deactivated?.Invoke();

            return true;
        }

        /// <summary>
        /// De-selects this <see cref="SpatialTarget"/> if it is in a selected state.
        /// </summary>
        /// <param name="keepInActivatingDispatcher">Whether to keep this in the <see cref="ActivatingDispatcher.SelectedTargets"/> collection.</param>
        public virtual void DoDeselect(bool keepInActivatingDispatcher)
        {
            Deselect(keepInActivatingDispatcher);
        }

        /// <summary>
        /// De-selects this <see cref="SpatialTarget"/> if it is in a selected state.
        /// </summary>
        public virtual void DoDeselect()
        {
            Deselect(false);
        }

        /// <summary>
        /// Whether the given data is valid.
        /// </summary>
        /// <param name="data">The data to check.</param>
        /// <param name="checkIfHovered">Whether to check if the hover state is active.</param>
        /// <returns>Whether the data is valid.</returns>
        protected virtual bool IsValidData(SurfaceData data, bool checkIfHovered = false)
        {
            return data.Transform != null &&
                data.Transform.gameObject != null &&
                SourceValidity.Accepts(data.Transform.gameObject) &&
                (!checkIfHovered || HoveringElements.Any(element => element.Transform.Equals(data.Transform)));

        }

        /// <summary>
        /// Creates the payload to emit on the hovering events of <see cref="FirstEntered"/>, <see cref="Entered"/>, <see cref="Exited"/> and <see cref="LastExited"/>.
        /// </summary>
        /// <param name="data">The data that is mutating the hover state.</param>
        /// <returns>The mutated data to emit.</returns>
        protected virtual SurfaceData CreateHoverPayload(SurfaceData data)
        {
            if (SourcePointOverride == null || !SourcePointOverride.activeInHierarchy)
            {
                return data;
            }

            hoverHit = data.CollisionData;
            hoverHit.point = SourcePointOverride.transform.position;
            data.CollisionData = hoverHit;

            return data;
        }

        /// <summary>
        /// Creates the payload to emit on the <see cref="Activated"/> event.
        /// </summary>
        /// <param name="data">The default data to potentially mutate.</param>
        /// <returns>The mutated data to emit.</returns>
        protected virtual SurfaceData CreateSelectedPayload(SurfaceData data)
        {
            if (SelectedTargetOverride == null || !SelectedTargetOverride.activeInHierarchy)
            {
                return data;
            }

            selectedPayload.Origin = data.Origin;
            selectedPayload.Direction = data.Direction;
            selectedPayload.CollisionData = data.CollisionData;
            selectedPayload.Transform = SelectedTargetOverride.transform;

            if ((ApplySelectedTargetProperties & TransformProperties.Position) == 0)
            {
                selectedPayload.PositionOverride = data.Position;
            }

            if ((ApplySelectedTargetProperties & TransformProperties.Rotation) == 0)
            {
                selectedPayload.RotationOverride = data.Rotation;
            }

            if ((ApplySelectedTargetProperties & TransformProperties.Scale) == 0)
            {
                selectedPayload.ScaleOverride = data.Scale;
            }

            return selectedPayload;
        }
    }
}