using System;
using COW.Graphics;

[Serializable]
public class BlackWhiteOverrideSettings
{
	public BoolParameter BlackWhiteEnable;

	public BoolParameter tint;

	public FloatParameter maxInput;

	public FloatParameter minInput;

	public void DisableAllOverride()
	{
	}
}
