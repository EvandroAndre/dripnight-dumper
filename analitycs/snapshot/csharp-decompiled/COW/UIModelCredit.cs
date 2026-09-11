using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelCredit : UIBaseModel
{
	private enum ECreditReportType
	{
		None,
		CreditReportTypeCheat,
		CreditReportTypeEnvironment,
		CreditReportTypeVoiceReport
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CreditAutoReportDesc> _003C_003E9__100_0;

		internal int _003CProcessCreditAutoReportDesc_003Eb__100_0(CreditAutoReportDesc a, CreditAutoReportDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public HashSet<ulong> currentIds;

		internal bool _003CPruneReadReportIds_003Eb__0(ulong id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public HashSet<ulong> currentTs;

		internal bool _003CPruneReadCompensationTs_003Eb__0(ulong ts)
		{
			return false;
		}
	}

	public const uint PropID_GetCreditScoreChangeFinish = 1u;

	public const uint PropID_ClaimCreditScoreWeeklyRewards = 2u;

	public const uint PropID_CreditPunishMentUpdate = 8u;

	public const uint PropID_CreditScoreUpdate = 16u;

	public const uint PropID_CreditReportAndPenalty = 32u;

	public const uint PropID_CreditScoreDescReady = 64u;

	public const uint PropID_CreditPunishOtherInfoUpdate = 128u;

	private CSGetCreditScoreDescRes m_CreditScoreDesc;

	private CSGetCreditScoreInfoRes m_CreditScoreInfo;

	private List<CreditReportInfo> m_CreditReportList;

	private List<CreditPenaltyInfo> m_CreditPenzaltyList;

	private List<CreditCompensationInfo> m_CreditCompensationList;

	private List<CreditAutoReportDesc> m_CreditAutoReportList;

	private Dictionary<uint, CreditPenaltyDesc> m_CreditPenaltyDescDict;

	private Dictionary<uint, proto.CreditPunishOtherInfo> m_CreditPunishOtherInfoDict;

	private Dictionary<GameModeBanKey, proto.CreditPunishOtherInfo> m_GameModeBanMatchInfoDict;

	private Dictionary<ulong, CreditBehaviorMuteData> m_CreditBehaviorMuteDataDict;

	private Dictionary<uint, string> m_CreditPenaltyTypeToNameKeyDict;

	private bool m_IsShowAfkWnd;

	public bool IsFirstLogin;

	public uint CurCreditScore;

	public int CreditDeltScore;

	public long TimeStamp;

	private string CreditPenaltyBanTeam;

	private string CreditPenaltyBanTeamRank;

	private string CreditPenaltyBanTeamRankReset;

	private string CreditPenaltyBanAccount;

	private string CreditReportReviewing;

	private string CreditReportDone;

	private string CreditReportFail;

	private string CreditReportFailSystemPriority;

	private string CreditReportTypeCheat;

	private string CreditReportTypeEnvironment;

	private string CreditReportTypeVoiceReport;

	private string CreditPenaltyBanAccountTeamRankAndReset;

	private string CreditPenaltyBanAccountTeam;

	private string CreditPenaltyBanGameVoice;

	private string ReportHistoryTimeStamp;

	private string PenzaltyHistoryTimeStamp;

	private string CompensationHistoryTimeStamp;

	private const string ReadReportIdsKeyPrefix = "ReadReportFeedbackReportIds_";

	private const string ReadCompensationTsKeyPrefix = "ReadReportFeedbackCompTs_";

	private HashSet<ulong> m_ReadReportIds;

	private HashSet<ulong> m_ReadCompensationTs;

	public bool IsShowAFKWnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public CSGetCreditScoreDescRes GetCreditScoreDesc()
	{
		return null;
	}

	public CSGetCreditScoreInfoRes GetCreditScoreInfo()
	{
		return null;
	}

	public List<CreditReportInfo> GetCreditReportList()
	{
		return null;
	}

	public List<CreditPenaltyInfo> GetCreditPenzaltyList()
	{
		return null;
	}

	public List<CreditCompensationInfo> GetCreditCompensationList()
	{
		return null;
	}

	public bool GetCreditSwitch()
	{
		return false;
	}

	public CreditReduceDesc GetCreditReduceDescByRuleID(uint ruleID)
	{
		return null;
	}

	public string GetCreditReportState(ReportScheduleType StateType, uint reportType)
	{
		return null;
	}

	public string GetCreditReportType(uint reportType)
	{
		return null;
	}

	private CreditPenaltyDesc GetCreditPenaltyDescByKey(uint key)
	{
		return null;
	}

	public string GetCreditPenaltyNameByPunishType(uint punish_type)
	{
		return null;
	}

	private void ProcessCreditPenaltyDesc(CSGetCreditScoreDescRes descRes)
	{
	}

	public bool IsNewReportHistory()
	{
		return false;
	}

	public bool IsNewPenzaltyHistory()
	{
		return false;
	}

	public bool IsNewCompensationHistory()
	{
		return false;
	}

	public void SetReportHistoryReportTimeStamp()
	{
	}

	public void SetPenzaltyHistoryUpdateTimeStamp()
	{
	}

	public void SetCompensationHistoryTimeStamp()
	{
	}

	public bool AntiHackNeedRedPoint()
	{
		return false;
	}

	public void ClearAllAntiHackRedPoints()
	{
	}

	public void InjectReportFeedbackToGameAssist()
	{
	}

	public void MarkReportFeedbackRead(bool markReport, bool markCompensation)
	{
	}

	private void EnsureReadReportIdsLoaded()
	{
	}

	private void EnsureReadCompensationTsLoaded()
	{
	}

	private HashSet<ulong> LoadReadIdSet(string key)
	{
		return null;
	}

	private void SaveReadReportIds()
	{
	}

	private void SaveReadCompensationTs()
	{
	}

	private void SaveReadIdSet(string key, HashSet<ulong> set)
	{
	}

	private void PruneReadReportIds(HashSet<ulong> currentIds)
	{
	}

	private void PruneReadCompensationTs(HashSet<ulong> currentTs)
	{
	}

	private string GetReadReportKey()
	{
		return null;
	}

	private string GetReadCompensationKey()
	{
		return null;
	}

	public void RequestGetCreditScoreDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestGetCreditScoreInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestGetCreditScoreChangeInfo()
	{
	}

	public void RequestClaimCreditScoreWeeklyRewards()
	{
	}

	public proto.ECreditScore.SummaryLevel GetCreditLevel()
	{
		return proto.ECreditScore.SummaryLevel.SummaryLevel_NOT_INIT;
	}

	public bool IsAccountReported(ulong id, ulong match_id)
	{
		return false;
	}

	public void RequestGetCreditReportAndPenzalty(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateCredit(uint credit_score, int credit_score_delta, long change_time_stamp)
	{
	}

	public void ClearCreditBehaviorMuteDataDict()
	{
	}

	public void SetCreditBehaviorMuteData(ulong accountId)
	{
	}

	public void RemoveCreditBehaviorMuteData(ulong accountId)
	{
	}

	public CreditBehaviorMuteData GetCreditBehaviorMuteData(ulong accountId)
	{
		return null;
	}

	private void ProcessCreditPunishOtherInfo(List<proto.CreditPunishOtherInfo> creditPunishOtherInfo)
	{
	}

	public void OnPunishOthersNtf(PunishOthersNtf punishOthersNtf)
	{
	}

	public bool CheckIsBeSilenceAndGetEndTime(ref long punishUntil)
	{
		return false;
	}

	public bool CheckIsBeVoiceDetectionAndGetEndTime(ref long punishUntil)
	{
		return false;
	}

	public bool CheckIsBeBanMatchModeAndGetEndTime(uint gameMode, ref long punishUntil, uint curMatchMode)
	{
		return false;
	}

	public void SetSilenceEndTime(long punishUntil)
	{
	}

	public void ProcessCreditAutoReportDesc(CSGetCreditScoreDescRes descRes)
	{
	}

	public List<CreditAutoReportDesc> GetCreditAutoReportDescList()
	{
		return null;
	}

	private void _003CRequestGetCreditScoreDesc_003Eb__82_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetCreditScoreInfo_003Eb__83_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetCreditScoreChangeInfo_003Eb__84_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClaimCreditScoreWeeklyRewards_003Eb__85_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetCreditReportAndPenzalty_003Eb__88_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
