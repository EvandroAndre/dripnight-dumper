using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudFloatingLandWaitController : UIBaseController
{
	private UIHudFloatingLandWaitView m_View;

	private Player m_localPlayer;

	private int m_endTime;

	private int m_leftTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnLeaveWaitFloatingLand(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
