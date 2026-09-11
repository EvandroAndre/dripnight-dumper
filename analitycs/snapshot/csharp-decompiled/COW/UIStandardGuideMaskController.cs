using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardGuideMaskController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public List<EventDelegate> guideEvent;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Action action;

		public UIStandardGuideMaskController _003C_003E4__this;

		internal void _003CAddActionToAreaBtn_003Eb__0()
		{
		}
	}

	private UIStandardGuideMaskView m_View;

	private Material m_MaskMat;

	private Transform m_MaskTrans;

	private Action m_Action;

	private Action m_SkipAction;

	private UIRightReigonClickMask m_ClickMask;

	private const int m_PanelDepth = 20;

	private const int m_ColliderHalfWidth = 1250;

	private const int m_ColliderHalfHeight = 750;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(UIWidget widget, List<EventDelegate> guideEvent = null, Action guideAction = null, bool needClickClose = false, bool useClickRightRegion = false, bool enableSkip = false, Action skipAction = null)
	{
	}

	public void DisableMaskClickBtn()
	{
	}

	public void SetMaskBgAlpha(float alpha)
	{
	}

	private void UpdateClickMask(bool needClickClose, UIWidget widget)
	{
	}

	public void AddActionToAreaBtn(UIWidget widget, Action action)
	{
	}

	private void UpdateClickBtn(bool needClickClose, UIWidget widget, Vector3 localPos)
	{
	}

	public void UpdateDepth(int newDepth)
	{
	}

	private void OnGuideAreaClick()
	{
	}

	private void OnSkipButtonClick()
	{
	}

	private void UpdateClickMask(UIWidget widget)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
