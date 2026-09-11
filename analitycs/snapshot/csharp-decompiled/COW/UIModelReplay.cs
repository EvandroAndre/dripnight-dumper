using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIModelReplay : UIBaseModel
{
	public enum ReviewType
	{
		AT_NONE,
		AT_KOL,
		AT_SHANGHAI,
		AT_LOCAL,
		AT_OutSourcing
	}

	public enum DateSortMode
	{
		DSM_None,
		DSM_Ascend,
		DSM_Descend
	}

	public enum DurationSortMode
	{
		DSM_None,
		DSM_Ascend,
		DSM_Descend
	}

	public enum Status
	{
		READY,
		PENDING,
		Qualified,
		Violation,
		Hold
	}

	public class AIReplayRequestBody
	{
		public List<AIReplayRequestBodyInfo> replays;
	}

	public class AIReplayRequestBodyInfo
	{
		public string match_id;

		public string url;

		public int version;
	}

	public class AIReplayResults
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<AIReplayResultData> _003C_003E9__1_0;

			internal int _003CSortByHackerProb_003Eb__1_0(AIReplayResultData x, AIReplayResultData y)
			{
				return 0;
			}
		}

		public List<AIReplayResultData> replay_results;

		public void SortByHackerProb()
		{
		}

		public AIReplayResults Clone()
		{
			return null;
		}

		public bool ExistHacker()
		{
			return false;
		}
	}

	public class AIReplayResultData
	{
		public string item_id;

		public double hacker_prob;

		public bool is_hacker;

		public List<AIReplayResultSuscipiousInfo> chunk_attentions;

		public AIReplayResultData Clone()
		{
			return null;
		}
	}

	public class AIReplayResultSuscipiousInfo
	{
		public double start_time;

		public double end_time;

		public double attention;

		public AIReplayResultSuscipiousInfo Clone()
		{
			return null;
		}
	}

	public class VerifyRes
	{
		public string status;

		public string msg;

		public VerifyData data;
	}

	public class VerifyData
	{
		public bool is_staff;

		public StaffInfo staff_info;
	}

	public class StaffInfo
	{
		public int review_type;

		public int report_progress_duration_hours;
	}

	public class VideosRes
	{
		public string status;

		public string msg;

		public List<ReportReplayInfo> data;
	}

	public class ReasonInfo
	{
		public uint main_reason;

		public List<uint> sub_reasons;

		public ReasonInfo(uint mainReason)
		{
		}

		public ReasonInfo Clone()
		{
			return null;
		}
	}

	public class ReportReplayInfo
	{
		public ulong id;

		public ulong match_id;

		public int date;

		public int game_mode;

		public int group_mode;

		public List<Offender> reported;

		public int duration;

		public string url;

		public int uploaded;

		public string release_version;

		public AIReplayResults replay_check;

		public int report_replay_type;

		public ReportReplayInfo Clone()
		{
			return null;
		}
	}

	public class Offender
	{
		public ulong user_id;

		public string name;

		public int status;

		public List<Reporter> reporters;

		public List<ReasonInfo> reasons;

		public MatchReplayStats match_stats;

		public string remark;

		public Offender Clone()
		{
			return null;
		}
	}

	public class MatchReplayStats
	{
		public int knock_down_count;

		public int total_kill_count;

		public int head_shot_kill_count;

		public double move_distance_byself;

		public MatchReplayStats Clone()
		{
			return null;
		}
	}

	public class Reporter
	{
		public ulong user_id;

		public string name;

		public int reason;

		public uint main_reason;

		public uint sub_reason;

		public int reporter_time_ms;

		public Reporter Clone()
		{
			return null;
		}
	}

	public class ReplayReviewStatus
	{
		public string status;

		public string msg;

		public List<ReportReviewInfo> data;
	}

	public class ReplayReviewMainReason
	{
		public uint main_reason;

		public List<uint> sub_reasons;
	}

	public class ReportReviewInfo
	{
		public ulong updated_at;

		public ulong created_at;

		public string match_id;

		public ulong reported_uid;

		public string reported_name;

		public List<ReplayReviewMainReason> audit_reasons;

		public int hacker_cdt_id;

		public int hacker_tag;

		public int ban_reason;

		public int death_reason;

		public bool is_hacker;

		public int expireSeconds;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ReplayInfo> _003C_003E9__30_0;

		internal int _003CGetAllReplaysByTime_003Eb__30_0(ReplayInfo a, ReplayInfo b)
		{
			return 0;
		}
	}

	private List<ReplayInfo> m_ReplayInfoList;

	private List<ReportReplayInfo> m_ReportReplayInfoList;

	private Dictionary<ulong, Dictionary<string, int>> m_MatchOffenderMapping;

	private Dictionary<string, int> m_OffenderMapping;

	private Dictionary<string, int> m_ReporterMapping;

	private Dictionary<string, int> m_PlayerMapping;

	private List<ReportReviewInfo> m_ReportReviewInfoList;

	private Dictionary<string, Dictionary<string, int>> m_reviewMatchOffenderMapping;

	public bool IsReportReplay;

	private ReportReplayInfo m_CurReportReplayInfo;

	public int m_ReviewType;

	private int m_ReviewDurationHours;

	private string m_AppStartTime;

	private Dictionary<ulong, string> m_ViolationTable;

	private Dictionary<string, string> m_ViolationDateTable;

	public bool IsReportPlaying;

	public DateSortMode m_DateMode;

	public DurationSortMode m_DurationMode;

	public readonly string[] STATUS_KEY_ARRAY;

	public const uint PropID_ReplayDeleted = 2u;

	public const uint PropID_GetReportReplays = 4u;

	public const uint PropID_VerifyAccount = 8u;

	public const uint PropID_GetReportReviews = 16u;

	private Dictionary<ulong, AIReplayResults> m_AIReplayResultsDict;

	private Dictionary<ulong, Dictionary<uint, Dictionary<uint, bool>>> m_CacheSelectListReasonsMapping;

	public override void Init()
	{
	}

	public void SetWatchReplayInfo(ReportReplayInfo reportReplayInfo)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<ReplayInfo> GetAllReplaysByTime()
	{
		return null;
	}

	public bool Play(ReplayInfo info, bool isReportReplay = false, ReportReplayInfo reportReplayInfo = null)
	{
		return false;
	}

	public void Del(ReplayInfo info)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void InitCacheReason()
	{
	}

	public void ClearCacheReason()
	{
	}

	public void SetCacheReasonSelect(Dictionary<uint, Dictionary<uint, bool>> reasonMap, uint type, uint reason, bool selectTag)
	{
	}

	public bool CheckCacheReasonSelect(Dictionary<uint, Dictionary<uint, bool>> reasonMap, uint type, uint reason)
	{
		return false;
	}

	public void SetCacheReasonSelectListById(ulong id, uint type, uint reason, bool selectTag)
	{
	}

	public bool CheckCacheReasonSelectListById(ulong id, uint type, uint reason)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
