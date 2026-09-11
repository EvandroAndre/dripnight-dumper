using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayAssetCache
{
	internal Dictionary<int, SlotDataAsset> m_SlotCache;

	internal Dictionary<int, OverlayDataAsset> m_OverlayCache;

	protected Action<uint, UnityEngine.Object, AsyncLoadReq> m_CallbackOnAssetLoaded;

	protected Dictionary<uint, AsyncLoadReq> m_LoadingReqs;

	protected AsyncLoadReqPool m_ReqPool;

	public int CachedSlotCount => 0;

	public int CachedOverlayCount => 0;

	protected virtual void Init()
	{
	}

	public void InitCaches()
	{
	}

	public virtual void Clear()
	{
	}

	protected void ClearCaches()
	{
	}

	protected void InitAsyncAndLogSamples()
	{
	}

	protected void ClearAsyncAndLogSamples()
	{
	}

	public SlotDataAsset GetSlotDataAsset(string name, bool cache)
	{
		return null;
	}

	public SlotDataAsset GetSlotDataAsset(int hash, bool cache)
	{
		return null;
	}

	public OverlayDataAsset GetOverlayDataAsset(string name, bool cache)
	{
		return null;
	}

	public OverlayDataAsset GetOverlayDataAsset(int hash, bool cache)
	{
		return null;
	}

	protected virtual T GetAsset<T>(string name, bool isSlot, Dictionary<int, T> dic, bool preload = false) where T : UnityEngine.Object
	{
		return null;
	}

	protected virtual T GetAsset<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, bool preload = false) where T : UnityEngine.Object
	{
		return null;
	}

	protected T GetAssetImp<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	protected T GetAssetImp<T>(int nameHash, bool preload) where T : UnityEngine.Object
	{
		return null;
	}

	private UmaRecipeSimple GetRecipeForPreload(int recipe)
	{
		return default(UmaRecipeSimple);
	}

	public void PreloadRecipe(int recipe)
	{
	}

	public void PreloadRecipe(int recipe, out bool anyThingLoadedInCall)
	{
		anyThingLoadedInCall = default(bool);
	}

	public void PreloadRecipe(UmaRecipeSimple recipe)
	{
	}

	public bool PreloadAsset(string name, bool isSlot, bool cache)
	{
		return false;
	}

	public bool PreloadAsset(int hash, bool isSlot, bool cache)
	{
		return false;
	}

	public bool IsSlotContainsOverlay(string slotName, string overlayName, bool cache)
	{
		return false;
	}

	public bool IsSlotContainsOverlay(int slotHash, int overlayHash, bool cache)
	{
		return false;
	}

	public void PreloadRecipeAsync(int recipe, HashSet<int> preloaded)
	{
	}

	protected virtual void SaveToCacheChecked<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, T asset, bool alreadyInCache = false, bool preload = false) where T : UnityEngine.Object
	{
	}

	public bool IsAssetCached(int hash, bool isSlot)
	{
		return false;
	}

	public UnityEngine.Object GetAssetFromCache(int hash, bool isSlot)
	{
		return null;
	}

	public bool RemoveSlotDataAsset(int hash)
	{
		return false;
	}

	public bool RemoveOverlayDataAsset(int hash)
	{
		return false;
	}

	protected void InitAsyncLoading()
	{
	}

	public uint GetAssetAsync(string name, Action<UnityEngine.Object, uint> callback, bool isSlot, bool cache)
	{
		return 0u;
	}

	public uint GetAssetAsync(int hash, Action<UnityEngine.Object, uint> callback, bool isSlot, bool cache)
	{
		return 0u;
	}

	public uint GetAssetAsync(int hash, Action<UnityEngine.Object, uint, int> callback, int param, bool isSlot, bool cache)
	{
		return 0u;
	}

	protected virtual uint GetAssetAsync(AsyncLoadReq req)
	{
		return 0u;
	}

	protected uint GetAssetAsyncImp(AsyncLoadReq req)
	{
		return 0u;
	}

	internal void OnAssetLoaded(uint ticket, UnityEngine.Object asset, AsyncLoadReq req)
	{
	}

	protected void SaveToCacheChecked(AsyncLoadReq req, UnityEngine.Object asset, bool alreadyInCache)
	{
	}

	public void CancelAsyncLoad(uint ticket)
	{
	}

	public void CancelAllAsyncLoad()
	{
	}

	public override string ToString()
	{
		return null;
	}

	protected virtual void Log(string s)
	{
	}

	protected virtual void LogError(string s)
	{
	}
}
