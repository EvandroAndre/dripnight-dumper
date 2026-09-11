using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIProfileCustomNewModuleRemindWndController : UIPopupWindowController
{
	private UIProfileCustomNewModuleRemindWndView m_View;

	private EProfileCustomRemindWndType m_WndType;

	private List<UIProfileCustomNewModuleRemindItemController> m_ItemCtrlList;

	private CommonRewardWindowStyleBaseController m_StyleBaseCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(EProfileCustomRemindWndType type, List<int> newModuleIdList)
	{
	}

	private void RefreshBGView()
	{
	}

	private void RefreshShowNewModule(List<int> idList)
	{
	}

	private void OnOkayBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
