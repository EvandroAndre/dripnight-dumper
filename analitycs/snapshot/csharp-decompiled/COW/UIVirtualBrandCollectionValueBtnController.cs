using GCommon;
using UnityEngine;

namespace COW;

internal class UIVirtualBrandCollectionValueBtnController : UIBaseController
{
	private UIVirtualBrandCollectionValueBtnView m_View;

	private UIModelVirtualBrand m_Model;

	private uint m_BrandID;

	private ResourceID VFX_RES;

	private GameObject m_VFXGo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandID, bool needBtn, bool showFX = true)
	{
	}

	private void OnBtnClick()
	{
	}

	public void RefreshRedDot(bool showFX)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
