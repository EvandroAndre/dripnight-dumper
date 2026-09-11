using GCommon;

namespace COW;

internal class UIHudReceiveRewardController : UIBaseController
{
	private UIHudReceiveRewardView m_View;

	private ulong m_ReceiverPlayerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	public void OnObserverReward(object[] data)
	{
	}

	private void RefreshView(string friendName, uint rewardID, ulong sendRewardUserID)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
