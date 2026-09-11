using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIActivityV2FriendReunionInviteeController : UIActivityContentController, IUIModelDataChangeObserver
{
	private enum TableSortType
	{
		None,
		RecallTitle,
		RecallItem,
		RewardTitle,
		RewardItem
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__17_0;

		internal void _003CSetRewardTitle_003Eb__17_0()
		{
		}
	}

	private UIActivityV2FriendReunionInviteeView m_View;

	private UIModelFriendReunion m_ModelFriendReunion;

	private UIModelFriends m_ModelFriends;

	private List<UIActivityV2FriendReunionInviteeMissionController> m_V2FriendReunionInviteeMissionControllers;

	private UIActivityV2FriendReunionTitleController m_RecallTitle;

	private UIActivityV2FriendReunionTitleController m_RewardTitle;

	private List<UIActivityV2FriendReunionInviteeRecallItemController> m_V2FriendReunionInviteeRecallItemControllers;

	private UIActivityV2FriendReunionInviteeRecallItemController m_SuccessBindCtrl;

	private List<FriendReunionInviterData> m_FriendReunionInviterDatas;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private void RefreshView()
	{
	}

	private void SetRecallTitle()
	{
	}

	private void SetRewardTitle()
	{
	}

	private void SetReCallItems()
	{
	}

	private void SetRewardMission()
	{
	}

	private void OnOpenCallBackWnd()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
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
