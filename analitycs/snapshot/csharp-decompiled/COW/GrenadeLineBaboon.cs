using GCommon;

namespace COW;

public class GrenadeLineBaboon : GrenadeLine
{
	protected override ResourceID GetDefaultLineResID()
	{
		return default(ResourceID);
	}

	protected override void OnGrenadeCrosshairFireChange(object[] data)
	{
	}

	protected override void OnThrowSkillFireChange(object[] data)
	{
	}

	protected override void OnKickFootballLineChange(object[] data)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetDefaultLineResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnGrenadeCrosshairFireChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnThrowSkillFireChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnKickFootballLineChange(object[] P0)
	{
	}
}
