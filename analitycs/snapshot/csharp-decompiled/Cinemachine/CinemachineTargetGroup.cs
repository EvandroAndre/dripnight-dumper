using System;
using UnityEngine;

namespace Cinemachine;

public class CinemachineTargetGroup : MonoBehaviour
{
	[Serializable]
	public class Target
	{
		public Transform target;

		public float weight;

		public float radius;
	}

	public enum PositionMode
	{
		GroupCenter,
		GroupAverage
	}

	public enum RotationMode
	{
		Manual,
		GroupAverage
	}

	public enum UpdateMethod
	{
		Update,
		FixedUpdate,
		LateUpdate
	}

	public PositionMode m_PositionMode;

	public RotationMode m_RotationMode;

	public UpdateMethod m_UpdateMethod;

	public Target[] m_Targets;

	private Bounds _003CBoundingBox_003Ek__BackingField;

	private float mMaxWeight;

	private Vector3 mAveragePos;

	public Bounds BoundingBox
	{
		get
		{
			return _003CBoundingBox_003Ek__BackingField;
		}
		private set
		{
			_003CBoundingBox_003Ek__BackingField = value;
		}
	}

	public BoundingSphere Sphere => default(BoundingSphere);

	public bool IsEmpty => false;

	public int FindMember(Transform t)
	{
		return 0;
	}

	public BoundingSphere GetWeightedBoundsForMember(int index)
	{
		return default(BoundingSphere);
	}

	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
	{
		return default(Bounds);
	}

	private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight)
	{
		return default(BoundingSphere);
	}

	private void DoUpdate()
	{
	}

	private Vector3 CalculateAveragePosition(out float maxWeight)
	{
		maxWeight = default(float);
		return default(Vector3);
	}

	private Quaternion CalculateAverageOrientation()
	{
		return default(Quaternion);
	}

	private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight)
	{
		return default(Bounds);
	}

	private void OnValidate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange)
	{
		minAngles = default(Vector2);
		maxAngles = default(Vector2);
		zRange = default(Vector2);
	}
}
