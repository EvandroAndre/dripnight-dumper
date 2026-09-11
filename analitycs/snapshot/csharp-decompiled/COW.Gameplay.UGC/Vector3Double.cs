using UnityEngine;

namespace COW.Gameplay.UGC;

public class Vector3Double
{
	public double x;

	public double y;

	public double z;

	public static implicit operator Vector3(Vector3Double v)
	{
		return default(Vector3);
	}
}
