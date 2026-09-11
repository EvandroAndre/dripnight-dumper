using System.Collections.Generic;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC;

internal static class UGCTutorialSequenceJsonParser
{
	public static UGCTutorialSequenceData Parse(UGCTutorialJsonReadContext ctx, JsonData root)
	{
		return null;
	}

	private static List<UGCTutorialLevelData> ParseLevels(UGCTutorialJsonReadContext ctx, JsonData arr)
	{
		return null;
	}

	private static UGCTutorialLevelData ParseLevel(UGCTutorialJsonReadContext ctx, JsonData jd)
	{
		return null;
	}

	private static List<UGCTutorialTaskData> ParseTasks(UGCTutorialJsonReadContext ctx, JsonData arr)
	{
		return null;
	}

	private static UGCTutorialTaskData ParseTask(UGCTutorialJsonReadContext ctx, JsonData jd)
	{
		return null;
	}

	private static List<UGCTutorialAtomicTaskData> ParseAtomicTasks(UGCTutorialJsonReadContext ctx, JsonData arr)
	{
		return null;
	}

	private static UGCTutorialAtomicTaskData ParseAtomicTask(UGCTutorialJsonReadContext ctx, JsonData jd)
	{
		return null;
	}

	private static UGCTutorialMaskData ParseMask(UGCTutorialJsonReadContext ctx, JsonData jd)
	{
		return null;
	}

	private static UGCTutorialRestrictionData ParseRestrictions(JsonData jd)
	{
		return null;
	}

	private static UGCTutorialCameraPoseData ParseCameraPose(JsonData jd)
	{
		return null;
	}

	private static JsonData TryGetCameraPoseNode(JsonData jd)
	{
		return null;
	}

	private static JsonData TryGetAny(JsonData jd, string[] keys)
	{
		return null;
	}

	private static string GetStringAny(JsonData jd, string[] keys)
	{
		return null;
	}

	private static bool TryParseVector3(JsonData jd, out Vector3 value)
	{
		value = default(Vector3);
		return false;
	}

	private static bool TryParseVector3Fields(JsonData jd, string prefix, out Vector3 value)
	{
		value = default(Vector3);
		return false;
	}

	private static bool TryGetFloat(JsonData value, out float result)
	{
		result = default(float);
		return false;
	}

	private static List<string> ParseStringArray(JsonData arr)
	{
		return null;
	}

	private static List<UGCTutorialDialogueData> ParseDialogues(JsonData arr)
	{
		return null;
	}

	private static List<UGCTutorialGuideData> ParseGuides(UGCTutorialJsonReadContext ctx, JsonData arr)
	{
		return null;
	}

	private static UGCTutorialGuideData ParseGuide(UGCTutorialJsonReadContext ctx, JsonData jd)
	{
		return null;
	}

	private static UGCTutorialContextRefData ParseContextRef(JsonData jd)
	{
		return null;
	}

	private static JsonData TryGet(JsonData jd, string key)
	{
		return null;
	}

	private static string GetString(JsonData jd, string key)
	{
		return null;
	}

	private static int GetInt(JsonData jd, string key, int defaultValue)
	{
		return 0;
	}

	private static string JsonPrimitiveToString(JsonData value)
	{
		return null;
	}
}
