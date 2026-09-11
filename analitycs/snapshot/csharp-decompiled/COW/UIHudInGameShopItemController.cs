using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInGameShopItemController : UIBaseController
{
	public const float TIME_LIMIT_RED_TIME = 30f;

	private UIHudInGameShopItemViewExt m_View;

	private BGMFPPDLCBB m_ItemInfo;

	private bool m_Selected;

	public UIHudInGameShopItemViewExt view => null;

	protected bool UseCoin => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspended()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	public int GetSortOrder()
	{
		return 0;
	}

	private void OnItemBtnClick()
	{
	}

	public void SetUIData(BGMFPPDLCBB data)
	{
	}

	public void RefreshUIData(BGMFPPDLCBB data)
	{
	}

	private void OnItemPress(GameObject go, bool pressed)
	{
	}

	private void OnItemClick(GameObject go)
	{
	}

	private void ShowDetail(GameObject go)
	{
	}

	private void OnClearSelectedItem(object[] data)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void SetSelected(bool v)
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private void UpdateActivityItemIconShowState()
	{
	}

	private void OnBagCapacityLeftChanged(object[] data)
	{
	}

	private void OnGlobalAvailableNumChanged(object[] data)
	{
	}

	private void OnRefreshShopAvaiable(object[] data)
	{
	}

	private void OnPersonalBoughtCountChanged(object[] data)
	{
	}

	private void OnShopHudInited(object[] data)
	{
	}

	private void OnBattleStylePlayerLevelChange(uint data)
	{
	}

	private void OnBattleStyleAbilityLevelChange()
	{
	}

	private void UpdateLimitationLabelByGlobalLimit(int available)
	{
	}

	private void UpdateLimitationLabelByPersonalLimit(int haveBoughtCount, int totalLimit)
	{
	}

	private void UpdateTimeLimit(int lastTime)
	{
	}

	private void TimeLimitEnd()
	{
	}

	private void OnPOIMissionStateChanged(uint poimissionId)
	{
	}

	private void CheckMissionCardState()
	{
	}

	private void OnRefreshNewTag(uint itemID)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspended()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
