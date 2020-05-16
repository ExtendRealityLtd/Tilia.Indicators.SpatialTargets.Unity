namespace Tilia.Indicators.SpatialTargets
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Indicators.SpatialTargets.Collection;
    using Zinnia.Data.Type;

    /// <summary>
    /// A <see cref="SpatialTargetDispatcher"/> collection that can be used to process multiple dispatchers from a single entry point.
    /// </summary>
    public class SpatialTargetDispatcherProcessor : Dispatcher
    {
        /// <summary>
        /// The <see cref="Dispatcher"/> collection to attempt to process.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public DispatcherObservableList DispatcherTargets { get; set; }
        /// <summary>
        /// Whether to cease the processing of the collection after the first valid <see cref="Dispatcher"/> is processed.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool CeaseAfterFirstSourceProcessed { get; set; }

        /// <summary>
        /// The current active <see cref="Dispatcher"/> being utilized.
        /// </summary>
        public Dispatcher ActiveDispatcherProcess
        {
            get => activeDispatcherProcess != null && activeDispatcherProcess.isActiveAndEnabled ? activeDispatcherProcess : null;
            protected set
            {
                activeDispatcherProcess = value;
            }
        }
        /// <summary>
        /// The backing field for holding the value of <see cref="ActiveDispatcherProcess"/>.
        /// </summary>
        private Dispatcher activeDispatcherProcess;

        /// <summary>
        /// The dispatch method to call.
        /// </summary>
        protected enum DispatchMethod
        {
            /// <summary>
            /// The Enter method.
            /// </summary>
            Enter,
            /// <summary>
            /// The Exit method.
            /// </summary>
            Exit,
            /// <summary>
            /// The Select method.
            /// </summary>
            Select
        }

        /// <inheritdoc/>
        protected override bool Enter(SurfaceData data)
        {
            return IterateDispatchers(data, DispatchMethod.Enter);
        }

        /// <inheritdoc/>
        protected override bool Exit(SurfaceData data)
        {
            return IterateDispatchers(data, DispatchMethod.Exit);
        }

        /// <inheritdoc/>
        protected override bool Select(SurfaceData data)
        {
            return IterateDispatchers(data, DispatchMethod.Select);
        }

        /// <summary>
        /// Calls the appropriate dispatcher method.
        /// </summary>
        /// <param name="process">The dispatcher to process the call on.</param>
        /// <param name="data">The data to process.</param>
        /// <param name="method">The method to call.</param>
        /// <returns></returns>
        protected virtual bool CallDispatchMethod(Dispatcher process, SurfaceData data, DispatchMethod method)
        {
            switch (method)
            {
                case DispatchMethod.Enter:
                    return process.DispatchEnter(data);
                case DispatchMethod.Exit:
                    return process.DispatchExit(data);
                case DispatchMethod.Select:
                    return process.DispatchSelect(data);
            }

            return false;
        }

        /// <summary>
        /// Iterates through the <see cref="Dispatcher"/> collection and calls the given method for each dispatcher process found.
        /// </summary>
        /// <param name="data">The data to process.</param>
        /// <param name="method">The method to call.</param>
        /// <returns></returns>
        protected virtual bool IterateDispatchers(SurfaceData data, DispatchMethod method)
        {
            if (DispatcherTargets == null)
            {
                return false;
            }

            bool hasProcessed = false;
            foreach (Dispatcher process in DispatcherTargets.NonSubscribableElements)
            {
                if (process != null && process.isActiveAndEnabled)
                {
                    ActiveDispatcherProcess = process;
                    if (CeaseAfterFirstSourceProcessed)
                    {
                        break;
                    }
                    else
                    {
                        hasProcessed = CallDispatchMethod(ActiveDispatcherProcess, data, method);
                    }
                }
            }

            if (CeaseAfterFirstSourceProcessed && ActiveDispatcherProcess != null)
            {
                return CallDispatchMethod(ActiveDispatcherProcess, data, method);
            }

            return hasProcessed;
        }
    }
}