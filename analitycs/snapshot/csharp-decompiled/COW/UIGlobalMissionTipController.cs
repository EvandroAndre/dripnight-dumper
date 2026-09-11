using GCommon;
using UnityEngine;

namespace COW;

public class UIGlobalMissionTipController : UIPopupWindowController
{
	private UIGlobalMissionTipView m_View;

	private UIRoot m_UIRoot;

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

	public void SetPos(Vector3 itemPos)
	{
	}

	private void OnNavigationPushed(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
