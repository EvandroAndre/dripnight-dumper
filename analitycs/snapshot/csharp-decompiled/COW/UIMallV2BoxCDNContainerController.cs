using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2BoxCDNContainerController : UIBaseController, IEasyList
{
	private UIMallV2BoxCDNContainerView m_View;

	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	private Action<UIEasyListItemController> m_FuncCloseItemController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Func<Transform, UIEasyListItemController> func, Action<UIEasyListItemController> closeItemCB)
	{
	}

	public UIEasyList GetEasyList()
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
