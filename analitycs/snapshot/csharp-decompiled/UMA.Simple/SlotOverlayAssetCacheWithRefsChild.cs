using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayAssetCacheWithRefsChild : SlotOverlayAssetCacheWithRefs
{
	protected SlotOverlayAssetCacheWithRefsDic m_Root;

	private SlotOverlayRefsSet _003CRefsSet_003Ek__BackingField;

	public SlotOverlayRefsSet RefsSet
	{
		get
		{
			return _003CRefsSet_003Ek__BackingField;
		}
		protected set
		{
			_003CRefsSet_003Ek__BackingField = value;
		}
	}

	public SlotOverlayAssetCacheWithRefsChild(SlotOverlayAssetCacheWithRefsDic root)
	{
	}

	public SlotOverlayAssetCacheWithRefsDic GetBackCache()
	{
		return null;
	}

	protected override void Init()
	{
	}

	public void SetCaches(SlotOverlayAssetCacheWithRefsDic root)
	{
	}

	private void SetCaches(SlotOverlayAssetCacheData c)
	{
	}

	protected override void InitRefs()
	{
	}

	public override void Clear()
	{
	}

	protected override void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload)
	{
	}
}
