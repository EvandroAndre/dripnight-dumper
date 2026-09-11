using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditCustomEventWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public Action callback;

		public UIHudBlockEditCustomEventWndController _003C_003E4__this;

		internal void _003CSetPopupRootBtnCallback_003Eb__0()
		{
		}
	}

	private UIHudBlockEditCustomEventWndView m_View;

	private UIModelUGCCustomEventEdit m_Model;

	private bool m_Inited;

	private Color m_ParamListEmptyLabelColor;

	private List<UIHudBlockEditCustomEventWndEventItemController> m_EventItemControllers;

	private List<UIHudBlockEditCustomEventWndParamItemController> m_ParamItemControllers;

	private Dictionary<Transform, Transform> m_PopupRootTransformOriginalParentDic;

	public int PopupRootDepth => 0;

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

	private void OnBtnLeave()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnBtnNewEvent()
	{
	}

	private void OnSelectEventChanged()
	{
	}

	private void RefreshSelectedEvent()
	{
	}

	private void RefreshEventList()
	{
	}

	private void RefreshEventInspector()
	{
	}

	private void OnInitEventName()
	{
	}

	private void OnRefreshEventName()
	{
	}

	private void OnInitParamList()
	{
	}

	private void OnRefreshParamList()
	{
	}

	private void OnInitPopupRoot()
	{
	}

	public void SetToPopupRoot(Transform transform, Action popupRootBtnCallback = null)
	{
	}

	public void SetPopupItemBack(Transform transform)
	{
	}

	private void RefreshPopupItemParent(Transform transform)
	{
	}

	private void SetPopupRootBtnCallback(Action callback)
	{
	}

	public void ClosePopupRootBtn()
	{
	}

	private void _003COnInitEventName_003Eb__16_0()
	{
	}

	private void _003COnInitParamList_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
