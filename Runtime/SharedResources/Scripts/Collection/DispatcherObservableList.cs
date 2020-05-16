namespace Tilia.Indicators.SpatialTargets.Collection
{
    using System;
    using System.Collections.Generic;
    using UnityEngine.Events;
    using Zinnia.Data.Collection.List;

    /// <summary>
    /// Allows observing changes to a <see cref="List{T}"/> of <see cref="Dispatcher"/>s.
    /// </summary>
    public class DispatcherObservableList : DefaultObservableList<Dispatcher, DispatcherObservableList.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the <see cref="Dispatcher"/>.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Dispatcher>
        {
        }
    }
}