using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRematchInvitePopupController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CCountDownUpdateCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRematchInvitePopupController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCountDownUpdateCoroutine_003Ed__50(int _003C_003E1__state)
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

	private sealed class _003CPassiveAcceptCountDownCoroutine_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRematchInvitePopupController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPassiveAcceptCountDownCoroutine_003Ed__42(int _003C_003E1__state)
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

	private const string IgnoreTodayKeyPrefix = "RematchInvitePopupIgnore_";

	private const int IgnoreTodayEffectiveDelaySeconds = 30;

	private const char IgnoreTodayValueSeparator = '|';

	private const uint RematchReasonTeamKills = 1u;

	private const uint RematchReasonTeamRevives = 2u;

	private const uint RematchReasonAvgRating = 3u;

	private const uint RematchReasonRankUp = 4u;

	private bool m_StartPlayAnimOut;

	private const string ANIM_IN = "UIFX_UIRematchInvitePopup_In";

	private const string ANIM_OUT = "UIFX_UIRematchInvitePopup_Out";

	private const string RematchReasonTeamKillsLocKey = "T_54_D_FIGHTON_REASON1";

	private const string RematchReasonTeamRevivesLocKey = "T_54_D_FIGHTON_REASON2";

	private const string RematchReasonAvgRatingLocKey = "T_54_D_FIGHTON_REASON3";

	private const string RematchReasonRankUpLocKey = "T_54_D_FIGHTON_REASON4";

	private const float PassiveAcceptDuration = 2f;

	private const string PassiveAcceptLabelFormat = "Teammates accept {0}s";

	private static readonly Dictionary<uint, string> RematchReasonToLocKey;

	private UIRematchInvitePopupView m_View;

	private UIModelGroup m_ModelGroup;

	private Coroutine m_CountDownCoroutine;

	private Coroutine m_PassiveAcceptCoroutine;

	private bool m_IsIgnoreTodaySelected;

	private bool m_PassiveAcceptSnapshotInitialized;

	private bool m_PassiveAcceptStarted;

	private bool m_HasAcceptedTeammateInCurrentGroup;

	private readonly List<UIRematchInvitePlayerItemController> m_PlayerItemCtrls;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	public void RefreshUI()
	{
	}

	public static bool IsIgnoreToday()
	{
		return false;
	}

	private static void SetIgnoreToday()
	{
	}

	private static bool TryParseIgnoreTodayValue(string savedValue, out string ignoreDate, out ulong effectiveFromTimestamp)
	{
		ignoreDate = null;
		effectiveFromTimestamp = default(ulong);
		return false;
	}

	private static void ClearIgnoreToday()
	{
	}

	private static string GetIgnoreTodayKey()
	{
		return null;
	}

	private void RefreshPlayerItems()
	{
	}

	private void ResetPassiveAcceptState()
	{
	}

	private void TryStartPassiveAcceptCountdown()
	{
	}

	private void StartPassiveAcceptCountdownAndHideTimer()
	{
	}

	private IEnumerator PassiveAcceptCountDownCoroutine()
	{
		return null;
	}

	private void StopPassiveAcceptCountdown()
	{
	}

	private void SetPassiveAcceptVisible(bool visible)
	{
	}

	private void RefreshPassiveAcceptLabel(int remainingSeconds)
	{
	}

	private bool HasAcceptedTeammateInCurrentGroup()
	{
		return false;
	}

	private string GetRematchReasonText()
	{
		return null;
	}

	private void StartCountDownUpdate()
	{
	}

	private void StopCountDownUpdate()
	{
	}

	private IEnumerator CountDownUpdateCoroutine()
	{
		return null;
	}

	private void OnAcceptBtnClick()
	{
	}

	public void PlayOutAnim()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void RefuseAndClose()
	{
	}

	private bool RequestAcceptRematch()
	{
		return false;
	}

	private void RequestQuitRematch(bool needLog)
	{
	}

	private void RefreshQuickMatchState()
	{
	}

	public void SaveIgnoreTodayIfChecked()
	{
	}

	private void OnIgnoreToggleClick()
	{
	}

	private void SetIgnoreTodaySelected(bool selected)
	{
	}

	private void RefreshIgnoreTodayToggleState()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
