using GCommon;
using proto;

namespace COW;

public class UITakePhotoFilterItemController : UIBaseController
{
	private UITakePhotoFilterItemView m_View;

	private PhotoFilterSettingDesc m_FilterData;

	private UITakePhotoFilterController m_ParentCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	internal void SetData(PhotoFilterSettingDesc filterData, UITakePhotoFilterController controller)
	{
	}

	private void OnItemBtnClick()
	{
	}

	public void ShowHideSelect(bool show)
	{
	}

	public bool IsNoneFilter()
	{
		return false;
	}

	public int GetFilterDataid()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
