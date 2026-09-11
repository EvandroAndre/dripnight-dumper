using GCommon;
using UnityEngine;

namespace COW;

public class UIMallPurchaseBaseController : UIPopupWindowController, IVoucher
{
	protected CSSharedItemData m_ItemData;

	protected int m_Count;

	protected int m_MaxCount;

	protected int m_MaxStoreCount;

	protected VoucherData m_VoucherData;

	protected UIVoucherController m_VoucherCtrl;

	protected UIModelMall m_ModelMall;

	protected UIMallPurchaseViewExt m_View;

	protected uint m_CoinsPrice;

	protected uint m_GemsPrice;

	protected uint m_UGCTokenPrice;

	protected double m_IAPPurchasePrice;

	protected bool m_InputExceedNotify;

	private bool m_CanShowModifyContainer;

	protected bool m_ShowSpecialConfirmCon;

	protected bool m_ShowSpecialConfirmUGCTokenCon;

	protected bool m_CanOverflow;

	protected UIStandardItemMAXBController m_StandItem;

	protected virtual int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected void SetPriceLabelText()
	{
	}

	protected void RefreshVoucherCtrlTotalPrice()
	{
	}

	protected uint GetVoucherID()
	{
		return 0u;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnPlusBtnClick()
	{
	}

	protected void OnMinsBtnClick()
	{
	}

	protected void OnMaxBtnClick()
	{
	}

	protected void SetMaxCount(int maxCount, int maxSotreCount = 0)
	{
	}

	protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times, int affordNum = int.MaxValue)
	{
	}

	protected void ShowLimitedPurchase(uint limited_purchase_times, uint purchase_times)
	{
	}

	protected void ShowModifyCountContainer()
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

	protected bool CheckSpecialConfirmCon()
	{
		return false;
	}

	protected void SetSpecialConfirmCon()
	{
	}

	protected void RefreshSpecialConfirmCon()
	{
	}

	private void SetBeforeVoucherLabel()
	{
	}

	private void ShowVoucherEffect()
	{
	}

	protected void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	protected bool CanShowModifyCountContainer(uint awardTime, uint limited_purchase_times)
	{
		return false;
	}

	protected void EnableInput(bool enable)
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void RefreshCountInput()
	{
	}

	private void OnCountInputChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
