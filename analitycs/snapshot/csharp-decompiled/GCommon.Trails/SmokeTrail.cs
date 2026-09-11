using UnityEngine;

namespace GCommon.Trails;

public class SmokeTrail : TrailRenderer_Base
{
	public Color MainColor;

	public float MinVertexDistance;

	public int MaxNumberOfPoints;

	private Vector3 m_LastPosition;

	private float m_DistanceMoved;

	public float RandomForceScale;

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	protected override void Reset()
	{
	}

	protected override void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	protected override Color GetMainColor()
	{
		return default(Color);
	}

	protected override int GetMaxNumberOfPoints()
	{
		return 0;
	}
}
