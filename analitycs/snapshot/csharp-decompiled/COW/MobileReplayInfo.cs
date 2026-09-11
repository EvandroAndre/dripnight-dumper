using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class MobileReplayInfo
{
	private BaseHighlightInfo m_HighlightInfo;

	public string Version;

	public ulong AccountID;

	public ulong MatchID;

	public string MatchDateTime;

	public string MatchDateShowTime;

	public float GameTotalTime;

	public uint MapID;

	public uint MatchMode;

	public uint GroupMode;

	public uint LayerID;

	public string FileName;

	public uint PlayerCount;

	public byte Rank;

	public int RankingPointsAfter;

	public int RankingPointsDelta;

	public string WorkshopBytes;

	public bool IsSaved;

	public bool SavedHighLight;

	public bool GameAssistHighlightRead;

	public bool IsTemporary;

	public bool IsGenerated;

	public bool HasKillCam;

	public bool Is1POptimized;

	public bool IsEmulatorPool;

	public List<MobileReplayEvent> Events;

	public List<ReplayAchievementData> AchievementList;

	public List<ReplayAchievementArgs> AchievementArgsList;

	public List<MobileReplayEvent> RoundEvents;

	public ReplayAvatarData AvatarData;

	public bool HasInitAvatarData;

	public List<ReplayMedalsData> PersonMedals;

	public float StartSkipTime;

	public List<MobileReplayPingSample> PingSamples;

	public BaseHighlightInfo HighlightInfo => null;

	public uint GameMode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint Kill
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint HighlightScore
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> HighlightEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> HeadShotHighlightEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> MultiKillHighlightEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> CSAceHighlightEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> EpicHighlightEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayHighlightEvent> GuaranteedEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayKillEvent> KillEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ReplayDeadEvent> DeadEvents
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HashSet<uint> CSAceRound
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid => false;

	public bool CorrectionKillEvent(uint serial, float point, int weapon_id)
	{
		return false;
	}

	public bool HasAchievement(uint group)
	{
		return false;
	}

	public void AddFeedbackEvent(byte id)
	{
	}

	public void AddAchievement(uint id, uint serial, List<string> args)
	{
	}

	public bool RemoveAchievement(uint serial)
	{
		return false;
	}

	public string[] GetAchievementArgs(uint serial)
	{
		return null;
	}

	public bool AddKillEvent(ReplayMatchEventData match_event, float point, uint serial, uint group, int weapon, Vector3 pos, uint curRound, Vector3 beKilledPlayerPos)
	{
		return false;
	}

	public bool AddDeadEvent(ReplayMatchEventData match_event, float point, uint group, Vector3 pos, uint curRound)
	{
		return false;
	}

	public void AddSafeZoneEvent(byte StageID, float point)
	{
	}

	private MobileReplayEvent GetRoundEvent(byte index)
	{
		return null;
	}

	public void AddRoundEvent(float point)
	{
	}
}
