using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudQuickUseRepairKitController : UIBaseController
{
	private UIHudQuickUseRepairKitView m_View;

	private float m_StartTime;

	private float m_TotalTime;

	private int m_RepairKitCount;

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

	private void Update()
	{
	}

	private void OnBtnQuickUse()
	{
	}

	private void OnInventoryRepairKitChanged(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private bool CheckToShowUse(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void OnPlayerTryUseVehicleItem(object[] param)
	{
	}

	private void OnPlayerCancelUseVehicleItem(object[] param)
	{
	}

	private void OnVehicleHPChanged(object[] data)
	{
	}

	private void OnGetOnVehicle(object[] param)
	{
	}

	private void OnGetOffVehicle(object[] param)
	{
	}

	private void UpdateIconStatus(Player p)
	{
	}

	private void UpdateUrgencyEffect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
