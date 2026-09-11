using GCommon;

namespace COW;

public class UIBigEventFriendReunionInviteeController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public ulong inviter;

		internal bool _003COnClaimButtonClick_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIBigEventFriendReunionInviteeController _003C_003E4__this;

		public UIModelActivity modelActivity;

		internal void _003COnRequestAccountInfoFinish_003Eb__0()
		{
		}
	}

	private UIBigEventFriendReunionInviteeView m_View;

	private ActivityGroupDesc m_Data;

	private UIWidget m_ButtonWidget;

	private ulong m_RequestAccountId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetData(ActivityGroupDesc activityGroupDesc, string inviterUID, bool gained = false)
	{
	}

	private void OnInvitationInputGetFocus()
	{
	}

	private void OnInvitationInputLostFocus()
	{
	}

	private void OnInvitationInputChanged()
	{
	}

	private void OnClaimButtonClick()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void OnRewriteID(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
