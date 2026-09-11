using UnityEngine;

namespace Cinemachine.Utility;

public static class UnityVectorExtensions
{
	public const float Epsilon = 0.0001f;

	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1)
	{
		return 0f;
	}

	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1)
	{
		return 0f;
	}

	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal)
	{
		return default(Vector3);
	}

	public static Vector3 Abs(Vector3 v)
	{
		return default(Vector3);
	}

	public static bool AlmostZero(Vector3 v)
	{
		return false;
	}

	public static float Angle(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up)
	{
		return 0f;
	}
}
