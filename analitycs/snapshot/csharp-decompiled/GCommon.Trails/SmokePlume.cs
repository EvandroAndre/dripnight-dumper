using UnityEngine;

namespace GCommon.Trails;

public class SmokePlume : TrailRenderer_Base
{
	public float TimeBetweenPoints;

	public Color MainColor;

	public Vector3 ConstantForce;

	public Vector3 RandomForceScale;

	public int MaxNumberOfPoints;

	private float m_TimeSincePoint;

	protected override void Start()
	{
	}

	protected override void Reset()
	{
	}

	protected override void Update()
	{
	}

	protected override void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	protected override void UpdateTrail(PCTrail trail, float deltaTime)
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
