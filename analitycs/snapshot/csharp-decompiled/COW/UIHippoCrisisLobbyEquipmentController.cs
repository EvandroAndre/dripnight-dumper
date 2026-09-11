using GCommon;

namespace COW;

public class UIHippoCrisisLobbyEquipmentController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHippoCrisisLobbyEquipmentView m_View;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIHippoCrisisLobbyEquipmentWeaponSlotItemController m_MainWeapon1Ctrl;

	private UIHippoCrisisLobbyEquipmentWeaponSlotItemController m_MainWeapon2Ctrl;

	private UIHippoCrisisLobbyEquipmentWeaponSlotSmallItemController m_MelleWeaponCtrl;

	private UIHippoCrisisLobbyEquipmentWeaponSlotSmallItemController m_SecondaryWeaponCtrl;

	private UIHippoCrisisLobbyEquipmentSlotItemController m_HelmentCtrl;

	private UIHippoCrisisLobbyEquipmentSlotItemController m_VestCtrl;

	private UIHippoCrisisLobbyEquipmentSlotItemController m_BagCtrl;

	private UIHippoCrisisLobbyEquipmentSlotItemController m_CamouflageCtrl;

	private uint m_TotleValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshMainWeapon1()
	{
	}

	private void RefreshMainWeapon2()
	{
	}

	private void RefreshMelleWeapon()
	{
	}

	private void RefreshSecondaryWeapon()
	{
	}

	private void RefreshVest()
	{
	}

	private void RefreshHelmet()
	{
	}

	private void RefreshBag()
	{
	}

	private void RefreshCamouflage()
	{
	}

	private void OnMainBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
