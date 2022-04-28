namespace Tilia.Indicators.SpatialTargets
{
    using UnityEngine;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// The basis for all dispatcher types for the spatial targets.
    /// </summary>
    public abstract class Dispatcher : MonoBehaviour
    {
        [Tooltip("Determine which SurfaceData sources can interact with this Dispatcher")]
        [SerializeField]
        private RuleContainer sourceValidity;
        /// <summary>
        /// Determine which <see cref="SurfaceData"/> sources can interact with this <see cref="Dispatcher"/>.
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
        /// Dispatches the Enter command for the given data.
        /// </summary>
        /// <param name="data">The data that has been entered.</param>
        /// <returns>Whether the dispatch was successful.</returns>
        public virtual bool DispatchEnter(SurfaceData data)
        {
            if (!this.IsValidState() || !IsValidData(data))
            {
                return false;
            }

            return Enter(data);
        }

        /// <summary>
        /// Dispatches the Enter command for the given data.
        /// </summary>
        /// <param name="data">The data that has been entered.</param>
        public virtual void DoDispatchEnter(SurfaceData data)
        {
            DispatchEnter(data);
        }

        /// <summary>
        /// Dispatches the Exit command for the given data.
        /// </summary>
        /// <param name="data">The data that has been exited.</param>
        /// <returns>Whether the dispatch was successful.</returns>
        public virtual bool DispatchExit(SurfaceData data)
        {
            if (!this.IsValidState() || !IsValidData(data))
            {
                return false;
            }

            return Exit(data);
        }

        /// <summary>
        /// Dispatches the Exit command for the given data.
        /// </summary>
        /// <param name="data">The data that has been exited.</param>
        public virtual void DoDispatchExit(SurfaceData data)
        {
            DispatchExit(data);
        }

        /// <summary>
        /// Dispatches the Select command for the given data.
        /// </summary>
        /// <param name="data">The data that has been selected.</param>
        /// <returns>Whether the dispatch was successful.</returns>
        public virtual bool DispatchSelect(SurfaceData data)
        {
            if (!this.IsValidState() || !IsValidData(data))
            {
                return false;
            }

            return Select(data);
        }

        /// <summary>
        /// Dispatches the Select command for the given data.
        /// </summary>
        /// <param name="data">The data that has been selected.</param>
        public virtual void DoDispatchSelect(SurfaceData data)
        {
            DispatchSelect(data);
        }

        /// <summary>
        /// Processes the given data as an Enter command on a <see cref="SpatialTarget"/>.
        /// </summary>
        /// <param name="data">The data that has been entered.</param>
        /// <returns>Whether the process was successful.</returns>
        protected abstract bool Enter(SurfaceData data);
        /// <summary>
        /// Processes the given data as an Exit command on a <see cref="SpatialTarget"/>.
        /// </summary>
        /// <param name="data">The data that has been exited.</param>
        /// <returns>Whether the process was successful.</returns>
        protected abstract bool Exit(SurfaceData data);
        /// <summary>
        /// Processes the given data as an Select command on a <see cref="SpatialTarget"/>.
        /// </summary>
        /// <param name="data">The data that has been selected.</param>
        /// <returns>Whether the process was successful.</returns>
        protected abstract bool Select(SurfaceData data);

        /// <summary>
        /// Whether the given data is valid.
        /// </summary>
        /// <param name="data">The data to check.</param>
        /// <returns>Whether the data is valid.</returns>
        protected virtual bool IsValidData(SurfaceData data)
        {
            return data != null && data.Transform != null && data.Transform.gameObject != null && SourceValidity.Accepts(data.Transform.gameObject);
        }
    }
}
