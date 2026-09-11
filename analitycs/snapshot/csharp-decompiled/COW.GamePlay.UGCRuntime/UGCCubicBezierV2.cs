using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCCubicBezierV2 : IUGCTweenCurve
{
	private class CurveKeyFrame
	{
		public const int FILED_COUNT = 7;

		public float time;

		public float value;

		public float inTangent;

		public float outTangent;

		public int weightedMode;

		public float inWeight;

		public float outWeight;
	}

	public const int SAMPLE_RESOLUTION = 100;

	public const float WEIGHTED_INV_RATIO = 3f;

	public const float WEIGHTED_RATIO = 1f / 3f;

	private List<float> m_floats;

	private List<Vector2> m_clips;

	public float Sample(float x)
	{
		return 0f;
	}

	private float CalculateSample(float x)
	{
		return 0f;
	}

	private float SampleFromCache(float x)
	{
		return 0f;
	}

	public void Clear()
	{
	}

	public void AddPoint(float value)
	{
	}

	private List<BezierSegment> BuildSegments(ref float distance)
	{
		return null;
	}

	public void PreSample()
	{
	}

	private List<BezierSegment> GetAnchorAndControlPoints(List<CurveKeyFrame> keyFrames, ref float distance)
	{
		return null;
	}

	public Vector2 GetTangLength(Vector2 p1, Vector2 p2)
	{
		return default(Vector2);
	}

	public void GetControlPoints(Vector2 p1, Vector2 p2, float tangOut, float tangIn, out Vector2 c1, out Vector2 c2, float tangWeightOut = 1f / 3f, float tangWeightIn = 1f / 3f)
	{
		c1 = default(Vector2);
		c2 = default(Vector2);
	}
}
