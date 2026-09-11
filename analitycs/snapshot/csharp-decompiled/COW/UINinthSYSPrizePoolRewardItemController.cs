using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSPrizePoolRewardItemController : UIBaseController, UITable2.IUITable2Item
{
	private UINinthSYSPrizePoolRewardItemView m_View;

	private UIModelNinthSYS.ItemAwardDesc m_ItemDesc;

	private UINinthSYSStandardItemMiniController m_ItemCtrl;

	private uint m_SelectedID;

	private UIModelNinthSYS.IAwardPoolPreview m_AwardPoolPreview;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickItemCallback()
	{
	}

	public void SetAwardPoolPreview(UIModelNinthSYS.IAwardPoolPreview awardPoolPreview)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
