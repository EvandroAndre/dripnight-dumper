using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIAchievementDetailItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public AchievementEntryDesc entryDesc;

		internal bool _003CSetViewData_003Eb__0(AchievementLevelInfo levelInfo)
		{
			return false;
		}
	}

	private const uint NEW_PLAYER_EXPLORE_ACHIEVEMENT_ID = 32013u;

	private UIAchievementDetailItemView m_View;

	private List<UIStandardItemMiniController> m_AwardItemCtrlList;

	private const int MAX_AWARD_ITEMS_COUNT = 3;

	private AchievementEntryDesc m_EntryDesc;

	private UIModelAchievement m_Model;

	private bool m_IsFinal;

	private bool m_IsCurLevel;

	private bool m_IsNewCompletedAchievement;

	private GameObject m_GlowEffect;

	private uint m_UIFXType;

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

	public void SetViewData(AchievementEntryDesc entryDesc, AchievementEntryInfo entryInfo, bool isFinal, uint curLevel)
	{
	}

	private void RefreshNewPlayerExploreAchievementRewardItem()
	{
	}

	private void OnBtnDescClick()
	{
	}

	private void OnBtnAwardClick()
	{
	}

	public void PlayAnim()
	{
	}

	public void ShowArrow()
	{
	}

	private void SetScreenshotObjActive(object[] param)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
