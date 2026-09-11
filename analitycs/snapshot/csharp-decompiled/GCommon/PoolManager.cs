using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public static class PoolManager
{
	private static Dictionary<ResourceID, SpawnPool> m_ResPool;

	private static Dictionary<ResourceID, SpawnPool> m_IteratingResPool;

	private static GameObject m_Parent;

	private static FTimer m_FrameTimer;

	private static bool m_EnablePoolManagerTiled;

	public const uint InvalidTicket = 0u;

	private static bool m_Iterating;

	public static bool Iterating => false;

	public static void SetCallBackTime(uint milliSeconds)
	{
	}

	public static void SetEnbalePoolManagerTiled(bool enablePoolManagerTiled)
	{
	}

	public static void InitRes(ResourceID resID, int num, uint maxSize = 0u, uint recyleSize = 0u, bool isPreload = false, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Low)
	{
	}

	public static void SetResMaxNum(ResourceID resID, uint maxSize)
	{
	}

	public static bool ContainsRes(ResourceID resID)
	{
		return false;
	}

	public static UnityEngine.Object GetRes(ResourceID resID, Transform parentTrans = null)
	{
		return null;
	}

	public static UnityEngine.Object GetRes(ResourceID resID, Transform parentTrans, bool enableHighResFallback)
	{
		return null;
	}

	private static UnityEngine.Object GetResInternal(ResourceID resID, Transform parentTrans, bool enableHighResFallback)
	{
		return null;
	}

	public static uint GetRes(ResourceID resID, Action<uint, bool, UnityEngine.Object> callback, Transform parentTrans = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal)
	{
		return 0u;
	}

	public static uint GetRes(ResourceID resID, Action<uint, bool, UnityEngine.Object> callback, Transform parentTrans, ResourceManager.LoadPriority loadPriority, bool enableHighResFallback)
	{
		return 0u;
	}

	private static uint GetResInternal(ResourceID resID, Action<uint, bool, UnityEngine.Object> callback, Transform parentTrans, ResourceManager.LoadPriority loadPriority, bool enableHighResFallback)
	{
		return 0u;
	}

	public static void UpdateCachedAsyncRequests()
	{
	}

	public static void CancelGetResAsync(ResourceID resID, uint ticket)
	{
	}

	public static void CancelAllResAsyncByResID(ResourceID resID)
	{
	}

	public static bool RecyleRes(ResourceID resID, UnityEngine.Object obj, bool worldPositionStays = true)
	{
		return false;
	}

	public static bool RemoveActiveResAndDestroy(ResourceID resID, UnityEngine.Object obj)
	{
		return false;
	}

	public static bool CleanPool(ResourceID resID)
	{
		return false;
	}

	public static void CancelAllAsyncLoading()
	{
	}

	public static void ClearPool()
	{
	}

	public static void ClearAll()
	{
	}
}
