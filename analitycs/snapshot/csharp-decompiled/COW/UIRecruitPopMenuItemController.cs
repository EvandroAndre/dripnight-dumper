using GCommon;

namespace COW;

public class UIRecruitPopMenuItemController : UIBaseController
{
	private UIRecruitPopMenuItemView m_View;

	private PopMenuData m_Data;

	private UIBRRankIconController m_BRRankIconController;

	private bool m_IsBR;

	private uint m_MatchMode;

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

	public void SetDragDisable()
	{
	}

	public void SetItemData(PopMenuData data)
	{
	}

	public void SetCellWidthWithParent(int width)
	{
	}

	private void OnPopMenuItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
