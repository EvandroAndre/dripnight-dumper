using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public static class CommonReplayManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ReplayHighlightEvent> _003C_003E9__13_0;

		public static Comparison<ReplayHighlightEvent> _003C_003E9__13_1;

		internal int _003CAdjustFinalMultiKillEvents_003Eb__13_0(ReplayHighlightEvent x, ReplayHighlightEvent y)
		{
			return 0;
		}

		internal int _003CAdjustFinalMultiKillEvents_003Eb__13_1(ReplayHighlightEvent x, ReplayHighlightEvent y)
		{
			return 0;
		}
	}

	private static readonly uint[] KnockDownEventTypes;

	private static CSVAsyncDataMap<uint, HighlightEventPriorityData> s_HighlightEventPriorityDatas;

	public static bool IsKnockDownEventType(uint eventType)
	{
		return false;
	}

	public static float GetHighlightTotalTime(BaseHighlightInfo info)
	{
		return 0f;
	}

	public static float GetEventsTotalTime(List<ReplayHighlightEvent> events)
	{
		return 0f;
	}

	public static bool HasHighlight(BaseHighlightInfo info, bool useMergeLogic = true)
	{
		return false;
	}

	public static void SelectEpicHighlightEvent(BaseHighlightInfo info)
	{
	}

	public static void ProcessHeadShotHighlightEvents(BaseHighlightInfo info)
	{
	}

	public static void ProcessCSAceHighlightEvents(BaseHighlightInfo info)
	{
	}

	public static EHighLightPlayType SelectFinalHighlightType(BaseHighlightInfo info)
	{
		return EHighLightPlayType.None;
	}

	public static string GetHighlightShowLabel(BaseHighlightInfo info, EHighLightPlayType highLightPlayType, bool isSettingTab = false)
	{
		return null;
	}

	public static bool IsInSameRound(ReplayHighlightEvent evt, ReplayHighlightEvent newEvt, uint gameMode)
	{
		return false;
	}

	public static bool IsKnockDownInShortTime(ReplayHighlightEvent evt, ReplayHighlightEvent newEvt)
	{
		return false;
	}

	public static void TryMergeHighlightEvents(BaseHighlightInfo info)
	{
	}

	public static void AdjustFinalMultiKillEvents(List<ReplayHighlightEvent> allKillEvents, BaseHighlightInfo info)
	{
	}

	public static bool IsInShortDistance(ReplayHighlightEvent evt, ReplayHighlightEvent newEvt, uint gameMode)
	{
		return false;
	}

	public static float CheckDeadHappenInEvent(BaseHighlightInfo info, float startTime, float endTime, uint curRound, float eventTriggerPoint)
	{
		return 0f;
	}

	public static void LogHighlightReplayEvent(BaseHighlightInfo highlightInfo, ReplayMatchEventData matchEvent, uint group, float point, int weaponDataID, uint serial, Vector3 pos, uint curRound, Vector3 beKilledPlayerPos, uint playerID = 0u)
	{
	}

	public static void GenerateMultiKillReplayEvent(BaseHighlightInfo highlightInfo, ReplayMatchEventData matchEvent, uint group, float point, int weaponDataID, uint serial, Vector3 pos, uint curRound, Vector3 beKilledPlayerPos, uint playerID = 0u)
	{
	}

	private static uint GetEventPriority(uint eventID)
	{
		return 0u;
	}

	public static int SortEpicEvent(ReplayHighlightEvent left, ReplayHighlightEvent right)
	{
		return 0;
	}

	public static int SortShowEpicEvent(ReplayHighlightEvent left, ReplayHighlightEvent right)
	{
		return 0;
	}

	public static void CorrectHighlightEventID(ReplayHighlightEvent highLightEvent, ReplayMatchEventData matchEvent, int weaponDataID, float point, uint serial, bool isKnockdownOrKill, Vector3 pos, uint csRound, ReplayHighlightEventPeriod period, bool isMultiKillCorrect = false)
	{
	}
}
