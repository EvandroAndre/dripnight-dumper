using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ScrollViewCulling : MonoBehaviour
{
	private class CullingItem
	{
		public UIHUDUGC_BaseController Controller;

		public int MinChunk;

		public int MaxChunk;

		public int VisibleChunkRefCount;

		public bool Mapped;

		public Bounds Bounds;

		public bool HasBounds;

		public bool Visible;

		public bool WidgetsDirty;

		public bool SkipUpdateApplied;

		public readonly List<UIWidget> Widgets;
	}

	private const float DefaultPreloadDistance = 50f;

	private const int MaxChunksPerItem = 64;

	private readonly Dictionary<UIHUDUGC_BaseController, CullingItem> m_Items;

	private readonly Dictionary<int, List<CullingItem>> m_ChunkItems;

	private readonly HashSet<UIHUDUGC_BaseController> m_DirtyItems;

	private readonly HashSet<CullingItem> m_VisibleChunkChangedItems;

	private readonly HashSet<UIHUDUGC_BaseController> m_ObservedControllers;

	private UGCHudScrollView m_ScrollView;

	private UIHUDUGC_ScrollViewController m_Controller;

	private Transform m_ContentTransform;

	private bool m_Initialized;

	private bool m_CullingActive;

	private bool m_HasVisibleRange;

	private bool m_VisibleRangeDirty;

	private int m_FirstVisibleChunk;

	private int m_LastVisibleChunk;

	private bool m_EnableCulling;

	private float m_PreloadDistance;

	public void Initialize(UGCHudScrollView scrollView, UIHUDUGC_ScrollViewController controller)
	{
	}

	public void Shutdown()
	{
	}

	public void RegisterSubtree(UIHUDUGC_BaseController root)
	{
	}

	public void RebuildForScrollAxisChange()
	{
	}

	public void RegisterItem(UIHUDUGC_BaseController controller)
	{
	}

	public void UnregisterItem(UIHUDUGC_BaseController controller)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnObservedChildAdded(UIHUDUGC_BaseController controller)
	{
	}

	private void OnObservedChildRemoved(UIHUDUGC_BaseController controller)
	{
	}

	private void OnObservedControllerDestroyed(UIHUDUGC_BaseController controller)
	{
	}

	private void OnItemChanged(UIHUDUGC_BaseController controller)
	{
	}

	private void OnItemDestroyed(UIHUDUGC_BaseController controller)
	{
	}

	private void RegisterItemEvents(CullingItem item)
	{
	}

	private void UnregisterItemEvents(CullingItem item)
	{
	}

	private void SyncSubtree(UIHUDUGC_BaseController controller)
	{
	}

	private void DetachSubtree(UIHUDUGC_BaseController controller)
	{
	}

	private void ObserveController(UIHUDUGC_BaseController controller)
	{
	}

	private void UnobserveController(UIHUDUGC_BaseController controller)
	{
	}

	private void ClearObservedControllers()
	{
	}

	private bool ShouldManageController(UIHUDUGC_BaseController controller)
	{
		return false;
	}

	private void UpdateCullingActive()
	{
	}

	private void ProcessDirtyItems()
	{
	}

	private void OnClipMove(UIPanel panel)
	{
	}

	private bool HasVisibleRangeSourceChanged()
	{
		return false;
	}

	private void UpdateVisibleChunks()
	{
	}

	private bool GetVisibleChunkRange(out int first, out int last)
	{
		first = default(int);
		last = default(int);
		return false;
	}

	private void RebuildItemChunks(CullingItem item)
	{
	}

	private bool TryGetItemBounds(CullingItem item, out Bounds bounds)
	{
		bounds = default(Bounds);
		return false;
	}

	private void EnsureItemWidgets(CullingItem item)
	{
	}

	private void ClearItemBounds(CullingItem item)
	{
	}

	private bool TryGetBoundsBySize(Transform target, Vector2 size, Vector2 pivot, out Bounds bounds)
	{
		bounds = default(Bounds);
		return false;
	}

	private void RemoveItemFromChunks(CullingItem item)
	{
	}

	private void RebuildVisibleChunkRefs(int oldFirst, int oldLast, bool hadVisibleRange)
	{
	}

	private void UpdateVisibleChunkRangeDelta(int rangeFirst, int rangeLast, int excludeFirst, int excludeLast, int delta)
	{
	}

	private void UpdateVisibleChunkRef(int chunk, int delta)
	{
	}

	private void SetAllItemsVisible()
	{
	}

	private void ApplyAllItemVisibility()
	{
	}

	private void ApplyItemVisibility(CullingItem item)
	{
	}

	private bool ShouldItemBeVisibleInCurrentRange(CullingItem item)
	{
		return false;
	}

	private void SetItemVisible(CullingItem item, bool visible, bool forceApply = false)
	{
	}

	private void ApplyItemPresentation(CullingItem item)
	{
	}

	private void RestoreItemPresentation(CullingItem item)
	{
	}

	private void ApplyItemSkipUpdate(CullingItem item, bool skipUpdate)
	{
	}

	private void GetAxisMinMax(Bounds bounds, out float min, out float max)
	{
		min = default(float);
		max = default(float);
	}

	private float GetChunkSize()
	{
		return 0f;
	}

	private bool UseHorizontalAxis()
	{
		return false;
	}
}
