using GCommon;

namespace COW;

internal class UIWereWolvesRoomSetting : UIHUDWereWolvesCreateRoom
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

	protected override void InitDefaultParams()
	{
	}

	protected override void OnLanguageBtnClick()
	{
	}

	protected override void InitPlayerCountUIComponent()
	{
	}

	protected override void InitLanguageUIComponent()
	{
	}

	protected override bool NeedCheckRoomCard()
	{
		return false;
	}

	protected override void ProcessConfirmRoomInfo()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitDefaultParams()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLanguageBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_InitPlayerCountUIComponent()
	{
	}

	public void _003C_003EiFixBaseProxy_InitLanguageUIComponent()
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
