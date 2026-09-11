using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace UMA.Simple;

public static class UmaAssetUtil
{
	public const bool LoadNoCache = true;

	public const ResourceManager.ERefOwner RefOwner = ResourceManager.ERefOwner.Uma;

	public const ResourceManager.ERefOwner RefOwnerNone = ResourceManager.ERefOwner.None;

	public static bool LoadFromIndexer;

	public static bool LoadFromResManager;

	public static bool LoadFromAssetDatabase;

	private static ResourceManager ResManagerInstance;

	public static readonly uint INVALID_REQUEST_ID;

	public static readonly uint INSTANT_REQUEST_ID;

	public static readonly uint VALID_REQUEST_ID_START;

	public static int AbRefCountGeneration => 0;

	public static void Init()
	{
	}

	public static void LogDebug(string s)
	{
	}

	public static void LogError(string s)
	{
	}

	public static T GetAsset<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	public static T GetAsset<T>(string ab, string path, bool preload) where T : UnityEngine.Object
	{
		return null;
	}

	public static bool IsDelayedRequestId(uint id)
	{
		return false;
	}

	public static uint GetAsset<T>(string ab, string path, Action<uint, bool, UnityEngine.Object> callback) where T : UnityEngine.Object
	{
		return 0u;
	}

	public static void CancelAsyncLoad(uint ticket)
	{
	}

	public static void UpdateAbRefCount(ICollection<SlotData> umaRecipeSlots, short delta)
	{
	}

	private static void UpdateAbRefCount(INameProvider asset, bool isSlot, short delta)
	{
	}
}
