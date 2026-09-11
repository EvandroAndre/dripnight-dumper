using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

public class UIHippoCrisisMarketPurchaseController : UIPopupWindowController
{
	private UIHippoCrisisMarketPurchaseView m_View;

	private HippoCrisisStoreItemData m_StoreItemData;

	private HENEHAGJCLI m_ItemData;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private bool m_CanMatPurchageSuccess;

	private bool m_IsStack;

	private uint m_PurchaseCnt;

	private uint m_MaxCanPurchaseCnt;

	private const uint MaxDefaultPurchaseCnt = 10000u;

	private uint m_NumPlusNum;

	private EHippoCrisisPurchaseMethod m_PurchaseMethod;

	private bool m_EquipImmediately;

	private EHippoInventory.EquipType m_PurchaseDest;

	private uint m_PurchaseToSlot;

	private uint m_OperationType;

	private uint m_AttachmentPurchaseToSlot;

	private ulong m_TargetSlotUniqueId;

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

	private void OnExchangeBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnMoneyPurchaseBtnClick()
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnNumPlusBtnClick()
	{
	}

	private void OnSliderValueChange()
	{
	}

	private void SetModifyBtnView()
	{
	}

	private void SetMinBtnView()
	{
	}

	private void SetPlusBtnView()
	{
	}

	private void CalculateMaxAndMinCnt(uint price, uint weight)
	{
	}

	public void SetMarketPurchaseView(HippoCrisisStoreItemData storeData, bool needEquipImmediately = false, EHippoInventory.EquipType purchaseDest = EHippoInventory.EquipType.EquipTypeWarehouse, uint purchaseDestSlot = 0u, uint operationType = 0u, ulong targetSlotUniqueId = 0uL, uint attachmentDestSlot = 0u)
	{
	}

	private void EnableInputCnt()
	{
	}

	private void RefreshCountInput()
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void OnCountInputChanged()
	{
	}

	private void SetMoneyUseView()
	{
	}

	private void SetMaterialExchangeView()
	{
	}

	private void RequestPurchase()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
