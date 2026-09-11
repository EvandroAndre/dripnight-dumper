using System;
using GCommon;

namespace COW;

internal class UIVirtualBrandShowCaseTabBtnController : UIBaseController
{
	private UIVirtualBrandShowCaseTabBtnView m_View;

	private const string TAB_ICON_SET = "FF_UI_VirtualBrand_TabIcon_Type01";

	private const string TAB_ICON_SINGLE_CLOTH = "FF_UI_VirtualBrand_TabIcon_Type02";

	private const string TAB_ICON_COLLECTION = "FF_UI_VirtualBrand_TabIcon_Type03";

	private const string TAB_ICON_WIDE = "FF_UI_VirtualBrand_TabIcon_Type04";

	private const uint MAX_COUNT = 99u;

	private UIModelVirtualBrand m_Model;

	private uint m_BrandID;

	private BrandShowCaseTabType m_TabType;

	private bool m_IsSelected;

	private Action<BrandShowCaseTabType> m_ClickCallback;

	public BrandShowCaseTabType TabType
	{
		get
		{
			return BrandShowCaseTabType.NONE;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandID, BrandShowCaseTabType tabType)
	{
	}

	private void SetSprites()
	{
	}

	private void SetSelected(bool isSelected)
	{
	}

	private void SetCount()
	{
	}

	public void SetLine(bool value)
	{
	}

	public void SetClickCallback(Action<BrandShowCaseTabType> func)
	{
	}

	public void ExternClick()
	{
	}

	public void ExternExit()
	{
	}

	private void OnTabBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
