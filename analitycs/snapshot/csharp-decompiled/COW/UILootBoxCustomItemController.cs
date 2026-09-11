using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILootBoxCustomItemController : UIEasyListItemController, UITable2.IUITable2Item
{
	public UILootBoxCustomItemView m_View;

	private static readonly Color SelectedItemColor;

	private UILootBoxCustomItemData m_ItemData;

	private string m_ItemText;

	private readonly List<GameObject> m_IndexNumNodes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindDragScrollView(UIScrollView scrollView)
	{
	}

	private new void OnDestroy()
	{
	}

	private void OnItemButtonClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshDisplay(UILootBoxCustomItemData itemData)
	{
	}

	private void RefreshIndexNumNodes(List<int> indexes)
	{
	}

	private void RefreshItemState()
	{
	}

	private void SetSelectedBackgroundVisible(bool visible)
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}
