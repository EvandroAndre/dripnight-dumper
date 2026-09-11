using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIHudReservationItemController : UIBaseController, UITable2.IUITable2Item
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ReserveReplyStatus status;

		public UIHudReservationItemController _003C_003E4__this;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public float expireTimeStamp;

		public UIHudReservationItemController _003C_003E4__this;

		internal void _003CSetMixGroupData_003Eb__0()
		{
		}
	}

	private UIHudReservationItemView m_View;

	private UIModelTeamReserve m_Model;

	private FriendAccountInfo m_Friend;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private string m_ReservationStr;

	private uint m_DelayCallExpired;

	private Vector3 m_DefaultRankScale;

	private bool m_IsMixGroup;

	private bool m_IsMixGroupInvite;

	private ulong m_MixGroupAccountId;

	private float m_MixGroupTotalTime;

	private float m_MixGroupStartTime;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitView()
	{
	}

	public void SetData(ulong id, ReserveReplyStatus status)
	{
	}

	public void SetMixGroupInviteData(ulong inviterId, MixGroupInviteStatus status)
	{
	}

	public void SetMixGroupJoinData(ulong requesterId, MixGroupJoinStatus status)
	{
	}

	private void SetMixGroupData(ulong accountId, bool isInvite, FriendAccountInfo friendInfo, string titleKey, string contentText, UIModelTeamReserve.EReserveReplyStatus replyStatus, float expireTimeStamp)
	{
	}

	private void OnAgreeBtnClick()
	{
	}

	private void OnRejectBtnClick()
	{
	}

	private void SetPlayerInfo(FriendAccountInfo friendInfo, bool showGroupNum = true)
	{
	}

	private void SetRankIcon(FriendAccountInfo friendInfo)
	{
	}

	private void SetGroupNum(FriendAccountInfo friendInfo)
	{
	}

	private void SetPlayerTag(FriendAccountInfo friendInfo)
	{
	}

	private string GetMixGroupInviteModeLabel(GroupInviteNtf inviteNtfData)
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
