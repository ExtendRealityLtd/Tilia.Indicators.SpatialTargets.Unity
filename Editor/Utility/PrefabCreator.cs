namespace Tilia.Indicators.SpatialTargets.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Indicators/SpatialTargets/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.indicators.spatialtargets.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabSpatialTargetsDispatcher = "Indicators.SpatialTargets.Dispatcher";
        private const string prefabSpatialTargetsProcessor = "Indicators.SpatialTargets.Processor";
        private const string prefabSpatialTargetsTarget = "Indicators.SpatialTargets.Target";

        [MenuItem(menuItemRoot + prefabSpatialTargetsDispatcher, false, priority)]
        private static void AddSpatialTargetsDispatcher()
        {
            string prefab = prefabSpatialTargetsDispatcher + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabSpatialTargetsProcessor, false, priority)]
        private static void AddSpatialTargetsProcessor()
        {
            string prefab = prefabSpatialTargetsProcessor + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabSpatialTargetsTarget, false, priority)]
        private static void AddSpatialTargetsTarget()
        {
            string prefab = prefabSpatialTargetsTarget + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}