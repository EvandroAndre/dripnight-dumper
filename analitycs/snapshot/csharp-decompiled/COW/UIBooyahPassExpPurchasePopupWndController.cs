using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBooyahPassExpPurchasePopupWndController : UIPopupWindowController, IVoucher, IUIModelDataChangeObserver
{
	private class RewardEasyListImpl : IEasyList
	{
		private readonly UIBooyahPassExpPurchasePopupWndController m_ParentCtrl;

		public RewardEasyListImpl(UIBooyahPassExpPurchasePopupWndController parentCtrl)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private const string PERCENT_OFF_FORMAT_STRING = "-{0}%";

	private const string POPUP_WND_TITLE = "ExpPurchasePopupWnd";

	private const string LEVEL_PURCHASE_CONFIRM_POPUP_TITLE = "LevelPurchaseConfirmPopupWnd";

	private const string LEVEL_PACKAGE_PURCHASE_CONFIRM_POPUP_TITLE = "LevelPackagePurchaseConfirmPopupWnd";

	private const uint LEVEL_TO_PURCHASE_MIN = 1u;

	private const uint LEVEL_TO_PURCHASE_MAX = 299u;

	private uint m_LevelToPurchase;

	private uint m_LevelPurchaseFinalPrice;

	private uint m_LevelPackagePurchaseFinalPrice;

	private int m_DefaultRewardEasyListColumn;

	private StoreDesc m_LevelPackageStoreDesc;

	private VoucherData m_SelectedVoucherData;

	private UIBooyahPassExpPurchasePopupWndView m_View;

	private UIMallVoucherController m_LevelPackageVoucherCtrl;

	private UICountDownController m_LevelPackageCountdownCtrl;

	private readonly List<BaseItemInfo> m_TmpRewardItemInfoList;

	private readonly List<BooyahPassBaseItemData> m_TmpBooyahPassBaseItemList;

	private bool IsLevelPackageAvailable => false;

	private bool IsLevelPackagePurchaseLimited => false;

	private uint LevelToPurchase
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIVoucherController OpenVoucherController(Transform parent)
	{
		return null;
	}

	public void OnVoucherItemClick(object[] data)
	{
	}

	public UIVoucherItemController OpenVoucherItemController(Transform parent)
	{
		return null;
	}

	private void PrepareLayout()
	{
	}

	private void PrepareCommonDiamondPurchaseButtons()
	{
	}

	private void PrepareCountdownLabel()
	{
	}

	private void PrepareVoucherCtrl()
	{
	}

	private void PrepareEasyList()
	{
	}

	private void PrepareCDN()
	{
	}

	private void RefreshStepper()
	{
	}

	private void RefreshRewardEasyListAndRewardCount()
	{
	}

	private void RefreshLevelPackageRewardEasyListAndRewardCount()
	{
	}

	private void RefreshLevelPurchaseButton()
	{
	}

	private void RefreshLevelPackageTitle()
	{
	}

	private void RefreshLevelPackageLimitLabel()
	{
	}

	private void RefreshLevelPackagePurchaseButton(VoucherData voucherData = null)
	{
	}

	private void RefreshVoucherCtrl()
	{
	}

	private void RefreshLevelPurchaseContent()
	{
	}

	private void RefreshLevelPackagePurchaseContent()
	{
	}

	private static uint GetDiscountPercentage(uint originalPrice, uint discountPrice)
	{
		return 0u;
	}

	private void SetLevelPurchaseBtnEnable(bool enable)
	{
	}

	private void SetLevelPackagePurchaseBtnEnable(bool enable)
	{
	}

	private void SetLevelPurchasePrice(uint originalPrice, uint discountPrice)
	{
	}

	private void SetLevelPackagePurchasePrice(uint originalPrice, uint discountPrice)
	{
	}

	private void OnLevelToPurchaseChanged()
	{
	}

	private void PrepareLevelPackageStoreDesc()
	{
	}

	private uint GetLevelPackageLevelBonus()
	{
		return 0u;
	}

	private void OnLevelPurchasePopupConfirmBtnClick()
	{
	}

	private void OnLevelPackagePopupConfirmBtnClick()
	{
	}

	private void OnLevelPurchaseBtnClick()
	{
	}

	private void OnLevelPackagePurchaseBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnLevelPurchaseConfirmCloseBtnClick()
	{
	}

	private void OnLevelPackagePurchaseConfirmCloseBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	public void SetLevelToPurchase(uint levelToPurchase)
	{
	}

	private void _003CAddEventDelegate_003Eb__64_0()
	{
	}

	private void _003CAddEventDelegate_003Eb__64_1()
	{
	}

	private void _003CAddEventDelegate_003Eb__64_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
