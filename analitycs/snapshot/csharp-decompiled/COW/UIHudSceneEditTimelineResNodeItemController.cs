using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineResNodeItemController : UIBaseController
{
	public enum OperateStateEnum
	{
		None,
		Drag
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MatchEvaluator _003C_003E9__41_0;

		internal string _003CSetViewData_003Eb__41_0(Match m)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public int value;

		internal bool _003Cget_ChildMaxRelativeHierary_003Eb__0(UIHudSceneEditTimelineResNodeItemController child)
		{
			return false;
		}
	}

	private UIHudSceneEditTimelineResItemView m_View;

	private UIHudSceneEditTimelineResMgrPanelController m_HierarchyController;

	private UIHudSceneEditTimelineResNodeItemController m_Parent;

	private List<UIHudSceneEditTimelineResNodeItemController> m_Children;

	private Action<UIHudSceneEditTimelineResNodeItemController> m_ItemSelectedCallback;

	private Action m_ExpandCallback;

	private const float m_OffsetX = 30f;

	private const float DRAG_TIME = 0.5f;

	public const float ITEM_HEIGHT = 50f;

	public const float HALF_ITEM_HEIGHT = 25f;

	private static uint s_MaxHierarchyLimit;

	private SceneEditObjectBase m_SceneEditObj;

	private float m_InitPosX;

	private bool m_IsExpand;

	private int _003CHierarchy_003Ek__BackingField;

	public SceneEditObjectBase SceneEditObj => null;

	public int Hierarchy
	{
		get
		{
			return _003CHierarchy_003Ek__BackingField;
		}
		private set
		{
			_003CHierarchy_003Ek__BackingField = value;
		}
	}

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

	public UIHudSceneEditTimelineResNodeItemController ParentNode => null;

	public List<UIHudSceneEditTimelineResNodeItemController> Children => null;

	public int ChildCount => 0;

	public int ChildMaxRelativeHierary => 0;

	public UIHudSceneEditTimelineResMgrPanelController HierarchyController => null;

	public Vector3 RelativePosition => default(Vector3);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void SetViewData(SceneEditObjectBase item, string search)
	{
	}

	public void SetItemName(string customizedName)
	{
	}

	public bool SetParent(UIHudSceneEditTimelineResNodeItemController parent, bool syncNode)
	{
		return false;
	}

	public bool Insert(UIHudSceneEditTimelineResNodeItemController node, bool insertBack)
	{
		return false;
	}

	public void SetCallback(Action<UIHudSceneEditTimelineResNodeItemController> selectedCallback, Action expandCallback)
	{
	}

	public void SetChildrenActived(bool value, bool recursive)
	{
	}

	public void OnRecycle(bool syncNode)
	{
	}

	public void Clear()
	{
	}

	public void UpdateLayout(bool upwards)
	{
	}

	public void SetExpand(bool expand, bool recursive = false)
	{
	}

	protected void AddChildNode(UIHudSceneEditTimelineResNodeItemController node, bool syncNode)
	{
	}

	protected void RemoveChildNode(UIHudSceneEditTimelineResNodeItemController node, bool syncNode)
	{
	}

	private void UpdateChildrenHierarchy()
	{
	}

	public void OnHierarchyDirty()
	{
	}

	public void SetSelected(bool value)
	{
	}

	protected void OnChildCountDirty()
	{
	}

	private void ForeachChildren(List<UIHudSceneEditTimelineResNodeItemController> children, Func<UIHudSceneEditTimelineResNodeItemController, bool> func, bool recursive = true)
	{
	}

	private void SetRetract()
	{
	}

	private void OnBackgroundClick()
	{
	}

	private void OnArrowClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
