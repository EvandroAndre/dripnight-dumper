using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassImportantRewardController : UIBaseController, UITable2.IUITable2Item
{
	private UIBooyahPassImportantRewardView m_View;

	private UIEasyListItemController m_RewardItem;

	private UIModelBooyahPass m_ModelBooyahPass;

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

	protected override void OnUIInit()
	{
	}

	public virtual void RefreshView(object data, int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
