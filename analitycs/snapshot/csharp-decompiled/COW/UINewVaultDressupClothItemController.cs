using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewVaultDressupClothItemController : UIEasyListItemController
{
	protected UIStandardItemMAXBController m_standardItemCtrl;

	protected UIStandardItemMAXBItemTagController m_standardItemTagCtrl;

	protected UINewVaultCommonItemView m_View;

	protected UINewVaultItemViewData m_data;

	private UIModelAvatar m_ModelAvatar;

	private UIModelDressUp m_ModelDressUp;

	private UIModelInventory m_ModelInventory;

	private InventoryClothInfo m_curClothInfo;

	private InventoryClothSeriesInfo m_curClothSeriesInfo;

	private Item m_curProtoItem;

	private CSSharedItemData m_curCSSharedItemData;

	private bool m_IsItemABReady;

	private bool m_IsInvalid;

	private bool m_IsInvalidForAvatar;

	private bool m_SkipClothesForAvatar;

	private uint m_UseRankLevel;

	private bool m_IsReachUseRankLevel;

	private GameObject m_FistGetEffect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void ClearContent()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnRefreshDownload(object[] data)
	{
	}

	private void RefreshStateSprite()
	{
	}

	private void OnRefreshCollection(object[] data)
	{
	}

	private void ShowNotReachRankUseLevelTips(int rank)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshUI()
	{
	}

	private void HideIconAndBG()
	{
	}

	public void RefreshEquipState()
	{
	}

	private void CheckClothIsInvalid(InventoryClothInfo data)
	{
	}

	private void OnSeriesItemChangeIndex(object[] data)
	{
	}

	public void SetFirstGetEffectActive(bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
