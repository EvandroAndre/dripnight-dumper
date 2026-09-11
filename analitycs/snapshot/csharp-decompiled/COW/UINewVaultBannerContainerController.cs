using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UINewVaultBannerContainerController : UIBaseController, IEasyList
{
	private UINewVaultBannerContainerView m_View;

	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Func<Transform, UIEasyListItemController> func)
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

	public void SetScrollView(float sizeY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
