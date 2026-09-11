using System;
using System.Collections.Generic;
using UMA;
using UMA.Simple;
using UnityEngine;

public class UMAContextSimple : UMAContext
{
	public bool CacheSlotOverlay;

	protected SlotOverlayAssetCache m_Cache;

	private bool m_AsyncLoadAllCancled;

	public SlotOverlayAssetCache Cache => null;

	protected virtual void Awake()
	{
	}

	public override void Start()
	{
	}

	public override void OnDestroy()
	{
	}

	private void InitCacheAndManagers()
	{
	}

	public static void ClearForRestart()
	{
	}

	public virtual void SetCacheSlotOverlay(bool cache)
	{
	}

	public SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	public SlotDataAsset GetSlotDataAsset(int hash)
	{
		return null;
	}

	public OverlayDataAsset GetOverlayDataAsset(string name)
	{
		return null;
	}

	public OverlayDataAsset GetOverlayDataAsset(int hash)
	{
		return null;
	}

	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	public override SlotData InstantiateSlot(int hash)
	{
		return null;
	}

	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	public override OverlayData InstantiateOverlay(int hash)
	{
		return null;
	}

	public bool IsSlotDataAssetCached(int hash)
	{
		return false;
	}

	public bool IsOverlayDataAssetCached(int hash)
	{
		return false;
	}

	public bool PreloadSlotDataAsset(string name)
	{
		return false;
	}

	public bool PreloadSlotDataAsset(int hash)
	{
		return false;
	}

	public bool PreloadOverlayDataAsset(string name)
	{
		return false;
	}

	public bool PreloadOverlayDataAsset(int hash)
	{
		return false;
	}

	public bool IsSlotContainsOverlay(string slotName, string overlayName)
	{
		return false;
	}

	public bool IsSlotContainsOverlay(int slotHash, int overlayHash)
	{
		return false;
	}

	public uint LoadSlotOrOverlayDataAsset(string name, bool isSlot, Action<UnityEngine.Object, uint> callback)
	{
		return 0u;
	}

	public uint LoadSlotOrOverlayDataAsset(int hash, bool isSlot, Action<UnityEngine.Object, uint, int> callback, int param)
	{
		return 0u;
	}

	public void CancelAsyncLoad(ICollection<uint> tickets, bool clear = true)
	{
	}

	public void CancelAsyncLoad(uint ticket)
	{
	}

	public UMATextRecipe GetTextRecipe(int name)
	{
		return null;
	}

	public static UmaRecipeSimple GetSimpleRecipe(int hash)
	{
		return default(UmaRecipeSimple);
	}
}
