using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCommonlTipsController : UIPopupWindowController
{
	private UIHudCommonlTipsView m_View;

	public Action<UIDetailTipsController> _onClose;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetData(Vector3 itemPos, string descrip, Vector3 offset, EArrowFixedType arrowFixedType = EArrowFixedType.None)
	{
	}

	private void _OnClose(object[] args)
	{
	}

	private void OnNavigationPused(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
