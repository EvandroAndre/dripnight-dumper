using System;
using UnityEngine;

public class SAColliderBuilderCommon
{
	public enum ShapeType
	{
		None,
		Mesh,
		Box,
		Capsule,
		Sphere
	}

	public enum FitType
	{
		Outer,
		Inner
	}

	public enum MeshType
	{
		Raw,
		ConvexBoxes,
		ConvexHull,
		Box
	}

	public enum SliceMode
	{
		Auto,
		X,
		Y,
		Z
	}

	public enum ElementType
	{
		X,
		XYZ
	}

	[Serializable]
	public struct Bool3(bool x, bool y, bool z)
	{
		public bool x = false;

		public bool y = false;

		public bool z = false;

		public void SetValue(bool x, bool y, bool z)
		{
		}
	}

	public enum ColliderToChild
	{
		Auto,
		On,
		Off
	}

	[Serializable]
	public class ReducerProperty
	{
		public ShapeType shapeType;

		public FitType fitType;

		public MeshType meshType;

		public int maxTriangles;

		public SliceMode sliceMode;

		public Vector3 scale;

		public ElementType scaleElementType;

		public Vector3 minThickness;

		public ElementType minThicknessElementType;

		public Bool3 optimizeRotation;

		public ElementType optimizeRotationElementType;

		public ColliderToChild colliderToChild;

		public Vector3 offset;

		public Vector3 thicknessA;

		public Vector3 thicknessB;

		public bool viewAdvanced;

		public ReducerProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	public class ColliderProperty
	{
		public bool convex;

		public bool isTrigger;

		public PhysicMaterial material;

		public bool isCreateAsset;

		public ColliderProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	public class RigidbodyProperty
	{
		public float mass;

		public float drag;

		public float angularDrag;

		public bool isKinematic;

		public bool useGravity;

		public RigidbodyInterpolation interpolation;

		public CollisionDetectionMode collisionDetectionMode;

		public bool isCreate;

		public bool viewAdvanced;

		public RigidbodyProperty ShallowCopy()
		{
			return null;
		}
	}
}
