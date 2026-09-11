using UnityEngine;

namespace RuntimeGizmos;

public struct AxisInfo
{
	public Vector3 Pivot;

	public Vector3 DirectionX;

	public Vector3 DirectionY;

	public Vector3 DirectionZ;

	public void Set(Transform target, Vector3 pivot, TransformSpace space)
	{
	}

	public Vector3 GetXAxisEnd(float size)
	{
		return default(Vector3);
	}

	public Vector3 GetYAxisEnd(float size)
	{
		return default(Vector3);
	}

	public Vector3 GetZAxisEnd(float size)
	{
		return default(Vector3);
	}

	public Vector3 GetAxisEnd(Vector3 direction, float size)
	{
		return default(Vector3);
	}
}
