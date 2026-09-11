using System;
using GCommon;

namespace COW;

public class UIVirtualBrandTipsController : UIBaseController
{
	private UIVirtualBrandTipsView m_View;

	private uint m_CurrentSelectItemID;

	private UIModelVirtualBrand m_Model;

	private uint m_CurrentSelectBrandId;

	private FrontendPreviewType m_CurrentPreviewType;

	public Action NavigationBtnClickAction;

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

	private void InitViewData()
	{
	}

	private void OnNavigateBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
