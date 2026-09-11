using System.Collections.Generic;
using message;
using proto;
using proto.Login;
using tcp;

namespace COW;

public class BaseProfileInfo
{
	public ulong AccountID;

	public string Region;

	public uint Level;

	public string NickName;

	public string OnlineState;

	public string PortraitUrl;

	public string PlatformIcon;

	public string ExternalName;

	public string GenderIcon;

	public string ClanName;

	public ulong ClanID;

	public uint ClanBadgeID;

	public uint ClanFrameId;

	public bool UseCustomClanBadge;

	public string CustomClanBadge;

	public uint Banner;

	public uint HeadPic;

	public int Rank;

	public int RankPoint;

	public int PeakRankPos;

	public int CSRank;

	public int CSRankPoint;

	public int CSPeakRankPos;

	public bool display_cs_peak_point;

	public uint cs_peak_tournament_rank_pos;

	public uint cs_peak_points;

	public int HCRank;

	public int HCRankPoints;

	public int HCProfit;

	public int HCPWorth;

	public bool is_cs_ranking_ban;

	public long Update_time;

	public uint GroupMemberCnt;

	public uint GroupMode;

	public uint skinColor;

	public uint AvatarID;

	public uint Social_Status;

	public string Workshop_MapName;

	public List<proto.SocialHighLight> Social_Highlights;

	public proto.SocialHighLight BR_Social_Highlight;

	public proto.SocialHighLight CS_Social_Highlight;

	public proto.SocialHighLight Common_Social_Highlight;

	public proto.LeaderboardTitleInfo Leaderboard_Title;

	public List<uint> cloth;

	public List<proto.AccountCollectionCustomItemInfo> customData;

	public string SharerNickname;

	public List<uint> emotes;

	public HashSet<uint> ClothEffectUnlockItems;

	public proto.EPresence.AccountPresence OnlineStatus;

	public proto.EPresence.SocialPresence SocialPresence;

	public proto.EPresence.AccountCraftLandEditStatus CraftlandPresence;

	public tcp.EGroup.PlayerDisplayState DisplayState;

	public DLBMPCCFKKM MatchMode;

	public NIKKALKPIBO GameMode;

	public uint MapID;

	public bool HasPveTalent;

	public ulong RoomID;

	public uint RoomType;

	public uint RoomMember;

	public uint RoomMaxMember;

	public uint LootBox;

	public uint BackPack;

	public uint Parachute;

	public uint Skyboard;

	public uint Flight;

	public uint Pin;

	public uint Title;

	public uint GroupAnim;

	public uint Music;

	public uint QuickMsgVocal;

	public bool IsBagShow;

	public uint LoadingCard;

	public IDictionary<uint, uint> Weapons;

	public IDictionary<uint, uint> PVEWeaponSkins;

	public Dictionary<uint, uint> VehicleSkins;

	public Dictionary<uint, uint> EmoteSlots;

	public uint EquipSuperEmoteId;

	public uint RealSuperEmoteId;

	public uint EquipFinishMoveId;

	public uint RealFinishMoveId;

	public uint PeriodicSummaryLevel;

	public bool ShowCreditLevelTips;

	public Dictionary<uint, uint> Shows;

	public uint EquipFinalShotId;

	public Dictionary<uint, uint> SF50BCareerInfoDict;

	private bool _003CIsBackpackDirty_003Ek__BackingField;

	public bool HasElitePass;

	public uint EPBadgeId;

	public uint EPBadgeCount;

	public bool ShowCallsignRank;

	public long LastLoginAt;

	public uint Role;

	public ulong GroupId;

	public uint TrainingTokenCnt;

	public uint gamebagid;

	public uint hostTeamIndex;

	public uint StreakWins;

	public KFBDFCBIIFO SocialHallInfo;

	public bool ShowBRRank;

	public bool ShowCSRank;

	public ERecommandReason recommandReason;

	public InGameLeaderBoardTitleInfo InGameLeaderBoardTitleInfo;

	public InGameLeaderBoardTitleInfo InGameShowLeaderBoardTitleInfo;

	public List<InGameLeaderBoardTitleInfo> InGameLeaderBoardTitleInfos;

	public bool IsFirstRankTitleReceive;

	public bool IsFirstPeakTitleReceive;

	public string externalIcon;

	public proto.EAccount.ExternalIconStatus externalIconStatus;

	public proto.EAccount.ExternalIconShowType externalIconShowType;

	private Dictionary<uint, uint> m_CollectionAction;

	public Dictionary<uint, uint> CurEquipSkillEffect;

	public Dictionary<uint, uint> TempEquipSkillEffect;

	public List<uint> IngameCollectionAction;

	public string releaseVersion;

	public bool IsShowClanIcon;

