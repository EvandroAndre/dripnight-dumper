using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIAchievementPopupWindowController : UIPopupWindowController
{
	private UIAchievementPopupWindowView m_View;

	private UIAchievementDetailController m_DetailCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint curAchievementId, List<uint> sortedIds, List<AchievementEntryInfo> sortedInfos, EAchievement.Type curType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
