using GCommon;
using proto;

namespace COW;

public class UITailorEntranceItemController : UIEasyListItemController
{
	private UITailorEntranceItemView m_View;

	private TailorSettingDesc m_Desc;

	private UIModelTailor m_ModelTailor;

	private ETailorState m_TailorState;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshView()
	{
	}

	public void SetState(bool isEasyListItem)
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	private void OnObtainBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}
