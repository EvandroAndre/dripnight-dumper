using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayRefsSet : ISlotOverlayRefs
{
	internal readonly HashSet<SlotDataAsset> m_SlotRefs;

	internal readonly HashSet<OverlayDataAsset> m_OverlayRefs;

	public bool HasRefs()
	{
		return false;
	}

	public void ClearRefs()
	{
	}

	public bool AddRefCount(SlotDataAsset asset)
	{
		return false;
	}

	public bool AddRefCount(OverlayDataAsset asset)
	{
		return false;
	}

	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return 0;
	}

	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}
}
