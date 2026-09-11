using GCommon;
using proto;

namespace COW;

public class UIAchievementMainBigEventItemController : UIEasyListItemController
{
	protected UIAchievementMainBigEventItemView m_View;

	protected UIModelAchievement m_Model;

	protected uint m_CurrentCoverId;

	protected uint m_BigEventId;

	private AchievementEntryDesc m_Desc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public void SelectCoverView(bool isShare, bool isSelf)
	{
	}

	public void OnBtnSelectCoverClick(object[] data)
	{
	}

	public void RefreshDecoration(int index)
	{
	}

	protected void RefreshInfo(uint level)
	{
	}

	private void OnBtnShowDetailWndClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
