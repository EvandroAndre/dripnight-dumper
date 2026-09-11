using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIUGCSwitchModeController : UIPopupWindowController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public uint curMapID;

		public Predicate<uint> _003C_003E9__0;

		internal bool _003COnUIInit_003Eb__0(uint mapid)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public uint template;

		internal bool _003CSetUI_003Eb__0(WorkshopCreateNewConfigData e)
		{
			return false;
		}
	}

	private UIUGCSwitchModeView m_View;

	private WorkshopCreateNewManager m_Mgr;

	private Action<WorkshopCreateNewConfigData> m_SelectedCallBack;

	private WorkshopCreateNewConfigData m_CurSelected;

	private List<WorkshopCreateNewConfigData> m_ModeList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUI(uint selected, Action<WorkshopCreateNewConfigData> action)
	{
	}

	private void OnModeSelected(object[] data)
	{
	}

	private void OnCloseUI(object[] data)
	{
	}

	private void OnBtnApplyClick()
	{
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
