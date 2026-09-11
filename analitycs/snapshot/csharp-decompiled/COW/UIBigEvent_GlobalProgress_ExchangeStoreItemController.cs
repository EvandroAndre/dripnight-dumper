using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBigEvent_GlobalProgress_ExchangeStoreItemController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	private enum EStoreItemState
	{
		NONE,
		NotEnoughToken,
		CanPurchase,
		NotInTime
	}

	private UIBigEvent_GlobalProgress_ExchangeStoreItemView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelInventory m_ModelInventory;

	private UIStandardItemMiniController m_ItemCtrl;

	private bool m_IsUniquedAndOwned;

	private bool m_SellOut;

	private CustomEventStoreCommodityDesc m_Data;

	private EStoreItemState m_StoreItemState;

	private EStoreTab m_StoreItemType;

	private Color m_NotPurchaseGray;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	private void SetCDNView()
	{
	}

	private void SetStoreItemState()
	{
	}

	private void SetStandardItemView()
	{
	}

	private void SetLimitedPurchaseView()
	{
	}

	private void SetPurchaseBtnState()
	{
	}

	private void SetCurrencyIcon()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void OnBtnLockClick()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void _003CSetCDNView_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
