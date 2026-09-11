using UnityEngine;
using message;

public class CSRoundDragonParams
{
	public Vector3 FocusAPos;

	public Vector3 FocusBPos;

	public float Radius;

	public float Height;

	public float SpeedStraight;

	public float SpeedArc;

	public float FocusDistance;

	public float ArcLength;

	public Vector2 Airline_X_VectorInWorld;

	public Vector2 Airline_Z_VectorInWorld;

	public float CurPhaseStartTime;

	public float CurPhaseDurationTime;

	public JAMMLGIBIEO CurPhase;

	public float CurPhaseRatio;

	public void SetParams(Vector3 focusA, Vector3 focusB, float radius, float height, float speedStraight, float speedArc)
	{
	}

	public void CalcRouteParam()
	{
	}

	public Vector3 GetWorldPositionByPhaseAndRatio(JAMMLGIBIEO phase, float ratio)
	{
		return default(Vector3);
	}
}
