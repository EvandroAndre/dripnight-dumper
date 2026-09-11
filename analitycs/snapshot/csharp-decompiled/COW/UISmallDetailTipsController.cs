using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UISmallDetailTipsController : UIPopupWindowController
{
	private UISmallDetailTipsView m_View;

	public Action<UIDetailTipsController> _onClose;

	private Action m_ConfirmCallBack;

	private Action m_CancelCallBack;

	private bool m_CloseWithCollider;

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

	public void SetData(Vector3 itemPos, BaseItemInfo info)
	{
	}

	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, TipsBtnInfo[] btn_info_list, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnCancleClick()
	{
	}

	private void CloseWithCollider()
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
