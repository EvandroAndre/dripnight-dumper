using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchEntranceItemController : UIOnlineMatchEntranceItemController, IUIModelDataChangeObserver
{
	private class EntranceInfo
	{
		protected class EntranceStateInfo
		{
			public bool SubscriptState;

			public string SubscriptText;

			public bool TicketState;

			public bool ShowTimeEffect;

			public bool ShowSeasonTime;

			public bool ShowWeekTime;

			public bool ShowDayTime;

			public bool ShowStartTime;

			public bool ShowSettleTime;

			public bool ShowMatchFinished;

			public string OpenTimeDescText;

			public bool ShowComingSoon;

			public bool ShowDetailBtn;

			public bool ShowOpenTime;
		}

		private UIChampionshipEntranceItemView m_View;

		private CupOpenInfoDesc m_CupMatchOpenInfo;

		private CupSettingDesc m_CupMatchSetting;

		private CupCDNSettingDesc m_CupCDNSetting;

		private UIModelCupMatch m_ModelCupMatch;

		private int m_CupMatchKey;

		private UIModelCupMatch.CupMatchOpenState m_CupMatchState;

		private MapOpeningInfo m_MapInfo;

		private bool m_Clicked;

		private Dictionary<int, UIToggleButton> m_StateBtnDict;

		private Dictionary<uint, GameObject> m_OpenDayDict;

		private Dictionary<uint, GameObject> m_UnOpenDayDict;

		private UICupMatchEntranceItemController m_Ctrl;

		private UICountDownController m_CountDownCtrl;

		protected Dictionary<int, EntranceStateInfo> m_EntranceStateInfoDict;

		public EntranceInfo(UICupMatchEntranceItemController ctrl, int key)
		{
		}

		public void RefreshView()
		{
		}

		private void SetDetailedInfo()
		{
		}

		private void SetSettingInfo()
		{
		}

		protected void SetOpenInfo()
		{
		}

		protected void SetMapOpenInfo()
		{
		}

		private void RefreshViewByState()
		{
		}

		private void OnEntranceBtnClick()
		{
		}

		public void OnEntranceAnimFinish()
		{
		}

		private void _003CRefreshViewByState_003Eb__22_0()
		{
		}
	}

	private UIChampionshipEntranceItemView m_View;

	private EntranceInfo m_EntranceInfo;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(int key)
	{
	}

	private void SetLockView()
	{
	}

	private void CreateEntranceInfo(int key)
	{
	}

	protected override void OnEntranceAnimFinish()
	{
	}

	public override long GetEntranceOpenTime()
	{
		return 0L;
	}

	public override long GetSeasonStartTime()
	{
		return 0L;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override int GetMatchType()
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEntranceAnimFinish()
	{
	}

	public long _003C_003EiFixBaseProxy_GetEntranceOpenTime()
	{
		return 0L;
	}

	public long _003C_003EiFixBaseProxy_GetSeasonStartTime()
	{
		return 0L;
	}

	public int _003C_003EiFixBaseProxy_GetPriority()
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_GetMatchType()
	{
		return 0;
	}
}
