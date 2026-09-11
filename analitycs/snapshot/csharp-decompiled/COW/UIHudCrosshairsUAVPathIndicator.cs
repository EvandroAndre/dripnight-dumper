using GCommon;

namespace COW;

public class UIHudCrosshairsUAVPathIndicator : UIHudCrosshairsPathIndicatorBase
{
	protected override ResourceID GetIndicatorResID()
	{
		return default(ResourceID);
	}

	protected override EventID GetIndicatorEventID()
	{
		return EventID.APPLICATION_QUIT;
	}

	protected override void CalVFXRotate()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetIndicatorResID()
	{
		return default(ResourceID);
	}

	public EventID _003C_003EiFixBaseProxy_GetIndicatorEventID()
	{
		return EventID.APPLICATION_QUIT;
	}

	public void _003C_003EiFixBaseProxy_CalVFXRotate()
	{
	}
}
