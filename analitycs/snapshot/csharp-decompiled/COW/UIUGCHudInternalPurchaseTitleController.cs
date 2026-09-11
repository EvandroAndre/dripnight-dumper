using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudInternalPurchaseTitleController : UIBaseController, UITable2.IUITable2Item
{
	private UIUGCHudInternalPurchaseTitleView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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
}
