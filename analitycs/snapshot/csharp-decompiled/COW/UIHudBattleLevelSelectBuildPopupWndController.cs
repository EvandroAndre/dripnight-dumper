using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelSelectBuildPopupWndController : UIPopupWindowController
{
	private sealed class _003CCloseSelectBuildPopup_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleLevelSelectBuildPopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseSelectBuildPopup_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003CSendSelectionChange_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleLevelSelectBuildPopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSendSelectionChange_003Ed__32(int _003C_003E1__state)
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

	private const float m_RedColorStartSecs = 10f;

	private const int m_CountdownSoundStartSecs = 5;

	private const int m_PreviousSupportedBuildCount = 3;

	private int m_CountdownTargetTime;

	private byte m_CurrentPreviewSelectedBuild;

	private byte m_RecordSelectedBuild;

	private UIHudBattleLevelSelectBuildPopupWndView m_View;

	private NKDHFJHPEFL m_BattleLevelModule;

	private UITimeLabelHelper m_TimeLabelHelper;

	private Coroutine m_SelectBuildCountdownCoroutine;

	private Coroutine m_SendSelectionChangeCoroutine;

	private readonly WaitForSeconds m_SendSelectionChangeIntervalSecs;

	private readonly WaitForSeconds m_ClosePopupAfterLocalConfirmSecs;

	private readonly Dictionary<byte, int> m_BuildToSelectCountTmp;

	private readonly Dictionary<byte, UIHudBattleLevelSelectBuildItemController> m_SelectBuildItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshSpecialShow()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnLocalPlayerSelectionConfirm()
	{
	}

	private void OnOtherPlayerSelectionChange()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupTimeLabelHelper()
	{
	}

	private bool IsConfirmSelectionAvailable()
	{
		return false;
	}

	private void RefreshConfirmButtonGroup(bool buildSelected)
	{
	}

	private void RefreshDisplayedBuilds()
	{
	}

	private void TryStopSendSelectionChangeCoroutine()
	{
	}

	private void StartSendSelectionChangeCoroutine()
	{
	}

	private bool SendSelectionIfChangeRecorded()
	{
		return false;
	}

	private IEnumerator SendSelectionChange()
	{
		return null;
	}

	private IEnumerator CloseSelectBuildPopup()
	{
		return null;
	}

	private void OnConfirmButtonClick()
	{
	}

	public void SetCountdownTargetTime(int targetTime)
	{
	}

	public void OnBuildItemSelected(UIHudBattleLevelSelectBuildItemController selectedCtrl)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
