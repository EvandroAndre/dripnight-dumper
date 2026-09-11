using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

internal class UIModelSeasonReplay : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RankingSeasonFriendStats> _003C_003E9__81_1;

		public static Comparison<RankingSeasonFriendStats> _003C_003E9__84_1;

		public static Comparison<RankingSeasonRankRecord> _003C_003E9__97_0;

		public static Comparison<RankingSeasonRankRecord> _003C_003E9__97_1;

		public static Comparison<RankingSeasonReplayEvent> _003C_003E9__98_0;

		public static Comparison<RankingSeasonReplayEvent> _003C_003E9__98_1;

		public static Comparison<SeasonReplayFriendData> _003C_003E9__112_0;

		public static Comparison<SeasonReplayFriendData> _003C_003E9__120_0;

		public static Predicate<SeasonReplayFriendData> _003C_003E9__123_0;

		public static Predicate<SeasonReplayFriendData> _003C_003E9__123_1;

		public static Comparison<SeasonReplayFriendData> _003C_003E9__123_2;

		public static Comparison<SeasonReplayFriendData> _003C_003E9__130_0;

		internal int _003CRequestGetCSRankingMatchSeasonReplay_003Eb__81_1(RankingSeasonFriendStats a, RankingSeasonFriendStats b)
		{
			return 0;
		}

		internal int _003CRequestGetBRRankingMatchSeasonReplay_003Eb__84_1(RankingSeasonFriendStats a, RankingSeasonFriendStats b)
		{
			return 0;
		}

		internal int _003CGetRankData_003Eb__97_0(RankingSeasonRankRecord x, RankingSeasonRankRecord y)
		{
			return 0;
		}

		internal int _003CGetRankData_003Eb__97_1(RankingSeasonRankRecord x, RankingSeasonRankRecord y)
		{
			return 0;
		}

		internal int _003CGetHighlightData_003Eb__98_0(RankingSeasonReplayEvent x, RankingSeasonReplayEvent y)
		{
			return 0;
		}

		internal int _003CGetHighlightData_003Eb__98_1(RankingSeasonReplayEvent x, RankingSeasonReplayEvent y)
		{
			return 0;
		}

		internal int _003CGetScoialFriendListDataBR_003Eb__112_0(SeasonReplayFriendData a, SeasonReplayFriendData b)
		{
			return 0;
		}

		internal int _003CGetBRSocialFriendListDataByTag_003Eb__120_0(SeasonReplayFriendData a, SeasonReplayFriendData b)
		{
			return 0;
		}

		internal bool _003CGetScoialFriendListDataCS_003Eb__123_0(SeasonReplayFriendData x)
		{
			return false;
		}

		internal bool _003CGetScoialFriendListDataCS_003Eb__123_1(SeasonReplayFriendData x)
		{
			return false;
		}

		internal int _003CGetScoialFriendListDataCS_003Eb__123_2(SeasonReplayFriendData a, SeasonReplayFriendData b)
		{
			return 0;
		}

		internal int _003CGetCSSocialFriendListDataByTag_003Eb__130_0(SeasonReplayFriendData a, SeasonReplayFriendData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public List<SeasonReplayFriendData> sortList;

		public int i;

		public Predicate<SeasonReplayFriendData> _003C_003E9__1;

		internal bool _003CGetFriendListShowDataByTag_003Eb__1(SeasonReplayFriendData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_1
	{
		public SeasonReplayFriendData data;

		internal bool _003CGetFriendListShowDataByTag_003Eb__0(SeasonReplayFriendData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public List<SeasonReplayFriendData> tmpList;

		internal bool _003CGetScoialFriendListDataBR_003Eb__1(SeasonReplayFriendData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public List<SeasonReplayFriendData> tmpList;

		internal bool _003CGetScoialFriendListDataCS_003Eb__3(SeasonReplayFriendData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public uint occupationId;

		internal bool _003CRequestGetCSRankingMatchSeasonReplay_003Eb__3(OccupationHistory x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public uint occupationId;

		internal bool _003CRequestGetBRRankingMatchSeasonReplay_003Eb__3(OccupationHistory x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public float evenDate;

		internal float _003CGetHighlightData_003Eb__2(RankingSeasonReplayEvent value)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public uint targetSkinId;

		internal bool _003CGetDestinyWeaponData_003Eb__0(WeaponSkinBaseInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass99_1
	{
		public uint targetSkinId;

		internal bool _003CGetDestinyWeaponData_003Eb__1(WeaponSkinBaseInfo o)
		{
			return false;
		}
	}

	private CSGetCSRankingMatchSeasonReplayRes m_CSRankingMatchSeasonReplayData;

	private CSGetBRRankingMatchSeasonReplayRes m_BRRankingMatchSeasonReplayData;

	private CSBattleStypeMapData m_BattleStyleCSData;

	private BRBattleStypeMapData m_BattleStyleBRData;

	public const int BattleStyleMapNum = 5;

	public static string[] CSFieldName;

	public static string[] BRFieldName;

	public Dictionary<uint, string> m_SeasonReplayUpwardDataTypeKey;

	public Dictionary<uint, int> m_SeasonReplayShowOccupationOrder;

	private bool m_RequestingBRReplayData;

	private bool m_RequestingCSReplayData;

	private float[] m_BattleStyleMapDataBR;

	private float[] m_BattleStyleMapDataCS;

	private int[] m_ExceedPercentageBR;

	private int[] m_ExceedPercentageCS;

	public uint CSSeasonID;

	public int CSRank;

	public uint CS_Rank_Master_Level;

	public uint CS_Peak_Rank_Pos;

	public uint BRSeasonID;

	public int BRRank;

	public uint BR_Rank_Master_Level;

	public uint BR_Peak_Rank_Pos;

	public uint ShareActivityId;

	public const uint PropID_SeasonReplayDataReadyCS = 2u;

	public const uint PropID_SeasonReplayDataReadyBR = 4u;

	private bool _003CAllowBRLadderMatchEntrance_003Ek__BackingField;

	private bool _003CAllowCSLadderMatchEntrance_003Ek__BackingField;

	private bool _003CAllowBRSplashEntrance_003Ek__BackingField;

	private bool _003CAllowCSSplashEntrance_003Ek__BackingField;

	private bool _003CHasShownBRSplash_003Ek__BackingField;

	private bool _003CHasShownCSSplash_003Ek__BackingField;

	private EDestinyWeaponType _003CBRDestinyWeaponType_003Ek__BackingField;

	private EDestinyWeaponType _003CCSDestinyWeaponType_003Ek__BackingField;

	private List<SeasonReplayFriendData> m_FriendDataListBR;

	private bool m_IsLoneWolfBR;

	private Dictionary<ulong, List<SeasonReplayFriendData>> m_AccountId2BRSocialFriendShowDataDic;

	private Dictionary<uint, List<SeasonReplayFriendData>> m_Tag2BRSocialFriendDataDic;

	private Dictionary<uint, List<List<SeasonReplayFriendData>>> m_Tag2BRSocialFriendShowDataDic;

	private List<SeasonReplayFriendData> m_FriendDataListCS;

	private bool m_IsLoneWolfCS;

	private Dictionary<ulong, List<SeasonReplayFriendData>> m_AccountId2CSSocialFriendShowDataDic;

	private Dictionary<uint, List<SeasonReplayFriendData>> m_Tag2CSSocialFriendDataDic;

	private Dictionary<uint, List<List<SeasonReplayFriendData>>> m_Tag2CSSocialFriendShowDataDic;

	private SeasonReplayFriendData FirstShowSocialFriend;

	public string SeasonReplayRedPointKeyBR => null;

	public string SeasonReplayRedPointKeyCS => null;

	public bool AllowBRLadderMatchEntrance
	{
		private get
		{
			return _003CAllowBRLadderMatchEntrance_003Ek__BackingField;
		}
		set
		{
			_003CAllowBRLadderMatchEntrance_003Ek__BackingField = value;
		}
	}

	public bool AllowCSLadderMatchEntrance
	{
		private get
		{
			return _003CAllowCSLadderMatchEntrance_003Ek__BackingField;
		}
		set
		{
			_003CAllowCSLadderMatchEntrance_003Ek__BackingField = value;
		}
	}

	public bool AllowBRSplashEntrance
	{
		get
		{
			return _003CAllowBRSplashEntrance_003Ek__BackingField;
		}
		set
		{
			_003CAllowBRSplashEntrance_003Ek__BackingField = value;
		}
	}

	public bool AllowCSSplashEntrance
	{
		get
		{
			return _003CAllowCSSplashEntrance_003Ek__BackingField;
		}
		set
		{
			_003CAllowCSSplashEntrance_003Ek__BackingField = value;
		}
	}

	public bool HasShownBRSplash
	{
		get
		{
			return _003CHasShownBRSplash_003Ek__BackingField;
		}
		set
		{
			_003CHasShownBRSplash_003Ek__BackingField = value;
		}
	}

	public bool HasShownCSSplash
	{
		get
		{
			return _003CHasShownCSSplash_003Ek__BackingField;
		}
		set
		{
			_003CHasShownCSSplash_003Ek__BackingField = value;
		}
	}

	public bool ShowBRSeasonReplayRedTip => false;

	public bool ShowCSSeasonReplayRedTip => false;

	public bool IsShowBRLadderMatchEntrance => false;

	public bool IsShowCSLadderMatchEntrance => false;

	public bool IsShowBRSplashEntrance => false;

	public bool IsShowCSSplashEntrance => false;

	public bool CanShowBRSplashEntrance => false;

	public bool CanShowCSSplashEntrance => false;

	public EDestinyWeaponType BRDestinyWeaponType
	{
		get
		{
			return _003CBRDestinyWeaponType_003Ek__BackingField;
		}
		private set
		{
			_003CBRDestinyWeaponType_003Ek__BackingField = value;
		}
	}

	public EDestinyWeaponType CSDestinyWeaponType
	{
		get
		{
			return _003CCSDestinyWeaponType_003Ek__BackingField;
		}
		private set
		{
			_003CCSDestinyWeaponType_003Ek__BackingField = value;
		}
	}

	public bool IsCanShareAward => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RequestGetCSRankingMatchSeasonReplay()
	{
	}

	private void CalculateDestinyWeaponType(bool isBR)
	{
	}

	private CSBattleStypeMapData CalcCSBattleStyleMapData(AccountInfoWithTCStats oriData)
	{
		return null;
	}

	public void RequestGetBRRankingMatchSeasonReplay(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private BRBattleStypeMapData CalcBRBattleStyleMapData(AccountInfoWithStatsToClient oriData)
	{
		return null;
	}

	public List<OccupationHistory> GetBRSeasonReplayRole()
	{
		return null;
	}

	public List<OccupationHistory> GetCSSeasonReplayRole()
	{
		return null;
	}

	public List<SeasonReplayUpwardData> GetCSSeasonReplayUpwardData()
	{
		return null;
	}

	public List<SeasonReplayUpwardData> GetBRSeasonReplayUpwardData()
	{
		return null;
	}

	private void ConstructorUpwardData(List<SeasonReplayUpwardData> list, SeasonReplayUpwardDataType type, uint preValue, uint curValue, bool isPercent = false)
	{
	}

	private void ConstructorUpwardData(List<SeasonReplayUpwardData> list, SeasonReplayUpwardDataType type, float preValue, float curValue, bool isPercent = false, string specifyKey = "")
	{
	}

	private int SeasonReplayUpwardDataSort(SeasonReplayUpwardData data1, SeasonReplayUpwardData data2)
	{
		return 0;
	}

	public bool IsDestinyWeaponShow(DLBMPCCFKKM matchMode)
	{
		return false;
	}

	public List<WeaponPowerTitleInfo> GetWeaponLeaderboardInfos(bool isBR)
	{
		return null;
	}

	public List<RankingSeasonLeaderboardInfo> GetRankingSeasonLeaderboardInfos(bool isBR)
	{
		return null;
	}

	public bool IsSocialShow(DLBMPCCFKKM matchMode)
	{
		return false;
	}

	public List<RankingSeasonRankRecord> GetRankData(bool isBR)
	{
		return null;
	}

	public List<RankingSeasonReplayEvent> GetHighlightData(bool isBR)
	{
		return null;
	}

	public List<DestinyWeaponData> GetDestinyWeaponData(bool isBR)
	{
		return null;
	}

	public List<ulong> GetReplaySocialNeedAvatarProfileId(bool isBR)
	{
		return null;
	}

	public bool IsAvatarProfileReadyByTag(bool isBR, ESeasonReplaySocialRelationTag tag)
	{
		return false;
	}

	public uint GetReplaySocialTemplateId(ESeasonReplaySocialRelationTag tag, int personCount)
	{
		return 0u;
	}

	public bool IsSeasonReplayPoseReadyByTag(bool isBR, ESeasonReplaySocialRelationTag tag)
	{
		return false;
	}

	public List<ResourceID> GetNeedDownloadResForReplaySocial(bool isBR)
	{
		return null;
	}

	public List<ResourceID> GetNeedDownloadResForReplaySocialByTag(bool isBR, ESeasonReplaySocialRelationTag tag)
	{
		return null;
	}

	public List<List<SeasonReplayFriendData>> GetFriendListShowDataByTag(bool isBr, ESeasonReplaySocialRelationTag tag)
	{
		return null;
	}

	public List<SeasonReplayFriendData> GetFriendListShowDataByTagAndAccountID(bool isBr, ESeasonReplaySocialRelationTag tag, ulong accountId)
	{
		return null;
	}

	public bool IsSocialLoneWolfBR()
	{
		return false;
	}

	public bool IsSocialLoneWolfCS()
	{
		return false;
	}

	public List<SeasonReplayFriendData> GetScoialFriendListDataBR(ref bool isLoneWolf)
	{
		return null;
	}

	private uint ProcessDataValue(RankingSeasonFriendStats stats)
	{
		return 0u;
	}

	public Dictionary<ulong, List<SeasonReplayFriendData>> GetAccountId2BRSocialFriendDataDic()
	{
		return null;
	}

	public List<SeasonReplayFriendData> GetBRSocialFriendListDataByAccountId(ulong accountId)
	{
		return null;
	}

	private void ProcessAccountId2BRSocialFriendDataDic()
	{
	}

	public List<SeasonReplayFriendData> GetBRSocialFriendListDataByTag(ESeasonReplaySocialRelationTag tag)
	{
		return null;
	}

	public List<SeasonReplayFriendData> GetScoialFriendListDataCS(ref bool isLoneWolf)
	{
		return null;
	}

	public Dictionary<ulong, List<SeasonReplayFriendData>> GetAccountId2CSSocialFriendDataDic()
	{
		return null;
	}

	public List<SeasonReplayFriendData> GetCSSocialFriendListDataByAccountId(ulong accountId)
	{
		return null;
	}

	private void ProcessAccountId2CSSocialFriendDataDic()
	{
	}

	public List<SeasonReplayFriendData> GetCSSocialFriendListDataByTag(ESeasonReplaySocialRelationTag tag)
	{
		return null;
	}

	public int SortSocialFriendsTmpList(SeasonReplayFriendData a, SeasonReplayFriendData b)
	{
		return 0;
	}

	public float[] GetBattleStyleMapDataCS()
	{
		return null;
	}

	public float[] GetBattleStyleMapDataBR()
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public float GetTopRanking(bool isBR)
	{
		return 0f;
	}

	public string GetRankNameByRank(bool isBR, int rank, uint rank_master_level)
	{
		return null;
	}

	private void _003CRequestGetCSRankingMatchSeasonReplay_003Eb__81_0(HttpErrorCode errodCode, object res)
	{
	}

	private int _003CRequestGetCSRankingMatchSeasonReplay_003Eb__81_2(OccupationHistory a, OccupationHistory b)
	{
		return 0;
	}

	private void _003CRequestGetBRRankingMatchSeasonReplay_003Eb__84_0(HttpErrorCode errodCode, object res)
	{
	}

	private int _003CRequestGetBRRankingMatchSeasonReplay_003Eb__84_2(OccupationHistory a, OccupationHistory b)
	{
		return 0;
	}

	private bool _003CGetCSSeasonReplayUpwardData_003Eb__88_0(CSPlayerCSRankingSeasonStatsRes x)
	{
		return false;
	}

	private bool _003CGetCSSeasonReplayUpwardData_003Eb__88_1(CSPlayerCSRankingSeasonStatsRes x)
	{
		return false;
	}

	private bool _003CGetBRSeasonReplayUpwardData_003Eb__89_0(CSPlayerRankingSeasonStatsRes x)
	{
		return false;
	}

	private bool _003CGetBRSeasonReplayUpwardData_003Eb__89_1(CSPlayerRankingSeasonStatsRes x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
