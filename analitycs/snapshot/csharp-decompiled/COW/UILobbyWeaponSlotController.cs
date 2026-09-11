using GCommon;

namespace COW;

public class UILobbyWeaponSlotController : UIBaseController, IUIModelDataChangeObserver
{
	private int m_Slot;

	private UILobbyWeaponSlotView m_view;

	private WeaponSkinBaseInfo m_ItemData;

	private UIModelWeaponRack m_Data;

	private bool m_IsDragOver;

	private const string CLOSEKEY = "HDWeaponSlot";

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

	public void SetViewData(int slot, uint weaponID)
	{
	}

	public void SendCreateEvent(WeaponSkinBaseInfo info)
	{
	}

	public void OnDragOver()
	{
	}

	public void OnDragOut()
	{
	}

	private void SetCloneObject()
	{
	}

	public bool HasWeaponInSlot()
	{
		return false;
	}

	public void OnClickDeleteButton()
	{
	}

	private void OnClickSlotButton()
	{
	}

	private void OnSlotButtonClicked(object[] data)
	{
	}

	private void OnRemoveDeleteButton(object[] data)
	{
	}

	public void OnApplicationPause(bool pauseState)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
