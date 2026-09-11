using System;

namespace COW.Graphics;

[Serializable]
public sealed class IntParameter : ParameterOverride<int>
{
	public override void Interp(int from, int to, float t)
	{
	}
}
