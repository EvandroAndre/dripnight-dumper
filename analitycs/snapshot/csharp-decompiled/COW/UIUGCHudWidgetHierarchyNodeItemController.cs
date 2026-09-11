using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetHierarchyNodeItemController : UIBaseController
{
	public enum OperateStateEnum
	{
		None,
		Drag
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public uint value;

		internal bool _003Cget_ChildMaxRelativeHierary_003Eb__0(UIUGCHudWidgetHierarchyNodeItemController child)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public UIUGCHudWidgetHierarchyNodeItemController node;

		internal bool _003CFindChildIndex_003Eb__0(UIUGCHudWidgetHierarchyNodeItemController x)
		{
			return false;
		}
	}

	private UIUGCHudWidgetHierarchyNodeItemView m_View;

	private UGCHudWidget m_Widget;

	private UIUGCHudWidgetHierarchyController m_HierarchyController;

	private UIUGCHudWidgetHierarchyNodeItemController m_Parent;

	private List<UIUGCHudWidgetHierarchyNodeItemController> m_Children;

	private Action<UIUGCHudWidgetHierarchyNodeItemController> m_ItemSelectedCallback;

	private Action m_ExpandCallback;

	private const float m_OffsetX = 30f;

	private const float DRAG_TIME = 0.5f;

	public const float ITEM_HEIGHT = 62f;

	public const float HALF_ITEM_HEIGHT = 31f;

	private static uint s_MaxHierarchyLimit;

	private int m_Index;

	private float m_InitPosX;

	private float m_PressTime;

	private bool m_IsPress;

	private bool m_IsExpand;

	private OperateStateEnum m_OperateState;

	private bool m_NeedUpdateLayout;

	private bool m_UpdateLayoutUpwards;

	public uint Hierarchy => 0u;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsExpand => false;

	public UGCHudWidget Widget => null;

	public UIUGCHudWidgetHierarchyNodeItemController ParentNode => null;

	public List<UIUGCHudWidgetHierarchyNodeItemController> Children => null;

	public int ChildCount => 0;

	public uint ChildMaxRelativeHierary => 0u;

	public UIUGCHudWidgetHierarchyController HierarchyController => null;

	public Vector3 RelativePosition => default(Vector3);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindWidget(UGCHudWidget widget)
	{
	}

	public bool SetParent(UIUGCHudWidgetHierarchyNodeItemController node, bool syncWidget = false)
	{
		return false;
	}

	public bool Insert(UIUGCHudWidgetHierarchyNodeItemController node, bool insertBack)
	{
		return false;
	}

	public int FindChildIndex(UIUGCHudWidgetHierarchyNodeItemController node)
	{
		return 0;
	}

	public void SetCallback(Action<UIUGCHudWidgetHierarchyNodeItemController> selectedCallback, Action expandCallback)
	{
	}

	public void SetChildrenActived(bool value, bool recursive)
	{
	}

	public void OnRecycle()
	{
	}

	public void Clear()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateLayout(bool upwards)
	{
	}

	public void SetExpand(bool expand, bool recursive = false)
	{
	}

	protected void AddChildNode(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	protected void RemoveChildNode(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	protected void OnHierarchyDirty()
	{
	}

	protected void OnChildCountDirty()
	{
	}

	private void ForeachChildren(List<UIUGCHudWidgetHierarchyNodeItemController> children, Func<UIUGCHudWidgetHierarchyNodeItemController, bool> func, bool recursive = true)
	{
	}

	private void SetRetract()
	{
	}

	private void OnWidgetNameChanged()
	{
	}

	private void SwitchOperateState(OperateStateEnum state)
	{
	}

	private void OnExitOperateState(OperateStateEnum state)
	{
	}

	private void OnEnterOperateState(OperateStateEnum state)
	{
	}

	private void OnArrowClick()
	{
	}

	private void OnActiveToggleClick()
	{
	}

	private void OnClick()
	{
	}

	private void OnPress(bool isPress)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void Update()
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
