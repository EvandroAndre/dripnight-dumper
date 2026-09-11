using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHudCSMatchResultController : UIHudTeamBattleMatchResultController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__45_0;

		internal void _003CQuickReportPlayer_003Eb__45_0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public BHGGAEEHJCO playerID;

		internal bool _003CCheckIsWinTeamPlayerForSpectator_003Eb__0(TeamData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public PlayerData player1;

		public PlayerData player2;

		internal bool _003CSortPlayerData_003Eb__0(TeammateStats x)
		{
			return false;
		}

		internal bool _003CSortPlayerData_003Eb__1(TeammateStats x)
		{
			return false;
		}
	}

	private sealed class _003CAfterClickQuickReportBtn_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSMatchResultController _003C_003E4__this;

		private float _003CaniamtionTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAfterClickQuickReportBtn_003Ed__41(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPlayDataToNormalChangeAnim_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDataToNormalChangeAnim_003Ed__23(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPlayNormalToDataChangeAnim_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayNormalToDataChangeAnim_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CQuickReportAutoOut_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CQuickReportAutoOut_003Ed__40(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIMatchResultWinStreakSpecialController m_UIMatchResultWinStreakSpecialController;

	private UIMatchResultWinStreakController m_UIMatchResultWinStreakController;

	private bool m_IsCSRankRatingOpen;

	private UITipsNormalController m_NewDataPageTipsCtrl;

	private bool m_HasClickQuickReport;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected override void UpdateMVPInfo(List<TeammateStats> players, bool win, bool needSetMVPPlayer, bool show = false)
	{
	}

	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortCSTeammateDataV2(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortCSTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected override bool CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO playerID)
	{
		return false;
	}

	protected override bool NeedReSortByTeamIndex()
	{
		return false;
	}

	protected override bool IsShowBlockBtn()
	{
		return false;
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected override void SetPageTypeAnim(bool show)
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override void UpdateInfoTitles()
	{
	}

	protected override void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
	{
	}

	private void UpdateSpecialLabel()
	{
	}

	private void UpdateWinStreakUI(bool show)
	{
	}

	protected override bool IsSelfShowSreakWin()
	{
		return false;
	}

	protected override bool IsOpponentShowSreakWin()
	{
		return false;
	}

	protected override IEnumerator PlayDataToNormalChangeAnim()
	{
		return null;
	}

	protected override IEnumerator PlayNormalToDataChangeAnim()
	{
		return null;
	}

	protected override void SetItemOnChangePageType()
	{
	}

	private bool IsShowWinStreakUI()
	{
		return false;
	}

	protected override void OnShareBtnClick()
	{
	}

	protected override void RefreshDetailDataInfoUIView(List<TeammateStats> players, bool localTeam)
	{
	}

	protected override void OnClickDataPageBtn()
	{
	}

	private void RefreshDataPageRedPoint()
	{
	}

	private void RefreshCSRankRatingGuide()
	{
	}

	private void OnNormalPageAnimEvent(object[] data)
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	private void OnClickDataRankRatingTip()
	{
	}

	private void OnClickTitleInfo3Tip()
	{
	}

	private void RefreshQuickReportView()
	{
	}

	private void OnClickQuickReportBtn()
	{
	}

	private IEnumerator QuickReportAutoOut()
	{
		return null;
	}

	private IEnumerator AfterClickQuickReportBtn()
	{
		return null;
	}

	private bool CheckNeedShowQuickReportAndGetPunishedPlayName(ref string name)
	{
		return false;
	}

	private bool IsQuickReportPlayerAlreadyReported(ulong matchID, ulong accountID)
	{
		return false;
	}

	private bool CheckHasBehaviorID(uint[] behaviors, uint targetBehaviorID)
	{
		return false;
	}

	private void QuickReportPlayer(ulong m_ReporteeUserId, string m_NickName, uint m_HeadPic, ulong m_MatchID, uint subReason)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_UpdateMVPInfo(List<TeammateStats> P0, bool P1, bool P2, bool P3)
	{
	}

	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return 0;
	}

	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedReSortByTeamIndex()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsShowBlockBtn()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetPageTypeAnim(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateTeammateInfo(bool P0, List<TeammateStats> P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSelfShowSreakWin()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsOpponentShowSreakWin()
	{
		return false;
	}

	public new IEnumerator _003C_003EiFixBaseProxy_PlayDataToNormalChangeAnim()
	{
		return null;
	}

	public new IEnumerator _003C_003EiFixBaseProxy_PlayNormalToDataChangeAnim()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetItemOnChangePageType()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnShareBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailDataInfoUIView(List<TeammateStats> P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickDataPageBtn()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}
}
