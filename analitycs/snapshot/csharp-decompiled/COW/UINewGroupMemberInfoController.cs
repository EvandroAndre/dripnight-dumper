using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

internal class UINewGroupMemberInfoController : UIBaseGroupMemberInfoController, IUIModelDataChangeObserver
{
	private enum EChatBubbleShowState
	{
		None,
		Sticker,
		Title,
		SimpleContent,
		MultiContent,
		LaunchTag
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ResourceID> _003C_003E9__87_1;

		public static Converter<tcp.ItemTagInfo, proto.ItemTagInfo> _003C_003E9__131_0;

		internal int _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__87_1(ResourceID a, ResourceID b)
		{
			return 0;
		}

		internal proto.ItemTagInfo _003CTryShowLaunchTag_003Eb__131_0(tcp.ItemTagInfo x)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public GroupMemberInfo memInfo;

		internal bool _003CSetCallSignData_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public List<ResourceID> res_list;

		public UINewGroupMemberInfoController _003C_003E4__this;

		internal void _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__2()
		{
		}
	}

	private UINewGroupMemberInfoView m_View;

	private int MemberIndex;

	private GroupReservationShowInfo m_ReserveInfo;

	private tcp.RematchPlayer m_RematchInfo;

	protected List<ResourceID> m_needDownLoadTeammateResList;

	private UINewBriefProfileInfoController m_CallSign;

	private UIModelGroup m_ModelGroup;

	private UIModelProfile m_ModelProfile;

	private float m_FadeIconTime;

	private uint m_GroupAnimId;

	private float m_CDTime;

	private bool m_IsInRemindCD;

	private UIModelChat m_ChatModel;

	private UIModelLeaderBoardTitle m_LeaderBoardTitleModel;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelFriends m_ModelFriend;

	private float m_NextChangeChatBubbleTime;

	private float m_NextBubbleAnimTime;

	private const float CHAT_BUBBLE_ENDANIM_TIME = 0.2f;

	private const int CHAT_BUBBLE_SHORT_WIDTH = 52;

	private ChatStickerData m_StickerData;

	private uint m_ShowTitleID;

	private TitleInfo m_TitleData;

	private GameObject m_TitleVFXResGO;

	private float m_ladderIconSize;

	private bool m_HasChatBubble;

	private bool m_IsLeader;

	private UILeaderBoardTitleSingleController m_LeaderBoardTitleSingleCtrl;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private GameObject m_Ready;

	private GameObject m_Leader;

	private UIReserveGroupMemberInfoController m_ReserveGroupMemberInfoCtrl;

	private UIRematchGroupMemberInfoController m_RematchGroupMemberInfoCtrl;

	private UIHippoCrisisMemberValueController m_HippoCrisisMemberValueCtrl;

	private GameObject m_FakeMemberObj;

	private GameObject m_RemindPlayShot;

	private UILaunchTagFrameController m_LaunchTag;

	private UIModelCredit m_ModelCredit;

	private bool m_ShowInHippoCrisis;

	private uint m_CachedShowBanMatchBubbleGameMode;

	private Vector3[] m_ClickAvatarPosArray;

	private Vector3[] m_ClickAvatarBoxSizeArray;

	private Vector3 m_OriginClickAvatarPos;

	private Vector3 m_OriginClickAvatarBoxSize;

	private Vector3 m_NoticeGridPos;

	private UIPrimeGroupMemberInfoShareClothesController m_ShareClothesController;

	private UIDuoEmoteInviteBubbleController m_DuoEmoteInviteBubbleCtrl;

	private UITitleCommonController m_TitleCtrl;

	private UIPrimeShareClothesBubbleController m_ShareClothesBubbleController;

	public override GroupMemberInfo GetMemberInfo()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitGroupMemberGroupAnim()
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetCallSignData(GroupMemberInfo memInfo)
	{
	}

	public override void StreakScroll(uint streakScrollIndex)
	{
	}

	public override void SetUIData(GroupMemberInfo memInfo, bool leader, int idx = 0)
	{
	}

	public override void SetReserveUIData(GroupReservationShowInfo info, int idx = 0)
	{
	}

	public override void SetRematchUIData(tcp.RematchPlayer player, int idx = 0)
	{
	}

	private void ClearRematchUIData()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	private void SetFakeMemberUIData(GroupMemberInfo memInfo, int idx)
	{
	}

	private void SetRematchPhantomMemberUIData(GroupMemberInfo memInfo, int idx)
	{
	}

	private void OnInteractMuteStateChange(object[] data)
	{
	}

	private void OnInteractMuteStateChange(bool isMute)
	{
	}

	public override void SetMute(bool isMute)
	{
	}

	public override void RefreshProfile()
	{
	}

	private void OnChannelResume(object[] data)
	{
	}

	public void InitMemberCreditBehaviorMuteState()
	{
	}

	private void OnTeamateVadStateChange(object[] data)
	{
	}

	private void OnMuteStateChange(object[] data)
	{
	}

	public override void SetRelationshipState()
	{
	}

	public override void SetReadyState(bool ready, bool leader, bool isMixedGroupMemberInGameOrResult)
	{
	}

