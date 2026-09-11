using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public interface ISlotOverlayRefs
{
	bool HasRefs();

	void ClearRefs();

	short AddRefCount(bool isSlot, Object asset, short deltaCount);

	void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays);
}
