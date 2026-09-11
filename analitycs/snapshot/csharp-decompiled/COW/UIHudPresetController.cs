using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHudPresetController : UIBaseController
{
	public int IndexSelected;

	private UIHudPresetView m_View;

	private List<UIHudPresetItemController> m_ItemList;

	private Dictionary<int, List<MOHNBCEFAHC>> m_DataList;

	private bool m_Init;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetViewData(BELMKOCOMPA data)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnShowPresetRefreshCount(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