	public override void ResetScroll()
	{
	}

	public void OnGroupAllReadyStateChanged(object[] data)
	{
	}

	public void OnRemindSuccess()
	{
	}

	public void OnMatchMakingShow()
	{
	}

	public void OnMatchMakingHide()
	{
	}

	public void RefreshNoticeView()
	{
	}

	private void SetNoticeBtnView(bool allReady)
	{
	}

	private void ClothesUpdate(object[] data)
	{
	}

	private void RefreshPrimeSetShareView(object[] data)
	{
	}

	public void OpenPrimeSetShareGuide()
	{
	}

	public override void SetFriendState(bool friend, InviteClickCallBack cb = null)
	{
	}

	public override void SetOptionalMapResState(tcp.EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	public override float GetNeedDownloadSize()
	{
		return 0f;
	}

	private void RefreshDownLoadTeammateEquipmentContainer()
	{
	}

	public void SetDownloadCtrlDepth()
	{
	}

	private void DownLoadOneTeamateEquipmentClick()
	{
	}

	public override void DownLoadOneTeamateEquipment()
	{
	}

	private void DownLoadAllTeamateEquipmentClick()
	{
	}

	private List<uint> GetItemIdsNeedDownLoadInShared()
	{
		return null;
	}

	private List<uint> GetItemIdsNeedDownLoadFromTeammate()
	{
		return null;
	}

	private void OnNoticeBtnClick()
	{
	}

	public override bool NeedScroll()
	{
		return false;
	}

	public override uint GetScrollCount()
	{
		return 0u;
	}

	private void ShowNoticeCD(bool show)
	{
	}

	public override void EnableInivte(bool enable)
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnClickAvatar()
	{
	}

	private void OnClickRematchAvatar()
	{
	}

	private void OnClickReserveAvatar()
	{
	}

	private void UpdateNickNameAndAlias()
	{
	}

	public override void SetLaunchTagPosAndScale(Vector3 pos, float scale)
	{
	}

	public override void SetChatBubbleWorldPosition(Vector3 position)
	{
	}

	protected void OnContentClick()
	{
	}

	private bool BeforeSetChatBubbleData()
	{
		return false;
	}

	private void AfterSetChatBubbleData(float bubbleCdTime)
	{
	}

	private void SetDuoEmoteInviteBubble(GEvent _data)
	{
	}

	private void SetChatBubbleData(EChatBubbleShowState bubble_state = EChatBubbleShowState.None, string chat_content = null, bool isCreditPunishBubble = false)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateGroupChatBubble()
	{
	}

	private void OnEmotePlayEnd(object[] data)
	{
	}

	private void OnSendTitle(object[] data)
	{
	}

	private void OnShowAccountLaunchTag(ulong accountID)
	{
	}

	private void OnShowAccountLaunchTagSelf(object[] data)
	{
	}

	private void RemoveTitleVFX()
	{
	}

	public override void ResetMute()
	{
	}

	public void RefreshLeaderBoardTitle(object[] data)
	{
	}

	private void ShowSingleTitleCtrl(LeaderBoardTitleShowingParams showParams)
	{
	}

	private void ChangeTopIconGroupPosition(bool isUp)
	{
	}

	private void OnOpenHippoCrisisLobby(object[] data)
	{
	}

	private void SetChangeHippoCrisisView()
	{
	}

	private void SetHippoCrisisView()
	{
	}

	private void SetCreditPunishBubbleContent(string content)
	{
	}

	private bool CheckAndSetCreditPunishBubble()
	{
		return false;
	}

	private void RefreshBanMatchBubble()
	{
	}

	private void TryShowLaunchTag(List<tcp.ItemTagInfo> launchTagList)
	{
	}

	private void TryShowLaunchTag(proto.ItemTagInfo launchTagInfo)
	{
	}

	public override void HideLaunchTag()
	{
	}

	private void OnPrimeSetShareNtf(GEvent _data)
	{
	}

	public void OnInTakePhotoState(object[] objects)
	{
	}

	public void OnOutTakePhotoState(object[] objects)
	{
	}

	private void _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__87_0()
	{
	}

	public GroupMemberInfo _003C_003EiFixBaseProxy_GetMemberInfo()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetCallSignData(GroupMemberInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StreakScroll(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(GroupMemberInfo P0, bool P1, int P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetReserveUIData(GroupReservationShowInfo P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRematchUIData(tcp.RematchPlayer P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetMute(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshProfile()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRelationshipState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetReadyState(bool P0, bool P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetScroll()
	{
	}

	public void _003C_003EiFixBaseProxy_SetFriendState(bool P0, InviteClickCallBack P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetOptionalMapResState(tcp.EGroup.PlayerPatchOptionalResStatus P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetNeedDownloadSize()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_DownLoadOneTeamateEquipment()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedScroll()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetScrollCount()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_EnableInivte(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLaunchTagPosAndScale(Vector3 P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetChatBubbleWorldPosition(Vector3 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetMute()
	{
	}

	public void _003C_003EiFixBaseProxy_HideLaunchTag()
	{
	}
}
