using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public static class SlotOverlayDataPool
{
	private enum PoolType
	{
		Slot,
		Overlay,
		SlotList,
		Cnt
	}

	private const int InitialPoolSize = 16;

	private static List<SlotData> s_SlotPool;

	private static List<OverlayData> s_OverlayPool;

	private static List<List<SlotData>> s_SlotListPool;

	private static int s_ClearCnt;

	private static Vector3Int[] DebugCnts;

	public static void Clear()
	{
	}

	private static T GetOrCreateData<T>(List<T> pool) where T : new()
	{
		return default(T);
	}

	public static SlotData CreateData(SlotDataAsset asset)
	{
		return null;
	}

	public static OverlayData CreateData(OverlayDataAsset asset)
	{
		return null;
	}

	public static List<SlotData> CreateSlotList()
	{
		return null;
	}

	public static void RecycleListOnly(List<SlotData> list)
	{
	}

	public static void RecycleSlotAndOverlays(SlotData slot)
	{
	}

	public static void RecycleOverlays(List<OverlayData> overlays)
	{
	}

	private static void Recycle(SlotData slot)
	{
	}

	private static void Recycle(OverlayData overlay)
	{
	}

	private static void DebugOnClear()
	{
	}

	private static void LogStats()
	{
	}

	private static void DebugOnGet(PoolType t)
	{
	}

	private static void DebugOnRecycle(PoolType t)
	{
	}
}
