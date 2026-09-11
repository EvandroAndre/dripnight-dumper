using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelSeasonYear : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SeasonYearDesc> _003C_003E9__78_0;

		internal int _003CProcessSeasonYearDesc_003Eb__78_0(SeasonYearDesc a, SeasonYearDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UIModelSeasonYear _003C_003E4__this;

		public uint seasonYearId;

		internal void _003CGetPlayerRankingHistorySeasonStats_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UIModelSeasonYear _003C_003E4__this;

		public uint seasonYearId;

		internal void _003CGetPlayerCSRankingHistorySeasonStats_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	public const uint PropID_BRHistoryStatsRefreshed = 2u;

	public const uint PropID_CSHistoryStatsRefreshed = 4u;

	private uint m_CurSeasonYearId;

	private uint m_CurBRSeasonYearId;

	private uint m_CurCSSeasonYearId;

	private List<SeasonYearDesc> m_SeasonYearDescList;

	private Dictionary<uint, SeasonYearDesc> m_SeasonYearDescDict;

	private Dictionary<uint, int> m_GetBRSeasonYearStatsDict;

	private Dictionary<uint, int> m_GetCSSeasonYearStatsDict;

	private Dictionary<uint, uint[]> m_SeasonYearBRIdsDict;

	private Dictionary<uint, uint[]> m_SeasonYearCSIdsDict;

	private Dictionary<uint, uint> m_BeforeMatchHeroicCntDict;

	private Dictionary<uint, CSPlayerStatHistory> m_BRSeasonStatsDict;

	private Dictionary<uint, CSPlayerCSStatHistory> m_CSSeasonStatsDict;

	private Dictionary<uint, PlayerHistorySeasonRankInfo> m_BRSeasonHisRankDict;

	private Dictionary<uint, PlayerHistorySeasonRankInfo> m_CSSeasonHisRankDict;

	private uint m_HistoryBeginBRId;

	private uint m_HistoryBeginCSId;

	private uint m_HistoryEndBRId;

	private uint m_HistoryEndCSId;

	private List<string> m_SeasonYearNameList;

	private ulong m_NewSeasonYearStartTimeStamp;

	private bool _003CHasShowSeasonYearPopUp_003Ek__BackingField;

	private bool _003CIsSeasonYearFirstIn_003Ek__BackingField;

	private Dictionary<uint, Type> SeasonYearMatchResultControllerDict;

	public bool HasShowSeasonYearPopUp
	{
		get
		{
			return _003CHasShowSeasonYearPopUp_003Ek__BackingField;
		}
		set
		{
			_003CHasShowSeasonYearPopUp_003Ek__BackingField = value;
		}
	}

	public bool IsSeasonYearFirstIn
	{
		get
		{
			return _003CIsSeasonYearFirstIn_003Ek__BackingField;
		}
		set
		{
			_003CIsSeasonYearFirstIn_003Ek__BackingField = value;
		}
	}

	public uint CurSeasonYearId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint CurBRSeasonYearId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint CurCSSeasonYearId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<string> SeasonYearNameList => null;

	public List<SeasonYearDesc> SeasonYearDescList => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public SeasonYearDesc GetCurSeasonYearDesc()
	{
		return null;
	}

	public SeasonYearDesc GetSeasonYearDesc(uint seasonYearId)
	{
		return null;
	}

	public string GetSeasonYearTitleKey(uint seasonYearId)
	{
		return null;
	}

	public uint[] GetSeasonYearBRIds(uint seasonYearId)
	{
		return null;
	}

	public uint[] GetSeasonYearCSIds(uint seasonYearId)
	{
		return null;
	}

	public uint[] GetHisBRIds()
	{
		return null;
	}

	public uint[] GetHisCSIds()
	{
		return null;
	}

	public PlayerHistorySeasonRankInfo GetBRRankBySeasonId(uint seasonId)
	{
		return null;
	}

	public PlayerHistorySeasonRankInfo GetCSRankBySeasonId(uint seasonId)
	{
		return null;
	}

	public CSPlayerStatHistory GetBRStatHistoryBySeasonId(uint seasonId)
	{
		return null;
	}

	public CSPlayerCSStatHistory GetCSStatHistoryBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<ClientActivityDesc> GetSeasonYearTaskDesc(uint seasonYearId)
	{
		return null;
	}

	public uint GetSeasonYearHeroicCnt(uint seasonYearId)
	{
		return 0u;
	}

	public uint GetBeforeMatchHeroicCnt(uint seasonYearId)
	{
		return 0u;
	}

	public void SetBeforeMatchHeroicCnt(uint seasonYearId, uint heroicCnt)
	{
	}

	public bool CheckNeedPopSeasonYearWindow(uint seasonYearId)
	{
		return false;
	}

	public void RequestHeroicCntInLobby()
	{
	}

	public bool ShowSeasonYearChangeInLobby()
	{
		return false;
	}

	public bool MatchRegisterTime()
	{
		return false;
	}

	public bool CanClaimHeroicReward(uint seasonYearId)
	{
		return false;
	}

	public int GetCurrentClaimRewardIndex(uint seasonYearId)
	{
		return 0;
	}

	public bool CanClaimShareReward(uint seasonYearId)
	{
		return false;
	}

	public bool ShowGiftIcon()
	{
		return false;
	}

	public bool ShowRedPointIcon()
	{
		return false;
	}

	public bool ShowShareRedPointIcon(uint entranceId)
	{
		return false;
	}

	public void SetShareRedPointIconValueKey(uint entranceId)
	{
	}

	public Type GetSeasonYearMatchResultControllerType(uint seasonYearId)
	{
		return null;
	}

	public void GetPlayerRankingHistorySeasonStats(uint seasonYearId, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void GetPlayerCSRankingHistorySeasonStats(uint seasonYearId, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void UpdateDataIfNewSeason()
	{
	}

	private void ProcessSeasonYearData(SeasonYearDesc seasonYearDesc)
	{
	}

	private void ProcessCurSeasonYearData(SeasonYearDesc seasonYearDesc)
	{
	}

	public void ProcessSeasonYearDesc(CSGetSeasonYearDescRes desc)
	{
	}

	public void DebugLog(string msg)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
