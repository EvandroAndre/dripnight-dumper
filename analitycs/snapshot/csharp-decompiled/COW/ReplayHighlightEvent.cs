using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

[Serializable]
public class ReplayHighlightEvent
{
	public const float INVALID_KILL_TIME = -1f;

	public uint EventID;

	public uint PlayerID;

	public float StartTime;

	public float EndTime;

	public int WeaponDataID;

	public float TriggerPoint;

	public uint Score;

	public Vector3 Position;

	public uint HeadShotKillCnt;

	public uint HeadShotKillCntNow;

	public uint ConsecutiveKillCnt;

	public uint CSRound;

	public uint FinalHighlightIndex;

	public uint serial;

	public float FirstKillTriggerTime;

	public float LastKillTriggerTime;

	public List<ReplayHighlightEventPeriod> HighlightEventPeriods;

	public ReplayHighlightEvent Clone()
	{
		return null;
	}

	public float GetDelay(float point)
	{
		return 0f;
	}

	public List<float> GetDelays(float point)
	{
		return null;
	}

	public string GetLogString()
	{
		return null;
	}
}
