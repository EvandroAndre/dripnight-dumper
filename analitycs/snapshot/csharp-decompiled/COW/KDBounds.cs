using UnityEngine;

namespace COW;

public struct KDBounds
{
	public Vector3 min;

	public Vector3 max;

	public Vector3 size => default(Vector3);

	public Bounds Bounds => default(Bounds);

	public Vector3 ClosestPoint(Vector3 point)
	{
		return default(Vector3);
	}
}
