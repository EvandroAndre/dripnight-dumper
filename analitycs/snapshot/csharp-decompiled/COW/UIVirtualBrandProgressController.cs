using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIVirtualBrandProgressController : UIPopupWindowController
{
	private UIVirtualBrandProgressView m_View;

	private UIModelVirtualBrand m_Model;

	private uint m_CurBrandID;

	private const int MAX_NODE_COUNT = 5;

	private UIVirtualBrandCollectionValueBtnController m_ValueBtnCtrl;

	private List<UIVirtualBrandProgressItemController> m_ItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandID)
	{
	}

	private void OpenItemController(ConditionNode condition, bool isFirst)
	{
	}

	private void SetProgressBar()
	{
	}

	public override string Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}
}
