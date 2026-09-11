using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipEntranceItemController : UIOnlineMatchEntranceItemController, ITipsDelegate
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

		protected UIChampionshipEntranceItemView m_View;

		protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

		protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

		protected UIModelChampionship m_ModelChampionship;

		protected uint m_ChampionshipType;

		protected UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

		protected MapOpeningInfo m_MapInfo;

		private bool m_Clicked;

		private Dictionary<int, UIToggleButton> m_StateBtnDict;

		private Dictionary<uint, GameObject> m_OpenDayDict;

		private Dictionary<uint, GameObject> m_UnOpenDayDict;

		private UIChampionshipEntranceItemController m_Ctrl;

		protected static Dictionary<int, EntranceStateInfo> m_EntranceStateInfoDict;

		public EntranceInfo(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		public void RefreshView()
		{
		}

		protected virtual void OnRefreshView()
		{
		}

		private void SetDetailedInfo()
		{
		}

		private void SetSettingInfo()
		{
		}

		protected virtual void OnSetSettingInfo()
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

		public void Clear()
		{
		}
	}

	private class FFCEntrance : EntranceInfo
	{
		public FFCEntrance(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		protected override void OnRefreshView()
		{
		}

		protected override void OnSetSettingInfo()
		{
		}

		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}

		public void _003C_003EiFixBaseProxy_OnSetSettingInfo()
		{
		}
	}

	private class OpenThirdPartyEntrance : EntranceInfo
	{
		public OpenThirdPartyEntrance(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		protected override void OnRefreshView()
		{
		}

		protected override void OnSetSettingInfo()
		{
		}

		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}

		public void _003C_003EiFixBaseProxy_OnSetSettingInfo()
		{
		}
	}

	private uint m_ChampionshipType;

	private UIChampionshipEntranceItemView m_View;

	private EntranceInfo m_EntranceInfo;

	private UIModelChampionship m_ModelChampionship;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(EntranceType type, uint championshipType = 1u)
	{
	}

	private void SetLockView()
	{
	}

	private void CreateEntranceInfo(EntranceType type)
	{
	}

	protected override void OnEntranceAnimFinish()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
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
}
