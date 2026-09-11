using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCStandardDrawerTabController : UIBaseController
{
	protected UIUGCStandardDrawerTabView m_View;

	protected int count;

	private List<UGCStandardTabItemViewData> m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdatePanelDepth(int newDepth)
	{
	}

	public void BuildItems(List<UGCStandardTabItemViewData> data)
	{
	}

	public void SetSubTabDisappear(string key)
	{
	}

	public void SetSubTabAppear(string key)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void OnSelectItem(string key)
	{
	}

	public void TableReposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
