using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelLeaderBoardTitle : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public UIModelLeaderBoardTitle _003C_003E4__this;

		public string cmd;

		internal void _003CRequestAllLeaderBoardTitleInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public UIModelLeaderBoardTitle _003C_003E4__this;

		public ulong accountId;

		internal void _003CRequestGetAreaLeaderboardTitleRecord_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	public const uint PropID_ChooseLeaderBoardTitle = 1u;

	public const uint PropID_GetAllLeaderBoardTitleInfo = 2u;

	public const uint PropID_WeaponPowerTitleReady = 4u;

	public const uint PropID_ClanWarTitleReady = 8u;

	public const uint PropID_AreaTitleReady = 16u;

	public const uint PropID_AllLeaderBoardTitleReady = 32u;

	public const uint ALL_LEADERBOARD_TITLE_READY = 156u;

	public const uint PropID_AreaLeaderboardTitleRecordReady = 64u;

	public const uint PropID_PeakTitleReady = 128u;

	public bool GotAllLeaderBoardTitleInfo;

	private long m_ChooseAreaNextEffectTime;

	private uint m_AllLeaderBoardTitleReadyFlag;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelLadderMatch m_ModeLadderMatch;

	private UIModelCSLadderMatch m_ModeCSLadderMatch;

	private Dictionary<uint, LeaderBoardTitleConfigData> m_TitleConfigData;

	private Dictionary<uint, ResourceID> m_IconResIdDict;

	private Dictionary<uint, ResourceID> m_CommonBGResIdDict;

	private Dictionary<uint, ResourceID> m_IconVFXDict;

	private Dictionary<uint, ResourceID> m_SingleBGResIdDict;

	private Dictionary<uint, Vector3> m_IconScaleDict;

	private Dictionary<uint, ResourceID> m_ClanWarTitleBigIcon;

	private Dictionary<uint, ResourceID> m_ClanWarTitleBarIcon;

	public static string CLAN_TITLE_NAME;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private readonly Dictionary<ulong, List<WeaponPowerPlayerTitleInfo>> m_BRWeaponTitleOwnDic;

	private readonly Dictionary<ulong, List<WeaponPowerPlayerTitleInfo>> m_CSWeaponTitleOwnDic;

	private readonly Dictionary<ulong, List<RankingPlayerTitleInfo>> m_BRRankingTitleOwnDic;

	private readonly Dictionary<ulong, List<RankingPlayerTitleInfo>> m_CSRankingTitleOwnDic;

	private readonly Dictionary<ulong, List<CSPeakPlayerTitleInfo>> m_PeakTitleOwnDic;

	private readonly Dictionary<ulong, List<proto.GuildWarPlayerTitleInfo>> m_ClanTitleOwnDic;

	private Dictionary<ulong, uint> AreaLeaderboardTitleRecordTSDic;

	private Dictionary<ulong, CSGetAreaLeaderboardTitleRecordRes> AreaLeaderboardTitleRecordResCache;

	private Dictionary<uint, List<WeaponPowerTitleRecordInfo>> ProcessHighestWeaponTitleTmpDicBR;

	private Dictionary<uint, List<WeaponPowerTitleRecordInfo>> ProcessHighestWeaponTitleTmpDicCS;

	public uint AllLeaderBoardTitleReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public long ChooseAreaNextEffectTime => 0L;

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(tcp.LeaderboardTitleInfo titleInfos, ELeaderboardTitleShowOrder order, ELeaderBoardTitleBgType bgType, TitleAccountParams titleAccountParams, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE, NIKKALKPIBO gameMode = NIKKALKPIBO.EGAMEMODE_NONE)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(tcp.RankingTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(tcp.CSPeakTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(tcp.WeaponPowerTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(tcp.GuildWarTitleInfo titleInfo)
	{
		return null;
	}

	public tcp.LeaderboardTitleInfo GetTcpSelectedLeaderboardTitleInfo()
	{
		return null;
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(proto.LeaderboardTitleInfo titleInfos, ELeaderboardTitleShowOrder order, ELeaderBoardTitleBgType bgType, TitleAccountParams titleAccountParams, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE, NIKKALKPIBO gameMode = NIKKALKPIBO.EGAMEMODE_NONE)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(proto.RankingTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(proto.CSPeakTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(proto.WeaponPowerTitleInfo titleInfo)
	{
		return null;
	}

	private InGameLeaderBoardTitleInfo ConvertToInGameLeaderBoardTitleInfo(proto.GuildWarTitleInfo titleInfo)
	{
		return null;
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(proto.RankingTitleInfo info, ELeaderBoardTitleBgType bgType, bool ignoreExpire = false)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(proto.CSPeakTitleInfo info, ELeaderBoardTitleBgType bgType, bool ignoreExpire = false)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(proto.WeaponPowerTitleInfo info, ELeaderBoardTitleBgType bgType, bool ignoreExpire = false)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(proto.GuildWarTitleInfo info, ELeaderBoardTitleBgType bgType, bool ignoreExpire = false)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public proto.LeaderboardTitleInfo GetProtoSelectedLeaderboardTitleInfo()
	{
		return null;
	}

	public ChoosedLeaderBoardTitleIDs GetProtoSelectedLeaderBoardTitleIDs()
	{
		return null;
	}

	public InGameLeaderBoardTitleInfo GetTargetInGameLeaderBoardTitleInfoByOrder(List<InGameLeaderBoardTitleInfo> infos, ELeaderboardTitleShowOrder order, DLBMPCCFKKM matchMode, bool isFirstRankTitleReceive, bool isFirstPeakTitleReceive)
	{
		return null;
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(InGameLeaderBoardTitleInfo info, ELeaderBoardTitleBgType bgType, TitleAccountParams titleAccountParams = null, ELeaderboardTitleShowOrder order = ELeaderboardTitleShowOrder.AccordingToLevelAndRank, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE, bool ignoreExpire = false)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public LeaderBoardTitleShowingParams GetLeaderBoardTitleShowingParams(VetBarrageInfo info, ELeaderBoardTitleBgType bgType)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	private string GetWeaponNameByWeaponID(uint weaponID)
	{
		return null;
	}

	public string GetRankNameByTitleType(ELeaderBoardTitleType type, ELeaderBoardTitleBgType bgType = ELeaderBoardTitleBgType.Common)
	{
		return null;
	}

	public string GetGMNameByTitleCfgID(ELeaderBoardTitleIconType type, ELeaderBoardTitleBgType bgType = ELeaderBoardTitleBgType.Common)
	{
		return null;
	}

	public ELeaderBoardTitleIconType GetGmIconType(bool isBR)
	{
		return ELeaderBoardTitleIconType.NONE;
	}

	public InGameLeaderBoardTitleInfo GetBetterTitleInfo(InGameLeaderBoardTitleInfo a, InGameLeaderBoardTitleInfo b)
	{
		return null;
	}

	public bool IsForceShowRankInfo(InGameLeaderBoardTitleInfo rankInfo, bool isFirstRankTitleReceive)
	{
		return false;
	}

	public bool IsForceShowPeakInfo(InGameLeaderBoardTitleInfo peakInfo, bool isFirstPeakTitleReceive)
	{
		return false;
	}

	public Vector3 GetIconScaleByScaleType(ELeaderBoardTitleIconScale scale)
	{
		return default(Vector3);
	}

	public ResourceID GetCommonBGResIdByType(uint iconType)
	{
		return default(ResourceID);
	}

	public ResourceID GetSingleBGResIdByType(uint iconType)
	{
		return default(ResourceID);
	}

	public ResourceID GetIconVFXByType(uint iconType)
	{
		return default(ResourceID);
	}

	public Color GetIconLabelColorByType(uint iconType)
	{
		return default(Color);
	}

	public Color GetIconShadowLabelColorByType(uint iconType)
	{
		return default(Color);
	}

	public ResourceID GetIconResIdByType(uint iconType)
	{
		return default(ResourceID);
	}

	public ResourceID GetClanWarTitleBigIconResIdByType(uint iconType)
	{
		return default(ResourceID);
	}

	public ResourceID GetClanWarTitleBarIconResIdByType(uint iconType)
	{
		return default(ResourceID);
	}

	public ELeaderBoardTitleType GetLeaderBoardTitleType(uint iconType)
	{
		return ELeaderBoardTitleType.None;
	}

	public uint GetLeaderBoardTitlePriority(uint iconType)
	{
		return 0u;
	}

	public ELeaderboard.LeaderboardMainType GetLeaderBoardTypeByInGameTitleInfo(InGameLeaderBoardTitleInfo inGameTitleInfo)
	{
		return ELeaderboard.LeaderboardMainType.Leaderboard_REGULAR;
	}

	public List<RankingPlayerTitleInfo> GetBRSortedRankingTitleInfoList()
	{
		return null;
	}

	public List<RankingPlayerTitleInfo> GetCSSortedRankingTitleInfoList()
	{
		return null;
	}

	public List<CSPeakPlayerTitleInfo> GetCSSortedPeakRankingTitleInfoList()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetBRSortedWeaponTitleInfoList()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetCSSortedWeaponTitleInfoList()
	{
		return null;
	}

	public List<proto.GuildWarPlayerTitleInfo> GetSortedClanTitleInfoList()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetSelectedRankTitleInfo(ELeaderBoardTitleType titleType)
	{
		return null;
	}

	public CSPeakPlayerTitleInfo GetSelectedPeakTitleInfo(ELeaderBoardTitleType titleType)
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetSelectedWeaponTitleInfo(ELeaderBoardTitleType titleType)
	{
		return null;
	}

	public proto.GuildWarPlayerTitleInfo GetSelectedClanTitleInfo()
	{
		return null;
	}

	public bool CheckCanShowTitleCtrl(uint iconType, ulong expireTime)
	{
		return false;
	}

	public bool CheckCanShowBooyahBountyTitle(string titleKey)
	{
		return false;
	}

	public bool HasGrandMasterTitleInHud(uint peakRankPos)
	{
		return false;
	}

	public bool HasGrandMasterTitle(uint peakRankPos, bool isBR)
	{
		return false;
	}

	public TitleAccountParams GetGrandMasterTitleAccountParams(ulong accountID, uint peakRankPos, string region)
	{
		return null;
	}

	public bool IsReady()
	{
		return false;
	}

	public void UpdateSocialBasicInfoByLeaderBoardTitles(ChoosedLeaderBoardTitleIDs ids)
	{
	}

	public static List<AreaLeaderboardSelectTitle> ConstructRankingSelectedTitleIDs(List<Vector2Int> rankingTitleIDs)
	{
		return null;
	}

	public static uint[] ConstructPeakSelectedTitleIDs(List<uint> peakTitleIDs)
	{
		return null;
	}

	public static uint[] ConstructWeaponPowerSelectedTitleIDs(List<uint> weaponTitleIDs)
	{
		return null;
	}

	public static uint[] ConstructClanSelectedTitleIDs(List<uint> clanTitleIDs)
	{
		return null;
	}

	public void RefreshTitleSelectedState()
	{
	}

	public void RequestLeasderBoardTitleAllMessage(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestAllLeaderBoardTitleInfo(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public ResourceID GetLeaderboardIcon(uint titleConfigID)
	{
		return default(ResourceID);
	}

	public void RequestGetAreaLeaderboardTitleRecord(ulong accountId, bool isForce = false)
	{
	}

	public void ProcessHighestWeaponTitleRecord(WeaponPowerTitleRecords weaponTitleRecords, ref List<HighestTitleShowParams> brHighestWeaponTitleList, ref List<HighestTitleShowParams> csHighestWeaponTitleList)
	{
	}

	public CSGetAreaLeaderboardTitleRecordRes GetAreaLeaderboardTitleRecordByAccId(ulong accountId)
	{
		return null;
	}

	private int SortWeaponPowerPlayerTitleList(WeaponPowerTitleRecordInfo a, WeaponPowerTitleRecordInfo b)
	{
		return 0;
	}

	public void ProcessHighestPeakTitleRecord(CSPeakTitleRecords peakTitleRecords, ref HighestTitleShowParams csHighestPeakTitle)
	{
	}

	public void ProcessHighestRankTitleRecord(RankingTitleRecords rankingTitleRecords, ref HighestTitleShowParams brHighestRankTitle, ref HighestTitleShowParams csHighestRankTitle)
	{
	}

	private bool ComparePeakTitleRecordInfo(CSPeakTitleRecordInfo a, CSPeakTitleRecordInfo b)
	{
		return false;
	}

	private bool CompareRankingTitleRecordInfo(RankingTitleRecordInfo a, RankingTitleRecordInfo b)
	{
		return false;
	}

	private void ProcessWeaponTitleOwn(List<WeaponPowerPlayerTitleInfo> weaponPowerTitleOwn, ulong accountID)
	{
	}

	private void ProcessRankingTitleOwn(List<RankingPlayerTitleInfo> rankingTitleOwn, ulong accountID)
	{
	}

	private void ProcessPeakTitleOwn(List<CSPeakPlayerTitleInfo> peakTitleOwn, ulong accountID)
	{
	}

	private void ProcessClanTitleOwn(List<proto.GuildWarPlayerTitleInfo> clanTitleOwn, ulong accountID)
	{
	}

	public List<proto.GuildWarPlayerTitleInfo> GetClanTitleOwnList(ulong accountID)
	{
		return null;
	}

	public int GetHigherTitle(RankingPlayerTitleInfo rankingTitle, WeaponPowerPlayerTitleInfo weaponTitle)
	{
		return 0;
	}

	public SelectLeaderBoardTitleInfo GetHigherTitle(SelectLeaderBoardTitleInfo selectTitle1, SelectLeaderBoardTitleInfo selectTitle2)
	{
		return null;
	}

	public SelectLeaderBoardTitleInfo ConvertToSelectLeaderBoardTitleInfo(RankingPlayerTitleInfo info, bool isNew)
	{
		return null;
	}

	public SelectLeaderBoardTitleInfo ConvertToSelectLeaderBoardTitleInfo(WeaponPowerPlayerTitleInfo info, bool isNew)
	{
		return null;
	}

	public SelectLeaderBoardTitleInfo ConvertToSelectLeaderBoardTitleInfo(CSPeakPlayerTitleInfo info, bool isNew)
	{
		return null;
	}

	public void SetAutoSelectTitle()
	{
	}

	private void AutoSelectTitle()
	{
	}

	private void SetSelectedTopTitle()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
