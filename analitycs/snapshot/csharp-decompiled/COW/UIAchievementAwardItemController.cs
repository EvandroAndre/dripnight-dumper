using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIAchievementAwardItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIModelAchievement m_Model;

	private UIAchievementAwardItemView m_View;

	private AchievementConfigDesc m_ConfigDesc;

	private const int MAX_AWARD_ITEMS_COUNT = 3;

	private List<UIStandardItemMiniController> m_AwardItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnBtnClaimeClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
