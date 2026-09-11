using GCommon;

namespace COW;

public class UIHudUGCLobbyContainerController : UIBaseController
{
	private UIHudLobbyContainerView m_View;

	private UILobbyV2InviteGroupBoxController m_InviteGroupBox;

	private UIClickMask m_ClickMask;

	private UIBriefBoxController m_BriefBoxCtrl;

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

	protected override void OnUIOpen()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnClickClickMask()
	{
	}

	private void OnOpenBriefBox(object[] data)
	{
	}

	private void OpenInviteGroupBox(GroupInviteMemberType defaultInviteType = GroupInviteMemberType.Room)
	{
	}

	private void ShowContainer()
	{
	}

	private void HideContainer()
	{
	}

	private void SetControllerState(UIBaseController ctrl, bool state)
	{
	}

	public void SetState(bool state)
	{
	}

	private void _003COnUIOpen_003Eb__7_0()
	{
	}

	private void _003CShowContainer_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
