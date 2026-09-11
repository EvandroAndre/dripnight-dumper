using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public static class TransformUtils
{
	public static Bounds CaculateTargetBounds(List<Transform> targetTransformList)
	{
		return default(Bounds);
	}

	public static void GetBoundsAll(Transform transform, ref Bounds currentTotalBounds)
	{
	}

	public static float CaculateOrthographicSize(Bounds targetBounds, float aspectRatio, Matrix4x4 worldToCamera, Vector2Int index)
	{
		return 0f;
	}

	public static Vector3 CalculateAverageTransformPosition(List<Transform> transforms)
	{
		return default(Vector3);
	}
}
