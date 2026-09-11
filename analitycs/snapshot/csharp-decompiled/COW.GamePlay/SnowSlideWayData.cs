using System;

namespace COW.GamePlay;

[Serializable]
public class SnowSlideWayData
{
	public double VSpeedRatio;

	public double RisingGravity;

	public double FallingGravity;

	public uint CfgId;

	public double SnowSlideRunSpeedScale;

	public double SnowSlideDashSpeedScale;

	public double SnowSlideWaySpeedScale;
}
