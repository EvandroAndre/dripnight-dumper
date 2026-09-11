using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UINewVaultMusicContainerController : UIBaseController, IEasyList
{
	private UINewVaultMusicContainerView m_View;

	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
