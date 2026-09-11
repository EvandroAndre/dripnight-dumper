using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWeaponSkinUpgraderRewardWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public uint skinId;

		internal void _003CAutoClose_003Eb__0()
		{
		}
	}

	private UIWeaponSkinUpgraderRewardWndView m_View;

	private WeaponSkinData m_WeaponSkinData;

	private List<int> m_Features;

	private List<uint> m_RewardItemIds;

	private int m_CurRewardIdx;

	private uint m_AutoCloseDC;

	private bool m_HasABNotReadyItem;

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

	protected override void OnUIOpen()
	{
	}

	public void SetRewardsData(WeaponSkinData data, List<int> features, List<uint> itemIds)
	{
	}

	private void ShowRewardsView()
	{
	}

	private void ShowRewardFeatureView(WeaponSkinFeature feature)
	{
	}

	private void SetUIVisible(bool flag)
	{
	}

	private void OnCommonEquipResult(object[] data)
	{
	}

	private void OnEquipSuccess(bool isTipShow = true)
	{
	}

	private void OnEquipFail()
	{
	}

	private void AutoClose(bool showTip = false, bool equipSuccess = true)
	{
	}

	private void CheckFastEquip()
	{
	}

	private bool CheckItemABReady(uint itemID)
	{
		return false;
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void _003CShowRewardFeatureView_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
