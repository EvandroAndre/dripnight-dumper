using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayAssetCacheWithRefsDic : SlotOverlayAssetCacheWithRefs
{
	private SlotOverlayRefsDic _003CRefsDic_003Ek__BackingField;

	public SlotOverlayRefsDic RefsDic
	{
		get
		{
			return _003CRefsDic_003Ek__BackingField;
		}
		protected set
		{
			_003CRefsDic_003Ek__BackingField = value;
		}
	}

	protected override void InitRefs()
	{
	}

	public SlotOverlayAssetCacheData GetCaches()
	{
		return null;
	}

	public bool HasLoadingReqs()
	{
		return false;
	}

	protected override void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload)
	{
	}

	public void TouchRefCount(bool isSlot, Object asset)
	{
	}

	public bool DecreaseRefCount(bool isSlot, Object asset, bool removeOnZero)
	{
		return false;
	}
}
