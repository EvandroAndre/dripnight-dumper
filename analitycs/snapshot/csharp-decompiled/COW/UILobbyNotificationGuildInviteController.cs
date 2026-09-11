using GCommon;
using tcp;

namespace COW;

public class UILobbyNotificationGuildInviteController : UILobbyNotificationPopUpContentBaseController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UISecondConfirmContoller ctrl;

		public UILobbyNotificationGuildInviteController _003C_003E4__this;

		public ulong inviterId;

		public ulong clanId;

		internal void _003COnInteractionBtnClick_003Eb__0()
		{
		}
	}

	private UILobbyNotificationGuildInviteView m_View;

	private InviteToClanReq m_InviteToClanReq;

	private UIModelClan m_ModelClan;

	private bool m_NeedAddDataToAssist;

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override UIButton InitInteractionButton()
	{
		return null;
	}

	protected override void OnInteractionBtnClick()
	{
	}

	public override void OnOutAnimFinished()
	{
	}

	protected override void OnReset()
	{
	}

	protected override void OnSetViewData(object data)
	{
	}

	private void OnSetViewData(InviteToClanReq data)
	{
	}

	private void _003COnSetViewData_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOutAnimFinished()
	{
	}
}
