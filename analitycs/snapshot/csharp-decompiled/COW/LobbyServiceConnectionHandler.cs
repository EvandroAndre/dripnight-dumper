using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class LobbyServiceConnectionHandler : ServiceConnectionHandler
{
	private struct FreatureCache
	{
		public string feature_name;

		public byte[] feature_data;

		public uint data_len;

		public uint data_crc;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__14_0;

		public static Action _003C_003E9__24_0;

		public static Predicate<RoomPlayerInfo> _003C_003E9__24_1;

		public static Converter<ulong, string> _003C_003E9__24_2;

		public static Converter<ulong, string> _003C_003E9__24_3;

		public static Predicate<GroupMemberInfo> _003C_003E9__78_0;

		public static Predicate<GroupMemberInfo> _003C_003E9__115_0;

		public static Action _003C_003E9__149_1;

		public static Comparison<OccupationUpdateInfo> _003C_003E9__160_0;

		public static Comparison<OccupationUpdateInfo> _003C_003E9__160_1;

		internal void _003COnLightFeatureNtf_003Eb__14_0()
		{
		}

		internal void _003COnMsgCustomRoom_003Eb__24_0()
		{
		}

		internal bool _003COnMsgCustomRoom_003Eb__24_1(RoomPlayerInfo a)
		{
			return false;
		}

		internal string _003COnMsgCustomRoom_003Eb__24_2(ulong e)
		{
			return null;
		}

		internal string _003COnMsgCustomRoom_003Eb__24_3(ulong i)
		{
			return null;
		}

		internal bool _003COnMsgGroup_JoinNtf_003Eb__78_0(GroupMemberInfo m)
		{
			return false;
		}

		internal bool _003COnGroupMergeNtf_003Eb__115_0(GroupMemberInfo m)
		{
			return false;
		}

		internal void _003COnMsgAntiAddictionHintNtf_003Eb__149_1()
		{
		}

		internal int _003COnOccupationUpdateNTF_003Eb__160_0(OccupationUpdateInfo a, OccupationUpdateInfo b)
		{
			return 0;
		}

		internal int _003COnOccupationUpdateNTF_003Eb__160_1(OccupationUpdateInfo a, OccupationUpdateInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public GroupMemberInfo member;

		internal bool _003COnGroupModifyHippoEquipNtf_003Eb__0(GroupMemberInfo mem)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public GroupMemberInfo memberNew;

		internal bool _003COnGroupMergeNtf_003Eb__1(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public LobbyServiceConnectionHandler _003C_003E4__this;

		public MessageNotify res;

		internal void _003COnMsgMatchMaking_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public UGCSimpleDownloadTask resDownloadTask;

		public UIModelMapOpeningInfo modelMap;

		internal void _003COnMsgUpdateUGCSocialURLNtf_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public UISecondConfirmContoller confirmWnd;

		internal void _003COnMsgAntiAddictionHintNtf_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public tcp.RoomInfo resData;

		internal void _003COnMsgHasLatestRoomInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public CreditScoreCheckNtf resData;

		public int i;

		public Predicate<GroupMemberInfo> _003C_003E9__4;

		internal bool _003COnMsgCustomRoom_003Eb__4(GroupMemberInfo value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public LobbyServiceConnectionHandler _003C_003E4__this;

		public MatchmakingSussNtf resData;

		public string outAddr;

		public int outPort;

		internal void _003COnRoomMatchSuccessLoading_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public VeteranFriendOnlineNtf resData;

		internal void _003COnVeteranFriendOnline_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public RelatedFriendOnlineNtf resData;

		internal bool _003COnMsgFriend_ConfidantOnline_003Eb__0(LeaderBoardInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public GroupMemberInfo memberNew;

		internal bool _003COnMsgGroup_JoinNtf_003Eb__1(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public ulong myId;

		internal bool _003COnMsgGroup_StartNtf_003Eb__0(GroupMemberInfo mem)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public ShowEmoteNtf resData;

		internal bool _003COnMsgGroup_ShowEmoteNtf_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private bool m_ConnectNotiFailedOnce;

	private static FreatureCache lite_datas;

	private static readonly Dictionary<uint, string> MATCHMAKING_ERR_MESSAGE_DICT;

	private static readonly Dictionary<uint, string> GROUP_ERR_MESSAGE_DICT;

	private static readonly Dictionary<uint, string> CUSTOMROOM_ERR_MESSAGE_DICT;

	public LobbyServiceConnectionHandler(string token, AntiAddicHistoryInfo antiAddicHistoryInfo, AccessValidInfo accessValidInfo)
		: base(null, null, null, null)
	{
	}

	public override EServiceHandler GetServiceHandlerName()
	{
		return EServiceHandler.None;
	}

	public new bool Connect(string addr, int port)
	{
		return false;
	}

	public override void OnConnected(bool result)
	{
	}

	public override void OnDisconnected(tcp.EAccount.Proto reason)
	{
	}

	private string GetLobbyEndpoint()
	{
		return null;
	}

	private void LogConnectNotiFailure(string exceptionMsg)
	{
	}

	private void LogConnectNotiRecovery()
	{
	}

	private void OnMsgAchievement(MessageNotify res)
	{
	}

	private void OnMsgActivity(MessageNotify res)
	{
	}

	private void OnMsgFFAnti(MessageNotify res)
	{
	}

	private void OnLightFeatureNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnSendDataToClientNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgAttendance(MessageNotify res)
	{
	}

	private void OnMsgAvatarProfile(MessageNotify res)
	{
	}

	private void OnMsgChampionship(MessageNotify res)
	{
	}

	private void OnMsgClan(MessageNotify res)
	{
	}

	private void OnMsgCupMatch(MessageNotify res)
	{
	}

	private void OnMsgCustomEvent(MessageNotify res)
	{
	}

	private void OnCustomCardRedPointNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnCustomCardReceiveNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgCustomRoom(MessageNotify res)
	{
	}

	private void OnRoomMatchMakingSuccess(MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	private void OnRoomMatchSuccessLoading(MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	private void OnUGCInGameMatchSuccessLoading(MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	private void MatchSuccessLoading(MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	private bool CheckIsInBatchRoom()
	{
		return false;
	}

	private bool CheckIsInRoom()
	{
		return false;
	}

	private bool CheckIsUGCRoomMatchMaking()
	{
		return false;
	}

	private void OnDisconnected_CustomRoom()
	{
	}

	private void EndHangupRoom(bool isReturnRoom)
	{
	}

	private void CheckActiveSkillRepeat(tcp.RoomInfo info)
	{
	}

	private void OnRoomRecruitNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnRoomRecruitListNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnRoomStopRecruitNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnRoomRecruitGetInfoNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnChangeOwnerActiveStatusNtf(uint ret, MessageNotify msg)
	{
	}

	private bool IsRecruitRoomInfoChanged(RecruitRoomInfo oldInfo, RecruitRoomInfo newInfo)
	{
		return false;
	}

	private void OnMsgElitePass(MessageNotify res)
	{
	}

	private void PopupErrWindow(Dictionary<uint, string> errMsgDict, uint errCode, bool cleanAllPopups = true, string extraMsg = "")
	{
	}

	private void OnMsgEsports(MessageNotify res)
	{
	}

	private void OnMsgFresh(MessageNotify res)
	{
	}

	private void OnMsgFriend(MessageNotify res)
	{
	}

	private void OnVeteranFriendOnline(MessageNotify msg)
	{
	}

	private void OnMsgFriend_Remove(uint ret, MessageNotify msg)
	{
	}

	private void OnReceiveIntimacyChange(MessageNotify msg)
	{
	}

	private void OnReceiveRelationshipMsgInfo(MessageNotify msg, tcp.EFriend.Proto cmdType)
	{
	}

	private void OnMsgFriend_ConfirmAdd(uint res, MessageNotify msg)
	{
	}

	private void OnMsgFriend_ConfidantOnline(uint res, MessageNotify msg)
	{
	}

	private void OnMsgFriend_IntimacyOnline(MessageNotify msg)
	{
	}

	private bool ShouldBlockNearbyFriendRequest(uint add_from)
	{
		return false;
	}

	private void OnMsgLbs(MessageNotify res)
	{
	}

	private void OnMsgGin(MessageNotify res)
	{
	}

	private void OnMsgGooglePlay(MessageNotify res)
	{
	}

	private void OnMsgGroup(MessageNotify res)
	{
	}

	private bool ShouldFilterGroupProtoInGame()
	{
		return false;
	}

	private static bool IsEssentialGroupProtoForInGame(tcp.EGroup.Proto proto)
	{
		return false;
	}

	private void OnMsgGroup_Create(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_RefuseNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_LeaveNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_InviteNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_AcceptJoinNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_JoinRequestNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_ChangePublic(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_CSRANKINGBAN(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ChangeOptionalMapRes(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_GroupBanNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_RankingBanNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_MigrateGroupNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsg_TransferLeaderNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ReminderNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_RemindeeNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_JoinNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_Info(MessageNotify msg)
	{
	}

	private void OnMsgGroup_StartNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_StopNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_DismissNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_ShowEmoteNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ShowPetActionNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ShowAntiAddiction(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ShowTeamMateCheating(uint ret, MessageNotify msg)
	{
	}

	private void OnDisconnected_User()
	{
	}

	private void OnDisconnected_Group()
	{
	}

	private void OnMsgGroup_ReadyNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ChangeNtf(uint ret, MessageNotify msg)
	{
	}

	private bool CheckCSRankSpecialMatch(uint gamemode, uint matchmode, uint event_id)
	{
		return false;
	}

	private void OnMsgGroup_StartRoomMatchMakingNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_StopRoomMatchMakingNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgGroup_ChangeMapNtf(uint ret, MessageNotify msg)
	{
	}

	private void UpdateGroupInfo(GroupInfo resData, bool isNew = false, bool force = true, bool fromRematchMerge = false)
	{
	}

	private void OnMsgGroup_GetGroupCodeNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnChangeAvailableMapsNtf(MessageNotify msg)
	{
	}

	private void OnGroupQuickMatchRankLimit(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupQuickMatchCreditPunish(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupReserveShowNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupGetRecruitListNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupRecruitInfoNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupStopRecruitNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnAccountRecruitBannedNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupRecruitRemovedNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupNewbieRecruitTeamNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupModifyHippoEquipNtf(MessageNotify msg)
	{
	}

	private void OnMsgApplySetShareNtf(MessageNotify msg)
	{
	}

	private void OnMsgApproveSetShareApplyNtf(MessageNotify msg)
	{
	}

	private void OnMsgOfferSetShareNtf(MessageNotify msg)
	{
	}

	private void OnMsgAcceptSetShareOfferNtf(MessageNotify msg)
	{
	}

	private void OnMsgTakeOffSetShareNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroupMemberLimitNtf(MessageNotify msg)
	{
	}

	private void OnMsgGroup_ShowTransformNTF(MessageNotify msg)
	{
	}

	private void OnGroupMergeNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupMergeSuccessNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnGroupChangeDisPlayNtf(MessageNotify msg)
	{
	}

	private void OnGroupJoinHackerGroupNtf(MessageNotify msg)
	{
	}

	private void OnGroupLonewolfPlayerLogoutGameserverNtf(MessageNotify msg)
	{
	}

	private void OnRematchStartQuickMatchNtf()
	{
	}

	private bool ShouldBlockNearbyGroupInvite(tcp.EGroup.InviteeType target_type)
	{
		return false;
	}

	private void OnMsgHippo(MessageNotify res)
	{
	}

	private void OnMsgInventory(MessageNotify res)
	{
	}

	private void OnMsgBackpack(MessageNotify res)
	{
	}

	private void OnMsgLimitedEvent(MessageNotify res)
	{
	}

	private void OnMsgMail(MessageNotify res)
	{
	}

	private void OnMsgMatchMaking(MessageNotify res)
	{
	}

	private void OnMsgMatchMakingCdtHackerNtf(MessageNotify msg)
	{
	}

	private void OnMsgMatchMakingRankingBannedNtf(MessageNotify msg)
	{
	}

	private void OnMsgMatchMakingTeammateRankingBannedNtf(MessageNotify msg)
	{
	}

	private void OnMsgMatchMakingStopNtf(MessageNotify msg)
	{
	}

	private void OnMsgMatchMakingStartNtf(MessageNotify msg)
	{
	}

	private void OnMsgGetMatchMakingInfoNtf(MessageNotify msg)
	{
	}

	private void OnMsgGetSocialPlayerReachMaxCntNtf(MessageNotify msg)
	{
	}

	private void OnMsgGetRefuseSocialInviteNTF(MessageNotify msg)
	{
	}

	private void OnMsgGetInviteSocialNtf(MessageNotify msg)
	{
	}

	private void OnMsgGetRetMapVersionNtf(MessageNotify msg)
	{
	}

	private void OnMsgUpdateUGCSocialURLNtf(MessageNotify msg)
	{
	}

	private void OnMsgMatchMakingSussNtf(MessageNotify msg)
	{
	}

	private void OnMatchSuccessLoading(uint ret, MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	private void OnMsgGameOpeningInfoNtf(MessageNotify msg)
	{
	}

	private void OnMsgGameAntiAddicTionNtf(MessageNotify msg)
	{
	}

	private void OnDisconnected_MatchMaking()
	{
	}

	private void OnMsgGameServerManager(MessageNotify res)
	{
	}

	private void OnMsgGSMDebugSussNtf(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgMatchStats(MessageNotify res)
	{
	}

	private proto.EAntiAddiction.TotalTimeBanMode IntConvertToEnum(int i)
	{
		return proto.EAntiAddiction.TotalTimeBanMode.TotalTimeBanMode_NONE;
	}

	private void OnMsgAntiaddiction(MessageNotify res)
	{
	}

	private void OnMsgAntiAddictionHintNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiChildUnbindNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiGuardianUnbindNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiGuardianAcceptApplyNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiGuardianRefuseApplyNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiAddictionParentalControlNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiChildApplyBindNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiChildCancelApplyBindNtf(MessageNotify res)
	{
	}

	private void OnMsgAntiAddictionUnbindResetNtf(MessageNotify res)
	{
	}

	private void OnMsgModeStats(MessageNotify res)
	{
	}

	private void OnMsgOccupation(MessageNotify res)
	{
	}

	private void OnOccupationUpdateNTF(OccupationUpdateNtf data)
	{
	}

	private void OnMsgPetExpChange(MessageNotify res)
	{
	}

	private void OnMsgPresence(MessageNotify res)
	{
	}

	private void OnTCPPresnceListNtf(MessageNotify msg)
	{
	}

	private void OnTCPChangeSocialStatusNtf(MessageNotify msg)
	{
	}

	private void OnMsgPrime(MessageNotify res)
	{
	}

	private void OnMsgCredit(MessageNotify res)
	{
	}

	private void OnMsgReconnection(MessageNotify res)
	{
	}

	private void OnMsgHasLatestGameInfo(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgHasLatestRoomInfo(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgHasLatestGroupInfo(uint ret, MessageNotify msg)
	{
	}

	private void OnMsgRelayMart(MessageNotify res)
	{
	}

	private void OnMsgRematch(MessageNotify res)
	{
	}

	private void OnMsgSharedGacha(MessageNotify res)
	{
	}

	private void OnMsgSocialHall(MessageNotify res)
	{
	}

	private void OnMsgStore(MessageNotify res)
	{
	}

	private void OnMsgTeamTopUp(MessageNotify res)
	{
	}

	private void OnMsgUpdateUser(MessageNotify res)
	{
	}

	private void OnMsgVIPCard(MessageNotify res)
	{
	}

	private void OnMsgWeaponPower(MessageNotify res)
	{
	}

	private void OnMsgWorkShop(MessageNotify res)
	{
	}

	public EServiceHandler _003C_003EiFixBaseProxy_GetServiceHandlerName()
	{
		return EServiceHandler.None;
	}

	public void _003C_003EiFixBaseProxy_OnConnected(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisconnected(tcp.EAccount.Proto P0)
	{
	}
}
