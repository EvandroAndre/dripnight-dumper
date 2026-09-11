using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class MinusInfinityBezierSegment : BezierSegment
{
	public MinusInfinityBezierSegment(Vector2 p0, Vector2 c1, Vector2 c2, Vector2 p3)
	{
	}

	public override float CalculateBezierPoint(float t)
	{
		return 0f;
	}

	public override void PreSample(float duration, List<Vector2> vertices)
	{
	}

	public float _003C_003EiFixBaseProxy_CalculateBezierPoint(float P0)
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_PreSample(float P0, List<Vector2> P1)
	{
	}
}
