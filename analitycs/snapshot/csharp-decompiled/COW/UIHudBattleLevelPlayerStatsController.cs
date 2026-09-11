using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelPlayerStatsController : UIHudLevelPlayerStatsController
{
	private sealed class _003CCreateClickMask_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleLevelPlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateClickMask_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CHideDetailTipAndClickMaskCoroutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleLevelPlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideDetailTipAndClickMaskCoroutine_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CLevelUpAnimationProcedure_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleLevelPlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLevelUpAnimationProcedure_003Ed__34(int _003C_003E1__state)
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

	private static readonly WaitForSeconds m_DetailTipsAfterShopWaitSecs;

	private const string m_LevelUpAnimationClipName1 = "UIFX_UIHudBattleLevelPlayerStats";

	private const string m_LevelUpAnimationClipName2 = "UIFX_UIHudBattleLevelPlayerStats_2";

	private const float m_LevelUpAnimationClipDuration1 = 3.5f;

	private const float m_LevelUpAnimationClipDuration2 = 0.7f;

	private const float m_CircleExpBarOffsetDegrees = 36f;

	private const float m_CircleExpBarFillAmountMin = 0.1f;

	private const float m_CircleExpBarFillAmountMax = 0.9f;

	private const float m_ExpIncreaseVfxLifetime = 5f;

	private const float m_LevelUpVfxLifetime = 5f;

	private const float m_DetailTipsAfterShopDurationSecs = 3f;

	private byte m_PreviousPlayerLevelOnDetailTipShown;

	private UIHudBattleLevelPlayerStatsView m_View;

	private UIClickMask m_PopupClickMask;

	private VisualInstanceHolder m_ExpIncreaseVfxHolder;

	private VisualInstanceHolder m_LevelUpVfxHolder;

	private VisualInstanceHolder m_LevelMaxVfxHolder;

	private UIHudBattleLevelDetailTipsPopupWndController m_DetailTipPopoverCtrl;

	private NKDHFJHPEFL m_BattleLevelModule;

	private JHNCAGHNHAK m_BindPlayerModule;

	private Coroutine m_LevelUpAnimationCoroutine;

	private Coroutine m_CreateClickMaskCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnPlayerExpChange(uint playerID)
	{
	}

	private void OnPlayerLevelChange(uint playerID)
	{
	}

	private void OnCSShopHideTryShowDetailTipPopover()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void RefreshBuildIcon()
	{
	}

	private void RefreshLevelProperties()
	{
	}

	private void RefreshExpProgress()
	{
	}

	private void StartLevelUpAnimationFCoroutine()
	{
	}

	private IEnumerator LevelUpAnimationProcedure()
	{
		return null;
	}

	private void PlayLevelUpVfx()
	{
	}

	private void PlayExpIncreaseVfx()
	{
	}

	private void RefreshLevelMaxVfx()
	{
	}

	private void ReleaseAllVfxInstances()
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void TryCloseDetailTipPopover()
	{
	}

	private void TryStopCreateClickMaskCoroutine()
	{
	}

	private void TryStopLevelUpAnimationCoroutine()
	{
	}

	private void StopLevelUpAnimationCoroutineWithReset()
	{
	}

	private void StartCreateClickMaskCoroutine()
	{
	}

	private IEnumerator CreateClickMask()
	{
		return null;
	}

	private void OnClickMaskTriggered()
	{
	}

	private void ShowDetailTipPopoverWithClickMask(bool withGuideTargetWidget)
	{
	}

	private IEnumerator HideDetailTipAndClickMaskCoroutine()
	{
		return null;
	}

	private void AddEventDelegates()
	{
	}

	private void OnPopoverPressBtnPress(GameObject go, bool pressed)
	{
	}

	public override void RefreshContent()
	{
	}

	public override void BindPlayer(BHGGAEEHJCO playerID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_BindPlayer(BHGGAEEHJCO P0)
	{
	}
}
