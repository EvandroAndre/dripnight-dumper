using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudHippoCrisisBackpackItemController : UIHippoCrisisCanDragItem, UITable2.IUITable2Item
{
	private UIHudHippoCrisisBackpackItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void HideSelected(object[] data)
	{
	}

	public override void OnDragDropMove(Vector2 delta)
	{
	}

	public void InitData(EHippoInventory.EquipType equipType, UIHippoCrisisDragResponseContainer container)
	{
	}

	public UIButton GetClickButton()
	{
		return null;
	}

	void UITable2.IUITable2Item.SetPosition(Vector2 position)
	{
	}

	public override void OnItemClick()
	{
	}

	object UITable2.IUITable2Item.SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	void UITable2.IUITable2Item.SetTable2Visible(bool visible)
	{
	}

	private void RefreshUI()
	{
	}

	public Vector2 GetWidgetV2()
	{
		return default(Vector2);
	}

	public override bool OnDragStart()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnDragStart()
	{
		return false;
	}
}
