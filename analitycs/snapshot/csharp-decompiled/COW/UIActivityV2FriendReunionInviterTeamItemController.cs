using System;
using GCommon;

namespace COW;

internal class UIActivityV2FriendReunionInviterTeamItemController : UIEasyListItemController
{
	public enum EFriendStatusType
	{
		None,
		CanInvite,
		CanJoinGroup,
		CanInviteAndJoin
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__24_1;

		public static Action _003C_003E9__24_3;

		internal void _003CClickJoinInGroup_003Eb__24_1()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__24_3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIModelCustomRoom modelRoom;

		public UIActivityV2FriendReunionInviterTeamItemController _003C_003E4__this;

		internal void _003CClickJoinInGroup_003Eb__0()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__2()
		{
		}
	}

	private UIActivityV2FriendReunionInviterTeamItemView m_View;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriendReunion m_ModelFriendReunion;

	private UIModelFriends m_ModelFriends;

	private UIModelGroup m_ModelGroup;

	private CallBackFriendData m_Data;

	private bool m_IsCoolingDown;

	private float m_InviteTime;

	private bool m_InviteSuccess;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUIView()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void ChangeBGToBigType()
	{
	}

	private void RefreshRightView()
	{
	}

	private bool IsInviteConShow()
	{
		return false;
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnBtnInviteClick()
	{
	}

	private void OnBtnMessageClick()
	{
	}

	private void ClickJoinInGroup()
	{
	}

	private void ClickInviteFriend()
	{
	}

	private bool CheckCanInviteOrJoin()
	{
		return false;
	}

	private void InitCreateGroupToInviteData()
	{
	}

	private void InviteFriend()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
