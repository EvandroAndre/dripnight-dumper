using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIModelSpectator : UIBaseModel
{
	public enum InfoTab
	{
		Player,
		AirDrop
	}

	public class TeamWinInfo
	{
		public byte teamID;

		public byte winReason;

		public TeamWinInfo(byte teamID, byte winReason)
		{
		}
	}

	public class PlayerInShopBuySyncToSpectatorEvt : GEvent
	{
		public BHGGAEEHJCO id;

		public List<uint> itemIds;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PlayerData> _003C_003E9__93_0;

		public static Func<TeamData, byte> _003C_003E9__97_1;

		public static Comparison<PlayerData> _003C_003E9__148_0;

		public static Comparison<ResultTeamData> _003C_003E9__159_0;

		public static Comparison<ResultTeamData> _003C_003E9__161_0;

		public static Comparison<AccTeamData> _003C_003E9__168_0;

		public static Comparison<RankingTeamData> _003C_003E9__181_0;

		public static Comparison<RankingTeamData> _003C_003E9__182_0;

		internal int _003COnAddPlayer_003Eb__93_0(PlayerData a, PlayerData b)
		{
			return 0;
		}

		internal byte _003CSortTeams_003Eb__97_1(TeamData a)
		{
			return 0;
		}

		internal int _003COnAddRejoinDeadPlayer_003Eb__148_0(PlayerData a, PlayerData b)
		{
			return 0;
		}

		internal int _003CGenerateSpectatorMatchResult_003Eb__159_0(ResultTeamData a, ResultTeamData b)
		{
			return 0;
		}

		internal int _003CGenerateResult_003Eb__161_0(ResultTeamData a, ResultTeamData b)
		{
			return 0;
		}

		internal int _003COnTeamScoreChanged_003Eb__168_0(AccTeamData a, AccTeamData b)
		{
			return 0;
		}

		internal int _003CSortRankingTeamListByLiving_003Eb__181_0(RankingTeamData a, RankingTeamData b)
		{
			return 0;
		}

		internal int _003CSortRankingTeamListByCombatLevel_003Eb__182_0(RankingTeamData a, RankingTeamData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public PlayerData data;

		internal bool _003CGetTeamKillCount_003Eb__0(RankingTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public AccTeamData team;

		internal bool _003CGetTeamKillCount_003Eb__0(RankingTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass161_0
	{
		public PlayerData data;

		internal bool _003CGenerateResult_003Eb__1(ResultTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass164_0
	{
		public UIModelSpectator _003C_003E4__this;

		public int i;

		public Predicate<ResultTeamData> _003C_003E9__0;

		internal bool _003CGenerateTeamWinNum_003Eb__0(ResultTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass167_0
	{
		public AccTeamData data;

		internal bool _003COnTeamScoreInited_003Eb__0(RankingTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public PDGOEKNGFBG team;

		internal bool _003COnTeamScoreChanged_003Eb__1(AccTeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public ANAJCEIHLAL teams;

		internal bool _003CUpdateCombatLevelInfo_003Eb__0(TeamData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_1
	{
		public TeamData team;

		internal bool _003CUpdateCombatLevelInfo_003Eb__1(RankingTeamData a)
		{
			return false;
		}
	}

	private InfoTab _003CCurrentInfoTab_003Ek__BackingField;

	private List<byte> m_TeamList;

	private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

	private Dictionary<BHGGAEEHJCO, PlayerData> m_PlayerDic;

	private List<TeamData> m_TeamDataList;

	public Dictionary<BHGGAEEHJCO, PlayerHudOperate> PlayerHudOperateDic;

	private List<RankingTeamData> m_RankingTeamDataList;

	private List<AccTeamData> m_AccTeamDataList;

	private Dictionary<int, TeamWinInfo> m_RoundResult;

	private Dictionary<BHGGAEEHJCO, List<PlayerKillInfo>> m_PlayerKillInfoList;

	private Dictionary<BHGGAEEHJCO, List<PlayerBestStatsData>> m_PlayerOutStandingStats;

	private Dictionary<BHGGAEEHJCO, Dictionary<string, HudConfigItem>> m_PlayerHudSetting;

	private Dictionary<BHGGAEEHJCO, PlayerSyncSetting> m_PlayerOtherSetting;

	public const uint PropID_PlayerAdded = 2u;

	public const uint PropID_AirDropChanged = 4u;

	public const uint PropID_PlayerDeleted = 8u;

	public const uint PropID_PlayerKillCountChanged = 16u;

	public const uint PropID_PlayerRemainingCountChanged = 32u;

	public const uint PropID_SpectatorRejoin = 128u;

	public const uint PropID_SafeZoneChanged = 256u;

	public const uint PropID_TeamAce = 512u;

	public const uint PropID_GameAchievement = 1024u;

	public const uint PropID_ScoreChanged = 2048u;

	public const uint PropID_PlayerRankGet = 4096u;

	public const uint PropID_CombatLevelUpdated = 8192u;

	public const uint PropID_PlayerDeadCountChanged = 16384u;

	public const uint PropID_PlayerAssistCountChanged = 32768u;

	public const uint PropID_LiveCountChanged = 65536u;

	public const uint PropID_ReviveChanged = 131072u;

	public const uint PropID_TeamWinRateChange = 262144u;

	public const uint PropID_PCGameAchievement = 524288u;

	public bool HasPlayerDead;

	public List<Transform> ResultShowPositionList;

	private Dictionary<uint, AirdropInfo> m_Airdrops;

	private Dictionary<uint, Vector3> m_AirdopsPos;

	public List<AirdropInfo> m_AirDropsList;

	private List<PlayerData> m_DeadOrderList;

	private List<ResultTeamData> m_MatchResult;

	private ResultMVPInfo m_MVPInfo;

	private int m_RemainingPlayerCount;

	private bool _003CGroupIconEnabled_003Ek__BackingField;

	private BHGGAEEHJCO m_currentKillLeaderPlayerID;

	private BHGGAEEHJCO _003CCurrentKillLeaderPlayerID_003Ek__BackingField;

	private bool _003CPetSkillVisible_003Ek__BackingField;

	public int FirstPerspective;

	public int WatchBattlePerspective;

	public float UI_PLAYER_ITEM_HEIGHT;

	private bool m_ShowTargetPlayerHud;

	private List<BHGGAEEHJCO> m_KingOfKiller_Player;

	private byte m_KingOfKiller_Team;

	private float m_BattleCheckedTime;

	private HashSet<byte> m_InBattleTeams;

	private List<ReplayEvent> m_ReplayEventList;

	private BitArrayBoolean m_InputBlock;

	public const uint INPUT_BLCOK_VIDEO_UI_FOUCUSED = 1u;

	public const uint INPUT_BLOCK_CHAT = 2u;

	public InfoTab CurrentInfoTab
	{
		get
		{
			return _003CCurrentInfoTab_003Ek__BackingField;
		}
		set
		{
			_003CCurrentInfoTab_003Ek__BackingField = value;
		}
	}

	public List<byte> TeamList => null;

	public Dictionary<BHGGAEEHJCO, PlayerData> PlayerDic => null;

	public List<TeamData> TeamDataList => null;

	public List<RankingTeamData> RankingTeamDataListByLiving => null;

	public List<RankingTeamData> RankingTeamDataByCombatLevel => null;

	public List<AccTeamData> AccTeamDataList => null;

	public Dictionary<int, TeamWinInfo> RoundResult => null;

	public Dictionary<uint, AirdropInfo> Airdrops => null;

	public List<AirdropInfo> AirdropsList => null;

	public List<ResultTeamData> MatchResult => null;

	public int RemainPlayer => 0;

	public bool GroupIconEnabled
	{
		get
		{
			return _003CGroupIconEnabled_003Ek__BackingField;
		}
		set
		{
			_003CGroupIconEnabled_003Ek__BackingField = value;
		}
	}

	public BHGGAEEHJCO CurrentKillLeaderPlayerID
	{
		get
		{
			return _003CCurrentKillLeaderPlayerID_003Ek__BackingField;
		}
		set
		{
			_003CCurrentKillLeaderPlayerID_003Ek__BackingField = value;
		}
	}

	public bool PetSkillVisible
	{
		get
		{
			return _003CPetSkillVisible_003Ek__BackingField;
		}
		set
		{
			_003CPetSkillVisible_003Ek__BackingField = value;
		}
	}

	public bool ShowTargetPlayerHud
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<BHGGAEEHJCO> KingOfKiller_Player => null;

	public byte KingOfKiller_Team => 0;

	public void AddRoundResult(int round, byte winTeamId, byte winReason)
	{
	}

	public List<PlayerKillInfo> GetPlayerKillInfo(BHGGAEEHJCO id)
	{
		return null;
	}

	public List<PlayerBestStatsData> GetPlayerOutStandingStats(BHGGAEEHJCO pId)
	{
		return null;
	}

	public void SetPlayerOutStandingStats(BHGGAEEHJCO pId, List<EDJIAOHGIIN> gsStats)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void StartMatch()
	{
	}

	public void OnAddPlayer(Player player)
	{
	}

	public void OnDelPlayer(BHGGAEEHJCO id, BHGGAEEHJCO killerId, Vector3 last_position, Vector3 last_forward, bool pendingRevive)
	{
	}

	public void UpdateReviveInfo(Player p)
	{
	}

	public void OnHandlePlayerKillInfo(BHGGAEEHJCO bekillid, BHGGAEEHJCO damager, int weaponID)
	{
	}

	public void SortTeams()
	{
	}

	private bool IsTeamDead(TeamData team)
	{
		return false;
	}

	public void OnAlivePlayerCountChanged(int remainingPlayers)
	{
	}

	public void UpdatePlayerHudOperate(List<PJJKNKFHGDP> list)
	{
	}

	public void UpdatePlayerHudSetting(BHGGAEEHJCO pid, byte[] bytes, uint hudIndex, bool leftFire, float notchSize)
	{
	}

	public Dictionary<BHGGAEEHJCO, Dictionary<string, HudConfigItem>> GetTargetPlayerHudData()
	{
		return null;
	}

	public PlayerSyncSetting GetTargetPlayerOtherSetting()
	{
		return null;
	}

	public void OnUpdatePlayerKillCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerDeadCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerAssistCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerTotalDamage(BHGGAEEHJCO id, uint oldValue, uint newValue)
	{
	}

	public void OnUpdatePlayerFactionID(BHGGAEEHJCO id, int factionID)
	{
	}

	public void OnUpdatePlayerKnockDownCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerHealingAmount(BHGGAEEHJCO id, uint oldValue, uint newValue)
	{
	}

	public void OnUpdatePlayerResurrectTeammateCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerRevivalCount(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdateKnockDownRealDamage(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerHeadShootKill(BHGGAEEHJCO id, byte oldValue, byte newValue)
	{
	}

	public void OnUpdatePlayerCSRatingPoint(BHGGAEEHJCO id, float oldValue, float newValue)
	{
	}

	public void OnUpdatePlayerIsTeamMVP(BHGGAEEHJCO id, bool oldValue, bool newValue)
	{
	}

	public void UpdatePlayerTokenCount(BHGGAEEHJCO id, int oldValue, int newValue)
	{
	}

	public int GetPlayerTokenCount(BHGGAEEHJCO id)
	{
		return 0;
	}

	public void OnUpdateTeamWinNum(byte teamID, uint newValue)
	{
	}

	public void OnUpdateTeamWinNum(BHGGAEEHJCO id, uint newValue)
	{
	}

	public Player GetNextLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetPrevLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetTeamNextLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetTeamPrevLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetNextTeamLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetPrevTeamLivePlayer(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public Player GetRandomPlayer()
	{
		return null;
	}

	public Player GetFirtstLivePlayerByTeamId(int teamId)
	{
		return null;
	}

	public Player GetLivePlayerByTeamIdAndPlayerIndex(int teamId, int playerIndex)
	{
		return null;
	}

	public Player GetPlayerByTeamIdAndPlayerIndexStrict(int teamId, int playerIndex)
	{
		return null;
	}

	public List<PlayerData> GetPlayerListFromTeamId(byte team)
	{
		return null;
	}

	public PlayerData GetPlayerData(BHGGAEEHJCO id)
	{
		return null;
	}

	public PlayerData GetPlayerDataByUserId(ulong userId)
	{
		return null;
	}

	public bool IsCSTeamOnLeft(BHGGAEEHJCO id)
	{
		return false;
	}

	public int GetPlayerCount()
	{
		return 0;
	}

	public uint GetTeamKillCount(BHGGAEEHJCO player)
	{
		return 0u;
	}

	public uint GetTeamKillCount(AccTeamData team)
	{
		return 0u;
	}

	public void OnGameAchievementNotify(BHGGAEEHJCO killerId, BHGGAEEHJCO beKilledId, int weaponDataId, List<uint> type)
	{
	}

	public void OnPCGameAchievementNotify(List<KOMCOKBONAG> detail)
	{
	}

	public void OnWinRateNotify(List<KDMIOCKDHNP> teamWinRate)
	{
	}

	public bool IsKingofKillPlayer(BHGGAEEHJCO pid)
	{
		return false;
	}

	public void OnAddRejoinDeadPlayer(List<HJEPOCAELMC> deadPlayerInfos)
	{
	}

	public void AddPickup(uint objID, ICLMFONIIKB pickup, Vector3 position)
	{
	}

	public void DelPickup(uint objID, ICLMFONIIKB pickup)
	{
	}

	public Vector3 GetPickupPositionByIndex(int index)
	{
		return default(Vector3);
	}

	public int GetPickupCount()
	{
		return 0;
	}

	public int GetRandomPickupIndex()
	{
		return 0;
	}

	public void AddAirdrop(uint objID, Vector3 position)
	{
	}

	public uint CalculateTriggerContainerID(Vector3 position)
	{
		return 0u;
	}

	private Dictionary<uint, int> ConstructItemDic()
	{
		return null;
	}

	public void ChangePlayerItem(BHGGAEEHJCO id, JJKGBAKMNDI type, int count)
	{
	}

	public void SpectatorJoinChangePlayerItem(LFFBMLIGAKP msg)
	{
	}

	public void GenerateSpectatorMatchResult(AEOFDLOIGCP msg)
	{
	}

	public List<PlayerData> GetMatchWinnerPlayerData()
	{
		return null;
	}

	public List<ResultTeamData> GenerateResult()
	{
		return null;
	}

	public int SortNormalMatchTeammateData(ResultPlayerData player1, ResultPlayerData player2)
	{
		return 0;
	}

	public ResultMVPInfo GetMatchMvpInfo()
	{
		return null;
	}

	private void GenerateTeamWinNum()
	{
	}

	public void RegisterUIShowPosition(Transform transform)
	{
	}

	public void UnRegisterUIShowPosition(Transform transform)
	{
	}

	public void OnTeamScoreInited(List<CCNHOJOOAKK> teams)
	{
	}

	public void OnTeamScoreChanged(List<PDGOEKNGFBG> teams)
	{
	}

	public void OnPlayerRankGet(EAJFIONFKKM msg)
	{
	}

	public void UpdateCombatLevelInfo(BPGGOGDFCEA msg)
	{
	}

	public void OnBattleDetected(BHGGAEEHJCO damager, BHGGAEEHJCO beDamaged, APELCIGCHDJ.FKMOGIEDEBD type)
	{
	}

	private bool IsValidDamage(BHGGAEEHJCO damager, BHGGAEEHJCO beDamaged, APELCIGCHDJ.FKMOGIEDEBD type)
	{
		return false;
	}

	public void RecordMatchInfo()
	{
	}

	private void LogToFile()
	{
	}

	public void LogReplayEvent(NBAOHLPEKCG evt, BHGGAEEHJCO id, float time = 0f, float fparam = 0f, string sparam = "")
	{
	}

	public List<ReplayEvent> GetReplayEvents()
	{
		return null;
	}

	private Color GetCurrentTeamColor(byte id)
	{
		return default(Color);
	}

	private void SortRankingTeamListByLiving()
	{
	}

	private void SortRankingTeamListByCombatLevel()
	{
	}

	private void CalculateTeamScore()
	{
	}

	public bool LoadDirectoryBGImage(UITexture bgTexture)
	{
		return false;
	}

	public bool LoadPCTextures(UITexture texture, string dirName, string picName)
	{
		return false;
	}

	public void SetInputBlockValue(uint flag, bool val)
	{
	}

	public bool IsInputBlock()
	{
		return false;
	}

	public void PlayerInShopBuySyncToSpectator(BHGGAEEHJCO id, List<uint> itemIds)
	{
	}

	private int _003CSortTeams_003Eb__97_0(TeamData a, TeamData b)
	{
		return 0;
	}
}
