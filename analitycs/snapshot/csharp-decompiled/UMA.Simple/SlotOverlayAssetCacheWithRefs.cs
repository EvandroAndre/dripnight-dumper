using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public abstract class SlotOverlayAssetCacheWithRefs : SlotOverlayAssetCache
{
	public bool IsBot;

	public ulong Id;

	public bool DisableRefCount;

	protected ISlotOverlayRefs m_Refs;

	public override string ToString()
	{
		return null;
	}

	public void Init(bool isBot, ulong id, bool disableRefs)
	{
	}

	protected override void Init()
	{
	}

	protected abstract void InitRefs();

	public override void Clear()
	{
	}

	protected virtual void ClearRefs()
	{
	}

	protected override uint GetAssetAsync(AsyncLoadReq req)
	{
		return 0u;
	}

	protected override void SaveToCacheChecked<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, T asset, bool alreadyInCache = false, bool preload = false)
	{
	}

	protected abstract void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload);

	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return 0;
	}

	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}
}
