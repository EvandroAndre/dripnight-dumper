using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCCreatorLevelProfileController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__21_0;

		internal void _003COnHelpBtnClick_003Eb__21_0()
		{
		}
	}

	private UIUGCCreatorLevelProfileView m_View;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private UIModelProfile m_ModelProfile;

	private UIModelSceneEdit m_ModelSceneEdit;

	private readonly List<UIUGCCreatorLevelProfileItemController> m_LevelItemList;

	private readonly List<UIUGCCreatorLevelProfileAbilityItemController> m_AbilityItemList;

	private readonly List<UIUGCCreatorLevelProfileAbilityItemController> m_PlatformItemList;

	private uint m_CurrentLevel;

	private uint m_SelectedLevel;

	private UIClickMask m_ClickMask;

	private CraftlandCreatorStats m_DisplayCreatorStats;

	private bool m_IsSelfCreatorData;

	private bool m_IsWaitingCreatorDataByAccountId;

	private ulong m_WaitingCreatorAccountId;

	private UIUGCCreatorLevelIconController m_CreatorLevelIconCtrl;

	private UIStandardItemMiniController m_ItemCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void RefreshBGCDN()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnExpHelpBtnClick()
	{
	}

	private void OnSettingClick()
	{
	}

	private void OnSetNameOffClick()
	{
	}

	private void RefreshLevelTable(WorkShopCreatorLevel workShopCreatorLevel, bool refresh = false)
	{
	}

	private void RefreshRewardRedPoints()
	{
	}

	private void RefreshRewardItem(WorkShopCreatorLevel workShopCreatorLevel)
	{
	}

	private void RefreshAbilityGrid()
	{
	}

	private void RefreshPlatformGrid()
	{
	}

	private void RefreshLevelState()
	{
	}

	private void RefreshLevelDisplay()
	{
	}

	private void OnLevelItemClick(uint level)
	{
	}

	private void RefreshNameToggle()
	{
	}

	private void SetDisplayCreatorData(CraftlandCreatorStats creatorStats, bool isSelfCreatorData)
	{
	}

	public void RequestAndShowCreatorDataByAccountId(ulong accountId)
	{
	}

	private void ApplyDisplayIdentityState()
	{
	}

	private WorkShopCreatorLevel GetDisplayCurrentWorkshopCreatorInfo()
	{
		return null;
	}

	private uint GetDisplayCurrentLevel()
	{
		return 0u;
	}

	private bool IsDisplayLevelUnlock(uint level)
	{
		return false;
	}

	private long GetDisplayLevelUnlockTime(uint level)
	{
		return 0L;
	}

	private bool IsDisplayAwardedLevel(uint level)
	{
		return false;
	}

	private bool CanDisplayClaimAwardedLevel(uint level)
	{
		return false;
	}

	private int ComparePrivilegeWeight(WorkshopCreatorPrivilegeWarp a, WorkshopCreatorPrivilegeWarp b)
	{
		return 0;
	}

	private void DisposeLevelItemCache()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshRewardItem_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
