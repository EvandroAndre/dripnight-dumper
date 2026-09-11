using GCommon;

namespace COW;

public class UIRushingPetsRoomSettingCtrl : UIRushingPetsCreateRoom
{
	private ulong m_RoomID;

	private UIModelCustomRoom m_Model;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	protected override void InitDefaultParams()
	{
	}

	protected override bool NeedCheckRoomCard()
	{
		return false;
	}

	protected override void ProcessConfirmRoomInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitDefaultParams()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCheckRoomCard()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ProcessConfirmRoomInfo()
	{
	}
}