	public byte BattleStyleID;

	public uint LoadoutID;

	public uint PetID;

	public uint PetSkillID;

	public uint IceWallModuleID;

	public uint SAPDiscountWeaponId;

	public bool Membership_state;

	public string BooyahBountyTitle;

	public proto.PrimePrivilegeDetail PrimeInfo;

	public proto.BadgeInfo EquipBadgeInfo;

	public uint AvatarFrameID;

	public bool IsEquipPrimeAvatarFrame;

	public int CSPeakPoints;

	public proto.WorkshopAccountSummaryInfo Workshop_summary_info;

	public uint EmulatorTag;

	private List<uint> m_EquippedWeaponIDsForCDNPreLoad;

	public bool IsBackpackDirty
	{
		get
		{
			return _003CIsBackpackDirty_003Ek__BackingField;
		}
		set
		{
			_003CIsBackpackDirty_003Ek__BackingField = value;
		}
	}

	public string ReleaseVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static implicit operator BaseProfileInfo(FriendAccountInfoData friendInfoData)
	{
		return null;
	}

	public static implicit operator BaseProfileInfo(FriendAccountInfo friendInfo)
	{
		return null;
	}

	public static implicit operator BaseProfileInfo(FriendInfo friendInfo)
	{
		return null;
	}

	public static implicit operator BaseProfileInfo(AccountInfoBasic basicInfo)
	{
		return null;
	}

	public BaseProfileInfo(AccountInfoBasic basicInfo)
	{
	}

	private static void ProcessSocialHighlight(BaseProfileInfo info, List<proto.SocialHighLight> socialhighlights)
	{
	}

	public static implicit operator BaseProfileInfo(GroupMemberInfo basicInfo)
	{
		return null;
	}

	public static implicit operator BaseProfileInfo(RoomPlayerInfo data)
	{
		return null;
	}

	public BaseProfileInfo(EGLJDBDMENB loginInfo)
	{
	}

	public BaseProfileInfo(UGCPlayerStats data)
	{
	}

	public BaseProfileInfo(TeammateStats data)
	{
	}

	public static implicit operator BaseProfileInfo(TextMsgReq chatMsg)
	{
		return null;
	}

	public BaseProfileInfo()
	{
	}

	public void ResetMyWeapons()
	{
	}

	public void ResetMyFinalShots()
	{
	}

	public void ResetMyVehicleSkins()
	{
	}

	public void RefreshMyShows(uint[] arr)
	{
	}

	public void RefreshGameBagId(uint id)
	{
	}

	public uint GetGameBagShowId()
	{
		return 0u;
	}

	public uint GetShowWeapon()
	{
		return 0u;
	}

	public bool IsFinalShotEquipped(FinalShotInfo info)
	{
		return false;
	}

	public uint GetShowTransformer()
	{
		return 0u;
	}

	public uint GetGroupAnim()
	{
		return 0u;
	}

	public void RefreshEmoteSlots(ChoosedEmotes _choosedEmote)
	{
	}

	public void ChangeEmoteSlots(CSGetSelectedItemsRes res)
	{
	}

	public void ChangeEquipSuperEmote(uint id)
	{
	}

	public void ChangeEquipSuperEmoteForSocialLobby(uint id)
	{
	}

	public void ChangeEquipFinishMove(uint id)
	{
	}

	public uint GetUnEquipEmoteSlotIndex(uint _id)
	{
		return 0u;
	}

	public List<uint> GetAllUnEquipEmoteSlot()
	{
		return null;
	}

	public uint GetEmoteSlotIndex(uint id)
	{
		return 0u;
	}

	public void ResetAllSlots()
	{
	}

	public void RefreshSlots(uint[] slots)
	{
	}

	public void RefreshFinalShots(uint[] finalshots)
	{
	}

	public void RefreshPveWeaponSkin(List<PveSlotInfo> slots)
	{
	}

	public uint GetEquipedAction(CSSharedItemDataManager.CollectionSubType collectionSubType)
	{
		return 0u;
	}

	public List<uint> GetAllEquipedAction()
	{
		return null;
	}

	public void RefreshCollectionAction(uint[] actions)
	{
	}

	private void InitCollectionAction()
	{
	}

	public void ResetCollectionAction()
	{
	}

	public uint EmoteEquippedCount()
	{
		return 0u;
	}

	public List<uint> GetEquipedEmoteIdList()
	{
		return null;
	}

	public bool HasUnlockTailorEffectByItemID(uint itemID)
	{
		return false;
	}

	public void RefreshCollectionSkillData(uint[] equipedSkillEffects)
	{
	}

	public void RefreshTempSkillEffect()
	{
	}

	public bool InSceneEdit()
	{
		return false;
	}
}
