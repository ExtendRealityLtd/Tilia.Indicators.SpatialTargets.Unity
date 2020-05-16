namespace Tilia.Indicators.SpatialTargets
{
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System.Collections.Generic;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// A Dispatcher that finds the appropriate <see cref="SpatialTarget"/> on the given data and dispatches the relevant call.
    /// </summary>
    public class SpatialTargetDispatcher : Dispatcher
    {
        /// <summary>
        /// Determine if the <see cref="SpatialTarget"/> can be dispatched to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public RuleContainer TargetValidity { get; set; }

        /// <summary>
        /// A <see cref="SpatialTarget"/> collection of the currently selected targets.
        /// </summary>
        public List<SpatialTarget> SelectedTargets { get; protected set; } = new List<SpatialTarget>();

        /// <summary>
        /// Removes the given target from the <see cref="SelectedTargets"/> collection.
        /// </summary>
        /// <param name="target">The target to remove.</param>
        /// <returns>Whether the remove was successful.</returns>
        public virtual bool RemoveFromSelectedTargets(SpatialTarget target)
        {
            return SelectedTargets.Remove(target); ;
        }

        /// <summary>
        /// Removes the given target from the <see cref="SelectedTargets"/> collection.
        /// </summary>
        /// <param name="target">The target to remove.</param>
        public virtual void DoRemoveFromSelectedTargets(SpatialTarget target)
        {
            RemoveFromSelectedTargets(target);
        }

        /// <inheritdoc/>
        protected override bool Enter(SurfaceData data)
        {
            SpatialTarget target = GetSpatialTarget(data);
            return target != null ? target.Enter(data) : false;
        }

        /// <inheritdoc/>
        protected override bool Exit(SurfaceData data)
        {
            SpatialTarget target = GetSpatialTarget(data);
            return target != null ? target.Exit(data) : false;
        }

        /// <inheritdoc/>
        protected override bool Select(SurfaceData data)
        {
            SpatialTarget target = GetSpatialTarget(data);
            if (target == null)
            {
                return false;
            }

            if (!SelectedTargets.Contains(target))
            {
                SelectedTargets.Add(target);
                if (!target.Select(this, data))
                {
                    SelectedTargets.Remove(target);
                    return false;
                }

                DeselectOtherTargetsOnSelect(target);
            }
            else
            {
                SelectedTargets.Remove(target);
                target.Deselect();
            }

            return true;
        }

        /// <summary>
        /// Gets the <see cref="SpatialTarget"/> related to the given data.
        /// </summary>
        /// <param name="data">The data to look on.</param>
        /// <returns>The found <see cref="SpatialTarget"/>.</returns>
        protected virtual SpatialTarget GetSpatialTarget(SurfaceData data)
        {
            if (data == null || data.CollisionData.transform == null)
            {
                return null;
            }

            SpatialTarget foundTarget = data.CollisionData.transform.gameObject.TryGetComponent<SpatialTarget>(false, true);

            if (foundTarget == null || !TargetValidity.Accepts(foundTarget.TargetContainer != null ? foundTarget.TargetContainer : foundTarget.gameObject))
            {
                return null;
            }

            return foundTarget;
        }

        /// <summary>
        /// Deselects all other selected targets that are associated with this dispatcher.
        /// </summary>
        /// <param name="target">The current <see cref="SpatialTarget"/> which will be ignored in the deselect.</param>
        protected virtual void DeselectOtherTargetsOnSelect(SpatialTarget target)
        {
            if (target.DeactivateOtherSpatialTargetsOnActivated)
            {
                foreach (SpatialTarget other in SelectedTargets)
                {
                    if (other.Equals(target))
                    {
                        continue;
                    }

                    other.Deselect(true);
                }
                SelectedTargets.RemoveAll(item => !item.Equals(target));
            }
        }
    }
}