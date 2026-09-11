using GCommon;

namespace COW;

public class UIAchievementProfileItemController : UIEasyListItemController
{
	private UIAchievementProfileItemView m_View;

	private AchievementProfileItemData m_Data;

	private UIModelAchievement m_Model;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void ShowDisplay()
	{
	}

	public void HideDisplay()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public UIButton GetButton()
	{
		return null;
	}

	private void OnAchievementDisplay(object[] data)
	{
	}

	private bool _003CSetViewData_003Eb__7_0(AchievementProfileItemData item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
