namespace COW.Graphics;

public class ACES : CustomEffectBase
{
	private enum Pass
	{
		Frag,
		FragLinear
	}

	public enum Type
	{
		ACES,
		Legacy
	}

	public override bool NeedCallRender()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedCallRender()
	{
		return false;
	}
}
