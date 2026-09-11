using System;

namespace COW.GamePlay;

[Serializable]
public class HorseParam
{
	public float MaxRunSpeed;

	public float StartRunSpeed;

	public float LandFinishTime;

	public float BrakeBanInputTime;

	public float BrakeTime;

	public float JumpStartTime;

	public float JumpGravityScale;

	public float JumpVerticalSpeedThreshold;

	public float LandDistanceThreshold;

	public float LandDistanceThreshold3P;
}
