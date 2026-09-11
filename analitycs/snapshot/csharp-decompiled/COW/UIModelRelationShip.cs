using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelRelationShip : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public bool visible;

		internal void _003CRequestAuthInspect_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public uint rankLevel;

		public ulong friendID;

		public CSClaimIntimacyAwardReq req;

		public proto.EFriend.RelationType relationType;

		internal void _003CRequestClaimIntimacyAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public ulong accountID;

		public proto.EFriend.RelationType relationType;

		public RelationshipInfo currentRelationshipInfo;

		public List<RelationshipInfo> accountInfoList;

		public UIModelRelationShip _003C_003E4__this;

		public Predicate<FriendAccountInfo> _003C_003E9__1;

		internal void _003CRequestCreateSpecialRelation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestCreateSpecialRelation_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public proto.EFriend.RelationType relationType;

		public UIModelRelationShip _003C_003E4__this;

		public ulong accountID;

		internal void _003CRequestConfirmCreateSpecialRelation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public proto.EFriend.RelationType relationType;

		public ulong accountID;

		internal void _003CRequestConfirmDismissSpecialRelation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public proto.EFriend.RelationType relationType;

		public ulong accountID;

		internal void _003CRequestDeclineCreateSpecialFriend_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public proto.EFriend.RelationType relationType;

		public ulong accountID;

		internal void _003CRequestDeclineDissmissSpecialFriend_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public UIModelRelationShip _003C_003E4__this;

		public proto.EFriend.RelationType relationType;

		public ulong accountID;

		internal void _003CRequestCallbackDismissSpecialFriend_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_RelationshipInfoReady = 1u;

	public const uint PropID_UpdateRelationshipInviteState = 2u;

	public const uint PropID_UpdateRelationshipApplications = 4u;

	public const uint PropID_UpdateApplicationMsgInfoState = 8u;

	public const uint PropID_ClaimRelationshipRewards = 16u;

	public const uint PropID_UpdateIntimacyChange = 32u;

	public const uint PropID_UpdateRelationshipVisible = 64u;

	public const uint PropID_RelationshipIntimacyInfoReady = 128u;

	private const string SHOW_CELEBERATE_CONNECT_WITH_FRIEND = "Congratulation_{0}";

	private bool m_RelationshipDicReady;

	private Dictionary<uint, List<RelationshipInfo>> m_RelationshipDic;

	private bool m_IntimacyAwardInfoDicReady;

	private Dictionary<ulong, SpecificIntimacyRankAwardInfo> m_IntimacyAwardInfoDic;

	private Dictionary<uint, Dictionary<uint, IntimacyAwardDesc>> m_IntimacyAwardDescDic;

	private bool m_ApplicationsListReady;

	private List<RelationshipMessageInfo> m_ApplicationsList;

	private uint m_AwardSkillShareNeedLv;

	private uint m_IntimacyRankMax;

	private const string BR_FRIEND_SPECIAL_FRIEND_MAX_COUNT_OTHERS = "BR_FRIEND_SPECIAL_FRIEND_MAX_COUNT_OTHERS";

	private List<ulong> m_RecommendSpecialFriendList;

	private ulong LastRequestRecommendSpecialFriendListTs;

	private Dictionary<uint, List<FriendAccountInfo>> m_FriendRelationFilterDic;

	private bool m_HasRequestRecommendSpecialFriendList;

	private Dictionary<uint, bool> m_ClaimIntimacyAwardIsSendingDic;

	private Queue<BarrageData> m_LobbyBarrageListCloseFriendOnLine;

	private Queue<BarrageData> m_LobbyBarrageListCloseFriendChat;

	private const string RecordLastPlayGameFriendString = "LastPlayGameFriend";

	private const int RecordLastPlayGameFriendCount = 3;

	private List<ulong> m_LastPlayGameFriends;

	public bool RelationshipDicReady => false;

	public bool AwardSkillShareCanReceive => false;

	public List<ulong> LastPlayGameFriends => null;

	public RelationshipInfo GetRelationshipInfoAlreadyBe(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	public RelationshipInfo GetRelationshipInfo(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	public RelationshipInfo GetCloseFriendRelation()
	{
		return null;
	}

	public void SetCurrentAllNotifyMsgRead()
	{
	}

	public void DeclineAndReadCurrentAllMsg()
	{
	}

	public void CheckNewRelationshipMsg()
	{
	}

	private void UpdateLobbyBtnFriendHintTipNum()
	{
	}

	public bool RelationshipInfoVisible(proto.EFriend.RelationType relationType)
	{
		return false;
	}

	public List<RelationshipMessageInfo> GetRelationshipApplications()
	{
		return null;
	}

	public bool HasRelationshipDismissApplication(proto.EFriend.RelationType relationType)
	{
		return false;
	}

	public ulong GetRelationshipDismissApplicationReqTime(proto.EFriend.RelationType relationType)
	{
		return 0uL;
	}

	public SpecificIntimacyRankAwardInfo GetIntimacyRewardInfo(ulong relationshipID)
	{
		return null;
	}

	public List<RelationshipInfo> GetCurrentRelationInfoAlreadyBe(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	public List<RelationshipInfo> GetCurrentRelationInfo(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	public List<FriendAccountInfo> GetRelationshipCandidateList(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	public Dictionary<uint, IntimacyAwardDesc> GetIntimacyAwardsDesc(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	public IntimacyRankAwardInfo GetIntimacyAwardsInfo(ulong friendID, uint rank)
	{
		return null;
	}

	public int GetNewIntimacyMax(proto.EFriend.RelationType relationType)
	{
		return 0;
	}

	public IntimacyRankInfoData GetIntimacyRankInfoByIntimacy(proto.EFriend.RelationType relationType, uint intimacy)
	{
		return null;
	}

	public proto.EFriend.RelationType GetRelationship(ulong FriendID)
	{
		return proto.EFriend.RelationType.RelationType_NONE;
	}

	public List<ulong> GetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	public void SetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
	{
	}

	public uint GetRelationshipRank(ulong FriendID, proto.EFriend.RelationType relationType)
	{
		return 0u;
	}

	public bool CheckIsHadRelation(RelationshipInfo relationshipInfo)
	{
		return false;
	}

	public uint GetIntimacyLevelMax(proto.EFriend.RelationType relationType)
	{
		return 0u;
	}

	private bool CheckRelationshipStateIsConnect(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return false;
	}

	private RelationshipMessageInfo GetSepcialFriendApplication(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	public void ProcessServerData(CSGetAllFriendDescRes desc)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestAuthInspect(bool visible)
	{
	}

	public void RequestClaimIntimacyAward(ulong friendID, uint rankLevel, proto.EFriend.RelationType relationType)
	{
	}

	public void RequestIntimacyRankAwardsInfo(bool force = false)
	{
	}

	public void RequestCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestRelationShipInvitationInfos(bool force = false)
	{
	}

	public void RequestAllRelationshipStateInfo(bool isFirstLogin, bool force = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void RequestConfirmCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestConfirmDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void DeleteMessageInfo(RelationshipMessageInfo msg)
	{
	}

	public bool GetBarrageIsOpen()
	{
		return false;
	}

	public bool TryGetBarrageDataCloseFriendOnLine(out BarrageData lobbyBarrageData)
	{
		lobbyBarrageData = null;
		return false;
	}

	public bool IsHasBarrageData()
	{
		return false;
	}

	public bool TryGetBarrageDataCloseFriendChat(out BarrageData lobbyBarrageData)
	{
		lobbyBarrageData = null;
		return false;
	}

	public void RequestDeclineCreateSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestDeclineDissmissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestCallbackDismissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	public void RequestRecommendSpecialFriendList()
	{
	}

	public void OnProcessMessage(MessageInfo info)
	{
	}

	public void OnReceiveRelationshipMsgInfo(RelatedFriendRequestNtf receiveMsg, UIRelationshipMsgType msgType)
	{
	}

	public void OnReceiveIntimacyChange(ulong friendID, proto.EFriend.RelationType relationType, uint changeValue)
	{
	}

	public void AddLastPlayGameFriend(MatchStats stats)
	{
	}

	public void InitLastPlayGameFriend()
	{
	}

	private void _003CRequestIntimacyRankAwardsInfo_003Eb__61_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestDismissSpecialRelation_003Eb__63_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRelationShipInvitationInfos_003Eb__64_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAllRelationshipStateInfo_003Eb__65_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRecommendSpecialFriendList_003Eb__78_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
