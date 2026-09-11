using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using COW.UGCHudEdit;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetHierarchyController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIUGCHudWidgetHierarchyNodeItemController> _003C_003E9__40_0;

		internal int _003CUpdateValidItemList_003Eb__40_0(UIUGCHudWidgetHierarchyNodeItemController a, UIUGCHudWidgetHierarchyNodeItemController b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UIUGCHudWidgetHierarchyNodeItemController item;

		internal bool _003CGetNodeItemIndex_003Eb__0(UIUGCHudWidgetHierarchyNodeItemController x)
		{
			return false;
		}
	}

	private UIModelUGCHudEdit m_Model;

	private UIUGCHudWidgetHierarchyView m_View;

	private List<UIUGCHudWidgetHierarchyNodeItemController> m_NodeItemList;

	private List<UIUGCHudWidgetHierarchyNodeItemController> m_ValidItemList;

	private UIUGCHudWidgetHierarchyNodeItemController m_SelectedItem;

	private RecordUGCHudWidgetHierarchyCommand m_RecordCommand;

	private bool m_IsExpand;

	private float m_ScrollViewTop;

	private float m_ScrollViewBottom;

	private int m_DragFrameDefaultHeight;

	private float m_ItemSpace;

	private const int DRAG_FRAME_MIN_HEIGHT = 6;

	private const float THRESHOLD_Y = 10f;

	private bool m_IsWidgetSelectedByHierarchy;

	public bool IsWidgetSelectedByHierarchy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform NodeRoot => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetSelectedWidget(UGCHudWidget widget)
	{
	}

	public void SetAddHudWidget(UGCHudWidget widget, bool includeChildren)
	{
	}

	public void SetRemoveHudWidget(UGCHudWidget widget, bool includeChildren)
	{
	}

	public void InitNodeItems(GameObject go)
	{
	}

	public void ShowSecondItemGuide()
	{
	}

	public void SetExpand(bool expand)
	{
	}

	public Vector3 GetItemRelativePositon(Vector3 position)
	{
		return default(Vector3);
	}

	public void LongPressItem(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	public void DragItem(UIUGCHudWidgetHierarchyNodeItemController item, Vector2 delta)
	{
	}

	public void ReleaseItem(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	public void Reset()
	{
	}

	public void AddNodeToRoot(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	public void UpdateLayout()
	{
	}

	private void OnHierarchyShowGuide(object[] data)
	{
	}

	private void AddNodeFromChildren(Transform trans, UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	private void DeleteNode(UIUGCHudWidgetHierarchyNodeItemController node, bool includeChildren)
	{
	}

	private UIUGCHudWidgetHierarchyNodeItemController FindNodeItem(UGCHudWidget widget)
	{
		return null;
	}

	private UIUGCHudWidgetHierarchyNodeItemController GetNodeItem()
	{
		return null;
	}

	private void UpdateValidItemList()
	{
	}

	private int GetNodeItemIndex(UIUGCHudWidgetHierarchyNodeItemController item)
	{
		return 0;
	}

	private void OnSwitchBtnClick()
	{
	}

	private void OnClickItemCallback(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	private void OnExpandItemCallback()
	{
	}

	private bool SetSelectedItem(UIUGCHudWidgetHierarchyNodeItemController item, bool force = false)
	{
		return false;
	}

	private void OnDragItemCallback(UIUGCHudWidgetHierarchyNodeItemController item, Vector2 delta)
	{
	}

	private void StartRecord(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	private void EndRecord()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
