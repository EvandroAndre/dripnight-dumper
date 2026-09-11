using System;

namespace COW.Graphics;

[Serializable]
public sealed class FloatParameter : ParameterOverride<float>
{
	public override void Interp(float from, float to, float t)
	{
	}
}
