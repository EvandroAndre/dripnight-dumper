using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPreviewTestController2 : UIPreviewNavigationController
{
	private UIPreviewTestView m_View;

	private UIPopMenuSmallControler m_PopMenuCtrl;

	private string m_SelectedCategory;

	private List<PopMenuData> m_MenuDatas;

	private List<string> m_Categories;

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void GenerateCategoryList()
	{
	}

	private void OnCategorySelect(object obj)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnNextPreviewButtonClick()
	{
	}

	private void OnLeftButtonClick()
	{
	}

	private void OnRightButtonClick()
	{
	}

	private void OnCenterButtonClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
