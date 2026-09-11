using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal class UIHudCSPeakLadderMatchResultController : UIPopupWindowController
{
	private enum ERankChangeState
	{
		None,
		RankUp,
		RankDown
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public UIHudCSPeakLadderMatchResultController _003C_003E4__this;

		public Vector2 fitSize;

		internal void _003CSetCDNBG_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayHideRankMiddleVfx_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIHudCSPeakLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideRankMiddleVfx_003Ed__53(int _003C_003E1__state)
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

	private sealed class _003CPlayAndWaitingForAnimationOver_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animation animationCom;

		public string animation;

		private float _003CaniamtionTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAndWaitingForAnimationOver_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003CPlayCSPeakEnergyConsumeAnim_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSPeakLadderMatchResultController _003C_003E4__this;

		private float _003CdeltaTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayCSPeakEnergyConsumeAnim_003Ed__51(int _003C_003E1__state)
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

	private sealed class _003CPlayScoreAnimation_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSPeakLadderMatchResultController _003C_003E4__this;

		private float _003CanimationDuration_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private int _003CstartScore_003E5__4;

		private int _003CendScore_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayScoreAnimation_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CStartLadderResultAnimation_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSPeakLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLadderResultAnimation_003Ed__52(int _003C_003E1__state)
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

	private UIHudCSPeakLadderMatchResultView m_View;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeak;

	private const string ANIMATION_ENTER = "UIHudCSPeakLadderMatchResult_In";

	private const string ANIMATION_RANK_UP = "UIFX_CSPeak_RankUp";

	private const string ANIMATION_RANK_DOWN = "UIFX_CSPeak_RankDown";

	private const string ANIMATION_FIRST_REACH = "UIFX_CSPeak_RankUpFirstReach";

	private const float RANK_UPDATE_WAIT_TIME = 0.1f;

	private DLBMPCCFKKM m_MatchMode;

	private bool m_IsWin;

	private int m_PointsBefore;

	private int m_PointsAfter;

	private int m_EnergyPointBefore;

	private int m_EnergyPointAfter;

	private int m_EnergyPointConsume;

	private int m_EnergyPointDelta;

	private int m_MvpBonus;

	private int m_DailyTaskPoints;

	private bool m_IsEnergyFreeze;

	private bool m_IsEnergyHide;

	private bool m_IsEnergyFirstFreeze;

	private CSPeakTournamentData CurrentLevelData;

	private CSPeakTournamentData OldLevelData;

	private bool m_IsFirstReach;

	private MatchIncome m_MatchIncome;

	private MatchStats m_MatchStats;

	private bool m_BehaviorBanDrop;

	private bool m_CanCloseFlag;

	private string m_WeaponPowerTipDesc;

	private bool m_IsWinNoStar;

	private ERankChangeState m_RankChangeState;

	private int m_PointsDelta;

	private const float ENERGY_CONSUME_ANIM_TIME = 0.5f;

	protected VisualInstanceHolder m_CSPeakEnergyVFX;

	protected VisualInstanceHolder m_CSPeakBurstVFX;

	private int m_PenaltyPoints;

	private int m_CompensationPoints;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetResultData(MatchIncome incomeData, MatchStats statsData, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHNODE_CSRANKING)
	{
	}

	public void ShowTestCSPeakUI(bool isWin = true, int rankBefore = 1300, int rankafter = 1316, int energyBefore = 500, int energyAfter = 520, int consumeEnergy = 8, bool isFirstReach = false, int mvpBonus = 0, int dailyTaskBonus = 0, int penaltyPoints = 0, int compensationPoints = 0)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnWeaponPowerTitleTip()
	{
	}

	private void OnOccupationUpdateTipClick()
	{
	}

	private void OnCSPeakEnergyTitleTipClick()
	{
	}

	private void OnCSPeakWinStatTipClick()
	{
	}

	private void SetOccupationUpdate()
	{
	}

	private CSPeakTournamentData GetRankDataByPoints(int points)
	{
		return null;
	}

	private void OnMaskClick()
	{
	}

	private IEnumerator PlayCSPeakEnergyConsumeAnim()
	{
		return null;
	}

	private IEnumerator StartLadderResultAnimation()
	{
		return null;
	}

	private IEnumerator DelayHideRankMiddleVfx(float delay)
	{
		return null;
	}

	private void InitRankInfo()
	{
	}

	private IEnumerator PlayScoreAnimation()
	{
		return null;
	}

	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	private void SetInvalidMatch()
	{
	}

	private void SetScoreInfoPanel()
	{
	}

	private bool IsInvalidMatch()
	{
		return false;
	}

	private void SetCSPeakRankCon()
	{
	}

	private void SetScoreInfo()
	{
	}

	private void SetSpecialBonus()
	{
	}

	private void SetSpecialBonusItemViewData(uint bounsType, UIHudMatchResultSpecialBonusItemController ItemCtr)
	{
	}

	private void SetWeaponPower()
	{
	}

	private void SetToFinalState()
	{
	}

	private void SetCSPeakEnergy()
	{
	}

	private void SetCSPeakEnergyVFX()
	{
	}

	private void TryReleaseCSPeakEnergyVFX()
	{
	}

	private void SetCSPeakBurstVFX()
	{
	}

	private void TryReleaseCSPeakBurstVFX()
	{
	}

	private void SetCDNBG()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
