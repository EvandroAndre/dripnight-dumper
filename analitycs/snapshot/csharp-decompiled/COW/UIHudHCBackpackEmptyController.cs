using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHCBackpackEmptyController : UIBaseController, UITable2.IUITable2Item
{
	private UIHudHCBackpackEmptyView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	void UITable2.IUITable2Item.SetPosition(Vector2 position)
	{
	}

	object UITable2.IUITable2Item.SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	void UITable2.IUITable2Item.SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
