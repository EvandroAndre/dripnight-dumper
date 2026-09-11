using GCommon;
using proto;

namespace COW;

public class UIProfileLevelUpRewardPreviewItemController : UIEasyListItemController
{
	private UIProfileLevelUpRewardPreviewItemView m_View;

	private LevelRewardsDisplaysDesc m_Desc;

	private UIStandardItemMiniController m_ItemCtrl;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
