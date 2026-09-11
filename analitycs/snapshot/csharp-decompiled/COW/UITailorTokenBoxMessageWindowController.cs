using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITailorTokenBoxMessageWindowController : UIPopupWindowController, IVoucher, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<TreasureBoxShowData, BaseItemInfo> _003C_003E9__35_0;

		internal BaseItemInfo _003CCreatShowList_003Eb__35_0(TreasureBoxShowData d)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public CSGetTreasureBoxPRRes res;

		public UITailorTokenBoxMessageWindowController _003C_003E4__this;

		internal void _003COnTokenBoxProbabilityBtnClick_003Eb__0()
		{
		}
	}

	protected UITailorTokenBoxMessageWindowView m_View;

	protected UICommonDiamondPurchaseBtnController m_BuyBtnCtrl;

	protected UIVoucherController m_VoucherCtrl;

	protected VoucherData m_VoucherData;

	protected List<CSSharedItemData> TemporaryData;

	protected uint m_MaxCount;

	protected uint m_Count;

	protected uint m_GemsPrice;

	protected uint m_CoinsPrice;

	protected bool m_CanShowModifyContainer;

	protected CSSharedItemData m_ItemData;

	protected bool m_IsOffer;

	protected bool m_IsQuickPurchase;

	protected bool m_InputExceedNotify;

	private EInventory.CurrencyType m_CurrencyType;

	protected List<TreasureBoxShowData> m_UniqueTreasureBoxData;

	private UIModelMall m_ModelMall;

	private uint m_TokenBoxItemID;

	protected StoreDesc TokenBoxItem;

	protected virtual uint ItemCount
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(TailorSettingDesc tailorSettingDesc, bool showVoucherContainer = false, bool isOffer = false, bool enableInput = false, int maxCount = 0, int defaultValue = 1, bool inputExceedNotify = false, bool isQuickPurchase = false, bool forceShowMaxBtn = false)
	{
	}

	protected void OnPlusBtnClick()
	{
	}

	private void OnAddTenBtnClick()
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnMaxBtnClick()
	{
	}

	private void OnTokenBoxProbabilityBtnClick()
	{
	}

	protected void RefreshModifyBtn(uint limited_purchase_times, bool forceMax = false)
	{
	}

	private void ShowTreasureBoxProbabilityTips(CSGetTreasureBoxPRRes probability)
	{
	}

	private void SetBuyBtnPrice()
	{
	}

	private void PurchaseTokenBox()
	{
	}

	private void CreatShowList()
	{
	}

	protected void ShowVoucherContainer()
	{
	}

	public UIVoucherController OpenVoucherController(Transform parent)
	{
		return null;
	}

	public UIVoucherItemController OpenVoucherItemController(Transform parent)
	{
		return null;
	}

	public void OnVoucherItemClick(object[] data)
	{
	}

	protected void RefreshVoucherCtrlTotalPrice()
	{
	}

	protected void SetMaxCount(uint maxCount)
	{
	}

	protected uint GetVoucherID()
	{
		return 0u;
	}

	protected void EnableInput(bool enable)
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void OnCountInputChanged()
	{
	}

	private void RefreshCountInput()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected void SetMaxCount(int maxCount)
	{
	}

	protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times)
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
