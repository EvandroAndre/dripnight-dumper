using UnityEngine;

namespace COW.Gameplay;

public class MyCinemachinePath
{
	public enum ECoordinate
	{
		Local,
		World
	}

	public enum EPathType
	{
		Linear,
		Smooth,
		Custom
	}

	public class Waypoint
	{
		public Vector3 position;

		public Vector3 tangent;

		public float roll;

		internal Vector4 AsVector4 => default(Vector4);

		internal static Waypoint FromVector4(Vector4 v)
		{
			return null;
		}
	}

	public enum PositionUnits
	{
		PathUnits,
		Distance,
		Normalized
	}

	private EPathType m_PathType;

	public Waypoint[] m_Waypoints;

	private int m_Resolution;

	public bool m_Looped;

	private Transform m_RootTrans;

	private Waypoint[] m_ControlPoints1;

	private Waypoint[] m_ControlPoints2;

	private bool m_IsLoopedCache;

	private float[] m_DistanceToPos;

	private float[] m_PosToDistance;

	private int m_CachedSampleSteps;

	private float m_PathLength;

	private float m_cachedPosStepSize;

	private float m_cachedDistanceStepSize;

	public EPathType PathType
	{
		get
		{
			return EPathType.Linear;
		}
		set
		{
		}
	}

	public int Resolution
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float MinPos => 0f;

	public float MaxPos => 0f;

	public bool Looped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform RootTrans
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int DistanceCacheSampleStepsPerSegment => 0;

	public float PathLength => 0f;

	private void UpdateControlPoints()
	{
	}

	public float StandardizePos(float pos)
	{
		return 0f;
	}

	public Vector3 EvaluatePosition(float pos)
	{
		return default(Vector3);
	}

	public Vector3 EvaluateTangent(float pos)
	{
		return default(Vector3);
	}

	public Quaternion EvaluateOrientation(float pos)
	{
		return default(Quaternion);
	}

	private float GetBoundingIndices(float pos, out int indexA, out int indexB)
	{
		indexA = default(int);
		indexB = default(int);
		return 0f;
	}

	public float MaxUnit(PositionUnits units)
	{
		return 0f;
	}

	public virtual float StandardizeUnit(float pos, PositionUnits units)
	{
		return 0f;
	}

	public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units)
	{
		return default(Vector3);
	}

	public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units)
	{
		return default(Quaternion);
	}

	public virtual void InvalidateDistanceCache()
	{
	}

	public bool DistanceCacheIsValid()
	{
		return false;
	}

	public float StandardizePathDistance(float distance)
	{
		return 0f;
	}

	public float ToNativePathUnits(float pos, PositionUnits units)
	{
		return 0f;
	}

	public float FromPathNativeUnits(float pos, PositionUnits units)
	{
		return 0f;
	}

	private void ResamplePath(int stepsPerSegment)
	{
	}

	public Vector3[] ComputeTangentsFromSmoothControlPoints()
	{
		return null;
	}
}
