using System;
using System.Collections.Generic;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public static class InteractionPopUtil
{
	public enum UIInteractionPoptype : long
	{
		None = 0L,
		LookInformation = 2L,
		AddFriends = 4L,
		InviteClan = 8L,
		GiftFriend = 16L,
		Whisper = 32L,
		TeamKickOut = 64L,
		ChampionshipTeam = 128L,
		InviteGroup = 256L,
		ApplyJoinGroup = 512L,
		DeleteFriend = 1024L,
		AddToBlackList = 2048L,
		GroupKickOut = 4096L,
		MarkFavorFriend = 8192L,
		CancleFavorFriend = 16384L,
		PlayerKick = 32768L,
		CreatorMoveTo = 65536L,
		CreatorMoveFrom = 131072L,
		PlayerMoveToObser = 262144L,
		PlayerMoveToPlay = 524288L,
		RoomLookInfo = 1048576L,
		RoomAddFriend = 2097152L,
		ReportChat = 4194304L,
		CupTeamKickOut = 8388608L,
		ExcludeSetFriendAlias = 16777216L,
		ReportGroupMemberInLobby = 33554432L,
		Mute = 67108864L,
		UnMute = 134217728L,
		ReportPlayerInLobby = 536870912L,
		TransferLeader = 1073741824L,
		InviteToTrainingArea = -2147483648L,
		InviteToSocialArea = 4294967296L,
		InviteToTakePhoto = 8589934592L,
		ReportPlayerInUGCGame = 17179869184L
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<object> _003C_003E9__3_1;

		public static Action<object> _003C_003E9__4_0;

		public static Action<object> _003C_003E9__12_0;

		public static Action<object> _003C_003E9__26_0;

		public static Action<object> _003C_003E9__27_0;

		public static Action<object> _003C_003E9__30_0;

		internal void _003CCreateLookInformation_003Eb__3_1(object obj)
		{
		}

		internal void _003CCreateWishList_003Eb__4_0(object obj)
		{
		}

		internal void _003CCreateTeamKickOut_003Eb__12_0(object e)
		{
		}

		internal void _003CCreatePlayerMoveToObser_003Eb__26_0(object e)
		{
		}

		internal void _003CCreatePlayerMoveToPlay_003Eb__27_0(object e)
		{
		}

		internal void _003CCreateCreatorMoveFrom_003Eb__30_0(object e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public ulong id;

		internal void _003CCreateSetFriendAlias_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UINavigationUtil.UINavigationFrom from;

		public FriendInfo friendInfo;

		public EGiftStore_BuddyType type;

		public EGiftSendSource giftSource;

		internal void _003CCreateGiftFriend_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public object e;

		internal void _003CCreateTeamKickOut_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public ulong memberAccountId;

		internal void _003CCreateTransferLeader_003Eb__0(object id)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public object id;

		public string memberName;

		internal bool _003CCreateGroupKickOut_003Eb__1(GroupMemberInfo temp)
		{
			return false;
		}

		internal void _003CCreateGroupKickOut_003Eb__0(object e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public object e;

		internal void _003CCreateGroupKickOut_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int key;

		internal void _003CCreateCupTeamKickOut_003Eb__0(object e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public object e;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateCupTeamKickOut_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ulong id;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateWhisper_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string nickName;

		public ulong id;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateReportPlayer_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ulong id;

		public string nickName;

		internal void _003CCreateReportPlayerInUGCGame_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string nickName;

		public ulong id;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateReportGroupMemberInLobby_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public ulong id;

		internal void _003CCreateInviteClan_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UINavigationUtil.UINavigationFrom from;

		public uint championshipType;

		public ulong teamID;

		internal void _003CCreateChampionshipTeam_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public InviteGroupPopMenuData data;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateInviteGroup_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public MessageInfo msgInfo;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateApplyJoinGroup_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string info;

		public ulong id;

		public Action _003C_003E9__1;

		internal void _003CCreateDeleteFriendGroup_003Eb__0(object obj)
		{
		}

		internal void _003CCreateDeleteFriendGroup_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ulong id;

		public string nickName;

		public Action _003C_003E9__1;

		internal void _003CCreateAddToBlackList_003Eb__0(object obj)
		{
		}

		internal void _003CCreateAddToBlackList_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public RoomPopMeanData roomPopMeanData;

		internal void _003CCreatePlayerKick_003Eb__0(object e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_1
	{
		public RoomPlayerInfo d;

		internal void _003CCreatePlayerKick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIModelCustomRoom m_Model;

		internal void _003CCreateCreatorMoveTo_003Eb__0(object e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public int from;

		public int to;

		public _003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateCreatorMoveTo_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public ulong id;

		public ulong accountId;

		internal void _003CCreateInviteToSocialArea_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public ulong id;

		public ulong accountId;

		internal void _003CCreateInviteToTrainingArea_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public UINavigationUtil.UINavigationFrom from;

		public ulong id;

		internal void _003CCreateLookInformation_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ulong id;

		public EFriendAddFrom add_from;

		public string region;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateAddFriends_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public ulong accountId;

		public UINavigationUtil.UINavigationFrom from;

		internal void _003CCreateInviteTakePhoto_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ulong id;

		internal void _003CCreateMarkFavorFriend_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public ulong id;

		internal void _003CCreateCancleFavorFriend_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ulong id;

		public bool mute;

		internal void _003CCreateMute_003Eb__0(object obj)
		{
		}
	}

	private static ulong m_LastInviteTs;

	public static CommonPopMenuData CreateInviteClan(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	public static void CheckAndLogInformation(UINavigationUtil.UINavigationFrom from, ulong id)
	{
	}

	public static CommonPopMenuData CreateLookInformation(UINavigationUtil.UINavigationFrom from, ulong id, string iconName = "")
	{
		return null;
	}

	public static CommonPopMenuData CreateWishList(UINavigationUtil.UINavigationFrom from, ulong id, string iconName = "")
	{
		return null;
	}

	public static CommonPopMenuData CreateAddFriends(UINavigationUtil.UINavigationFrom from, ulong id, EFriendAddFrom add_from, string region)
	{
		return null;
	}

	public static CommonPopMenuData CreateInviteTakePhoto(UINavigationUtil.UINavigationFrom from, ulong accountId)
	{
		return null;
	}

	public static CommonPopMenuData CreateMarkFavorFriend(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	public static CommonPopMenuData CreateCancleFavorFriend(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	public static CommonPopMenuData CreateMute(UINavigationUtil.UINavigationFrom from, ulong id, bool mute)
	{
		return null;
	}

	public static CommonPopMenuData CreateSetFriendAlias(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	public static CommonPopMenuData CreateGiftFriend(UINavigationUtil.UINavigationFrom from, FriendInfo friendInfo, EGiftStore_BuddyType type)
	{
		return null;
	}

	public static CommonPopMenuData CreateTeamKickOut(UINavigationUtil.UINavigationFrom from, object id)
	{
		return null;
	}

	public static CommonPopMenuData CreateTransferLeader(UINavigationUtil.UINavigationFrom from, ulong memberAccountId)
	{
		return null;
	}

	public static CommonPopMenuData CreateGroupKickOut(UINavigationUtil.UINavigationFrom from, object id)
	{
		return null;
	}

	public static CommonPopMenuData CreateCupTeamKickOut(UINavigationUtil.UINavigationFrom from, object id, int key)
	{
		return null;
	}

	public static CommonPopMenuData CreateWhisper(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	public static CommonPopMenuData CreateReportPlayer(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	public static CommonPopMenuData CreateReportPlayerInUGCGame(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	public static CommonPopMenuData CreateReportGroupMemberInLobby(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	public static CommonPopMenuData CreateChampionshipTeam(UINavigationUtil.UINavigationFrom from, ulong teamID, uint championshipType)
	{
		return null;
	}

	public static CommonPopMenuData CreateInviteGroup(UINavigationUtil.UINavigationFrom from, MessageInfo msgInfo)
	{
		return null;
	}

	public static CommonPopMenuData CreateApplyJoinGroup(UINavigationUtil.UINavigationFrom from, MessageInfo msgInfo)
	{
		return null;
	}

	public static CommonPopMenuData CreateDeleteFriendGroup(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	public static CommonPopMenuData CreateAddToBlackList(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	public static CommonPopMenuData CreatePlayerKick(RoomPopMeanData roomPopMeanData)
	{
		return null;
	}

	public static CommonPopMenuData CreatePlayerMoveToObser(RoomPlayerInfo m_info)
	{
		return null;
	}

	public static CommonPopMenuData CreatePlayerMoveToPlay(RoomPlayerInfo m_info)
	{
		return null;
	}

	private static bool SwitchValidCheck(int from, int to, UIModelCustomRoom m_Model)
	{
		return false;
	}

	public static CommonPopMenuData CreateCreatorMoveTo(int team_index)
	{
		return null;
	}

	public static CommonPopMenuData CreateCreatorMoveFrom(int team_index)
	{
		return null;
	}

	public static CommonPopMenuData CreateInviteToSocialArea(ulong id)
	{
		return null;
	}

	public static CommonPopMenuData CreateInviteToTrainingArea(ulong id)
	{
		return null;
	}

	public static void OpenBriefBox(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid, Vector3 checkWindowLeftOrRightPos = default(Vector3), string region = "", Vector3 WindowPos = default(Vector3), bool showSwitchButton = true, Action onCloseAction = null, EventLogger.BriefBoxClickData clickData = null, bool hideWishListBtn = false, string nickName = "")
	{
	}

	public static void OpenCommonInteractionPanel(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid, Vector3 pos, string iconName = "", string region = "")
	{
	}

	public static void OpenCommonInteractionPanel(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid = 0uL, string iconName = "", string region = "")
	{
	}

	public static bool CheckIsNotCrossPlayer(ulong accountID)
	{
		return false;
	}

	public static List<CommonPopMenuData> CreateCommonInteractionMenuList(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong accountID, string iconName = "", string region = "", bool hideWishListBtn = false, string nickName = "")
	{
		return null;
	}
}
