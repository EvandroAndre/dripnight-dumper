using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneDropdownItemWithIconController : UIBaseController, UITable2.IUITable2Item
{
	private UIHudSceneDropdownItemWithIconView m_View;

	private UIHudSceneDropDownItemWithIconData m_Data;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	private void RefreshNormalIcon(ResourceID resourceID)
	{
	}

	private void RefreshNormalLabel(string label)
	{
	}

	private void RefreshSelectedIcon(ResourceID resourceID)
	{
	}

	private void RefreshSelectedLabel(string label)
	{
	}

	private void RefreshSelectedState(bool selected)
	{
	}

	private void OnItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
