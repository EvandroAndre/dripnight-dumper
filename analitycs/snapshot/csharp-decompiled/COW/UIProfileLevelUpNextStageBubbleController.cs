using GCommon;
using proto;

namespace COW;

public class UIProfileLevelUpNextStageBubbleController : UIBaseController
{
	private UIProfileLevelUpNextStageBubbleView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private LevelRewardsDisplaysDesc m_Desc;

	private uint m_DelayCall;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(LevelRewardsDisplaysDesc desc)
	{
	}

	private void OnButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
