using GCommon;

namespace COW;

public class Skill2NBGPShadowTrait : UIHudCrosshairsAutoPathBombTrait
{
	protected override ResourceID GetIndicatorResID()
	{
		return default(ResourceID);
	}

	protected override EventID GetIndicatorEventID()
	{
		return EventID.APPLICATION_QUIT;
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetIndicatorResID()
	{
		return default(ResourceID);
	}

	public new EventID _003C_003EiFixBaseProxy_GetIndicatorEventID()
	{
		return EventID.APPLICATION_QUIT;
	}
}
