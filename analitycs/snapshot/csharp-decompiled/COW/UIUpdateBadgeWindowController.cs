using GCommon;

namespace COW;

public class UIUpdateBadgeWindowController : UIPopupWindowController
{
	private UIUpdateBadgeWindowView m_View;

	private UIClanEditController.FuntionType m_MyFunctionType;

	private UIPopWndStandardDrawerTabRemakeController m_UIPrepareInfoTabController;

	private UIClanLogoShowController m_ClanIconShowCtrl;

	private UIClanLogoShowController m_ClanFrameShowCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetFunctionType(UIClanEditController.FuntionType type)
	{
	}

	private void SetGoRightPanelShow(EClanLogoToggle eToggle)
	{
	}

	private void CreateTab()
	{
	}

	private void OnClickIconSetting()
	{
	}

	private void OnClickFrameSetting()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
