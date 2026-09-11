using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeChildrenController : UIBaseController, IUIHudSceneEditInspectorItemAttribute
{
	private UISceneEditItemAttributeChildrenView m_View;

	private List<UISceneEditChildAttributeItem> mChildren;

	private List<GameObject> mCachedItems;

	private SceneEditObjectGroup mGroup;

	private UISceneEditChildAttributeItem mSelect;

	private int mDragIndex;

	private float mDragFrameOffsetY;

	private Action m_OnRefreshListRequested;

	private SceneEditAgent agent;

	private HNDHJGJILHC m_Game;

	private ItemEditAttributeUIDataChildren mData;

	private SceneEditAgent Agent => null;

	public event Action OnRefreshListRequested
	{
		add
		{
		}
		remove
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	private void RefreshList()
	{
	}

	public void OnItemRemove(UISceneEditChildAttributeItem item)
	{
	}

	public void OnItemJump(UISceneEditChildAttributeItem item)
	{
	}

	public void OnItemSelect(UISceneEditChildAttributeItem item)
	{
	}

	private void ChildAttributeCloseBtnCallback()
	{
	}

	public void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	private void OnBtnAddClick()
	{
	}

	public Vector3 GetItemRelativePositon(Vector3 position)
	{
		return default(Vector3);
	}

	public void DragItemStart(UISceneEditChildAttributeItem item)
	{
	}

	public void DragItem(UISceneEditChildAttributeItem item, Vector2 delta)
	{
	}

	public void DragItemEnd(UISceneEditChildAttributeItem item)
	{
	}

	public void TriggerRefresh()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
