using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIModelBRMatchReview : UIBaseModel
{
	[Serializable]
	private class AssistReviewInfo
	{
		public string Version;

		public ulong AccountID;

		public ulong MatchID;

		public long EndTime;

		public long MatchDurationMs;

		public uint GameMode;

		public uint MatchMode;

		public bool GameAssistReviewRead;
	}

	public class TodayReviewAssistInfo
	{
		public ulong MatchID;

		public ulong EndMatchTimeStamp;

		public long MatchDurationMs;

		public uint GameMode;

		public uint MatchMode;

		public bool PostReviewHasRead;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<string> _003C_003E9__71_0;

		internal int _003CTrimToLimit_003Eb__71_0(string a, string b)
		{
			return 0;
		}
	}

	private const int DEFAULT_MAX_STORED = 10;

	private const string FIRST_GUIDE_KEY = "BRMatchReview_FirstGuide_";

	private const string GUIDE_BUBBLE_DAILY_COUNT_KEY = "BRMatchReview_GuideBubbleDailyCount_";

	private const string CACHE_VERSION_KEY = "BRMatchReview_CacheVersion";

	private const string ASSIST_REVIEW_INFO_FILE_SUFFIX = ".json";

	private const float DEFAULT_AUTO_SCALE_ACTIVE_WINDOW_SEC = 30f;

	private const float DEFAULT_AUTO_SCALE_SAFE_MARGIN_METER = 100f;

	private const float DEFAULT_AUTO_SCALE_DIFF_THRESHOLD_METER = 50f;

	private const float DEFAULT_AUTO_SCALE_STOP_THRESHOLD_METER = 10f;

	private const float DEFAULT_AUTO_SCALE_MANUAL_IDLE_SEC = 10f;

	private const float DEFAULT_AUTO_SCALE_MAX_SCALE = 4f;

	private const float DEFAULT_AUTO_SCALE_CENTER_LERP_ALPHA = 0.0328f;

	private const float DEFAULT_AUTO_SCALE_SCALE_LERP_ALPHA = 0.0328f;

	private const bool DEFAULT_PATH_IS_HIDDEN_AFTER_DEATH = true;

	public const uint PropID_DataLoaded = 1u;

	public const uint PropID_DataLoadFailed = 2u;

	private BRMatchReviewReceiver m_Receiver;

	private EIENIBNLACM m_MatchData;

	private ulong m_MatchID;

	private EBRMatchReviewChannel m_Channel;

	public EBRMatchReviewChannel Channel
	{
		get
		{
			return (EBRMatchReviewChannel)0;
		}
		set
		{
		}
	}

	public BRMatchReviewReceiver Receiver => null;

	private ulong CurrentAccountID => 0uL;

	public bool HasData => false;

	public int SavedMatchCount => 0;

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

	public BRMatchReviewClientData GetClientData()
	{
		return null;
	}

	public static BRMatchReviewAutoScaleConfig CreateAutoScaleConfig()
	{
		return null;
	}

	public static BRMatchReviewPathConfig CreatePathConfig()
	{
		return null;
	}

	public bool LoadMatchByID(ulong matchId, EBRMatchReviewChannel channel = EBRMatchReviewChannel.MatchResult)
	{
		return false;
	}

	public bool HasMatchID(ulong matchId)
	{
		return false;
	}

	public bool HasMatchData(ulong matchId)
	{
		return false;
	}

	public List<ulong> GetSavedMatchIDs()
	{
		return null;
	}

	public bool IsAssistReviewRead(ulong matchId)
	{
		return false;
	}

	public void MarkAssistReviewRead(ulong matchId, bool needRefreshAssistView = true)
	{
	}

	public List<TodayReviewAssistInfo> GetTodayAssistReviewInfos()
	{
		return null;
	}

	public string[] GetDiskMatchFiles()
	{
		return null;
	}

	public bool IsMatchReviewAvailableForMode(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool IsMatchReviewUnlocked()
	{
		return false;
	}

	public bool HasShownFirstGuide()
	{
		return false;
	}

	public void MarkFirstGuideShown()
	{
	}

	public bool CanShowGuideBubbleToday(float maxTimePerDay)
	{
		return false;
	}

	public void MarkGuideBubbleShownToday()
	{
	}

	private int GetTodayGuideBubbleShownCount()
	{
		return 0;
	}

	private string GetFirstGuideKey(ulong accountId)
	{
		return null;
	}

	private string GetGuideBubbleDailyCountKey(ulong accountId)
	{
		return null;
	}

	public void SetMatchData(EIENIBNLACM data, ulong matchId, byte[] rawData)
	{
	}

	private static string GetRootCacheDirectory()
	{
		return null;
	}

	private static string GetAccountCacheDirectory(ulong accountId)
	{
		return null;
	}

	private static string GetMatchFilePath(ulong accountId, ulong matchId)
	{
		return null;
	}

	private static string GetAssistReviewInfoFilePath(ulong accountId, ulong matchId)
	{
		return null;
	}

	private static void EnsureAccountCacheDirectory(ulong accountId)
	{
	}

	private void SaveMatchFile(byte[] rawData, ulong matchId)
	{
	}

	private void LoadMostRecentMatchData()
	{
	}

	private void LoadMatchFromFile(string filePath, ulong matchId)
	{
	}

	private AssistReviewInfo LoadAssistReviewInfo(ulong matchId)
	{
		return null;
	}

	private AssistReviewInfo GetOrCreateAssistReviewInfo(ulong matchId)
	{
		return null;
	}

	private void SaveAssistReviewInfo(AssistReviewInfo info)
	{
	}

	private void RefreshTodayBattleReportAssist(bool needRefreshAssistView = true)
	{
	}

	private void CheckAndClearByVersionOnLogin()
	{
	}

	private static string GetMainVersionForCacheCheck(string version)
	{
		return null;
	}

	private void TrimToLimit()
	{
	}

	private void DeleteAllMatchFiles()
	{
	}

	private int GetMaxStoredMatches()
	{
		return 0;
	}

	private static EIENIBNLACM DeserializeMatchData(byte[] bytes)
	{
		return null;
	}

	private static uint FindLocalPlayerID(EIENIBNLACM matchData)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
