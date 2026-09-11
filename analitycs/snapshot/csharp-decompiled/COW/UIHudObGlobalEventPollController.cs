using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudObGlobalEventPollController : UIBaseController
{
	private class PollResultItem
	{
		public UILabel eventName;

		public UILabel eventRatio;

		public UILabel eventCount;

		public UIProgressBar progressBar;

		public GameObject item;
	}

	private class GlobalEventToggleItem
	{
		public uint eventID;

		public UILabel name;

		public UIToggleButton toggle;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<EventDelegate> _003C_003E9__12_0;

		public static Predicate<EventDelegate> _003C_003E9__12_1;

		public static Comparison<KMABEGNKCMF> _003C_003E9__16_0;

		internal bool _003CSetPollData_003Eb__12_0(EventDelegate d)
		{
			return false;
		}

		internal bool _003CSetPollData_003Eb__12_1(EventDelegate d)
		{
			return false;
		}

		internal int _003CSetResultData_003Eb__16_0(KMABEGNKCMF a, KMABEGNKCMF b)
		{
			return 0;
		}
	}

	private UIHudObGlobalEventPollView m_View;

	private LGBPPLOIEON m_GameEventMgr;

	private List<UIHudObGlobalEventPanelController.GlobalEventItem> m_OpenedCheckBox;

	private List<GlobalEventToggleItem> m_OpenedToggleBtns;

	private List<PollResultItem> m_OpenedPollResults;

	private List<byte> m_EventIdListSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetUIData()
	{
	}

	public void SetPollData()
	{
	}

	private void OnEventCheckBoxClick(object obj, int idx)
	{
	}

	private void OnEventToggleClick(object obj, int idx)
	{
	}

	private void RefreshConfirmBtn()
	{
	}

	public void SetResultData()
	{
	}

	private void OnPollNtf(object[] data)
	{
	}

	private void OnConfirm()
	{
	}

	private void OnClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
