using GCommon;
using proto;

namespace COW;

public class UIHippoCrisisInventoryUpgradePopController : UIPopupWindowController
{
	private UIHippoCrisisInventoryUpgradePopView m_View;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private bool m_CanUpgradeByMaterial;

	private bool m_CanUpgradeByMoney;

	private uint m_NextSafeBoxId;

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

	public void SetViewData(HippoWarehouseLevelDesc nextLevelInfo)
	{
	}

	public void SetSafeBoxData(uint currentSafeBoxCap, uint nextSafeBoxCap, uint nextSafeBoxId)
	{
	}

	private void SafeBoxUpgradClick()
	{
	}

	private void OnUpgradeBtnClick()
	{
	}

	private void OnMoneyUpgradeClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
