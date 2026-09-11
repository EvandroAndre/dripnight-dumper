using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoPassRewardGunItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIEvoPassRewardGunItemView m_View;

	private UIModelEvoPass m_ModelEvoPass;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	object UITable2.IUITable2Item.SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	void UITable2.IUITable2Item.SetPosition(Vector2 position)
	{
	}

	void UITable2.IUITable2Item.SetTable2Visible(bool visible)
	{
	}

	private void RefreshData()
	{
	}

	private void ShowPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
