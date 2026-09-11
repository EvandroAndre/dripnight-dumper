using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryItemControllerTable2 : UIHudInventoryItemController, UITable2.IUITable2Item
{
	private new UIHudInventoryItemView m_View;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public new static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
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

	public new bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
