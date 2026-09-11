using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObLocallEventPanelController : UIBaseController
{
	private class LocalEventItem
	{
		public GameObject gray;

		public UISprite icon;

		public UILabel name;

		public int eventID;

		public UIToggleButton toggle;
	}

	private UIHudObLocallEventPanelView m_View;

	private List<LocalEventItem> m_EventData;

	private int m_EventIdSelected;

	private LocalEventItem m_EventItemSelected;

	private LGBPPLOIEON m_EventManager;

	private UITimeLabelHelper m_TimeHelper;

	private bool isCD;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMapStateChange(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetUIData()
	{
	}

	private void RefreshCD()
	{
	}

	private void OnCDEndNtf(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnToggleBtnClick(object obj, int idx)
	{
	}

	private void OnEventConfirm(object[] data)
	{
	}

	private void OnShowLocalEventPanel(object[] data)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnBigmapClose(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
