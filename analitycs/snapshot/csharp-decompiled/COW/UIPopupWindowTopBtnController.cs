using GCommon;
using UnityEngine;

namespace COW;

public class UIPopupWindowTopBtnController : UIBaseController
{
	private UIPopupWindowTopBtnView m_View;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(EventDelegate.Callback onBtnClose)
	{
	}

	public GameObject GetBtnGo()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
