﻿namespace GeNa
{
    /// <summary>
    /// GeNa Constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Version information
        /// </summary>
        public static string MajorVersion = "2";
        public static string MinorVersion = "0.1";

		/// <summary>
		/// The spawn mode that is used when using CTRL + Left Mouse Button
		/// </summary>
		public enum SpawnMode { Single, Paint/*, Spline*/ }

		/// <summary>
		/// The type of shape that is used to check the spawn range
		/// </summary>
		public enum SpawnRangeShape {  Circle, Square }

        /// <summary>
        /// The type of spawner location algorithm
        /// </summary>
        public enum LocationAlgorithm { Centered, Every, LastSpawn, Organic }

        /// <summary>
        /// The type of spawner rotation algorithm
        /// </summary>
        public enum RotationAlgorithm { Ranged, Fixed, LastSpawnCenter, LastSpawnClosest }

        /// <summary>
        /// The check to use for virgin space
        /// </summary>
        public enum VirginCheckType { None, Point, Bounds }

        /// <summary>
        /// The type of spawn component
        /// </summary>
        public enum ResourceType {  Prefab, TerrainTree, TerrainGrass }

        /// <summary>
        /// The type of mask to assign to the spawn
        /// </summary>
        public enum MaskType { Perlin, Billow, Ridged, Image }

        /// <summary>
        /// Distance to search before instantiating new probegroup
        /// </summary>
        public const float MinimimProbeGroupDistance = 100f;

        /// <summary>
        /// Minimum distance before instantiating new probes
        /// </summary>
        public const float MinimimProbeDistance = 15f;

        /// <summary>
        /// Wont opmimise stuff if larger than this
        /// </summary>
        public const float MaximumOptimisationSize = 100f;

        /// <summary>
        /// Vegetation type for AVS
        /// </summary>
        public enum AVSVegetationType
        {
            Grass = 0,
            Plant = 1,
            Tree = 2,
            Objects = 3,
            LargeObjects = 4
        }
    }
}
