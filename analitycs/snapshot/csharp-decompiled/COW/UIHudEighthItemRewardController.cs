using GCommon;

namespace COW;

public class UIHudEighthItemRewardController : UIBaseController
{
	public const uint VISIBILITY_STATE_KillCam_Hide = 1073741824u;

	public const uint VISIBILITY_STATE_Hide_All = 536870912u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 268435456u;

	private UIHudEighthItemRewardView m_View;

	private uint m_Id;

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

	public void SetShowData(bool isWin, uint id)
	{
	}

	private void RefreshItemView()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
