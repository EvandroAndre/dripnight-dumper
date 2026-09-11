using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class BezierSegment
{
	protected Vector2 p0;

	protected Vector2 c1;

	protected Vector2 c2;

	protected Vector2 p3;

	protected int sampleCount;

	public Vector2 StartPoint => default(Vector2);

	public Vector2 EndPoint => default(Vector2);

	public BezierSegment()
	{
	}

	public BezierSegment(Vector2 p0, Vector2 c1, Vector2 c2, Vector2 p3)
	{
	}

	public bool CheckInSegment(float time)
	{
		return false;
	}

	public virtual void PreSample(float totalDistance, List<Vector2> vertices)
	{
	}

	public virtual float CalculateBezierPoint(float x)
	{
		return 0f;
	}

	private Vector2 CalculateBezierPoint(float t, Vector2 P0, Vector2 C1, Vector2 C2, Vector2 P3)
	{
		return default(Vector2);
	}
}
