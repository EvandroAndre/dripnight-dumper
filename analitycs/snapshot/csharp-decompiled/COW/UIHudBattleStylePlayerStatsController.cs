using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStylePlayerStatsController : UIHudLevelPlayerStatsController
{
	private sealed class _003CCreateClickMask_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleStylePlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateClickMask_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CDelayHideContine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleStylePlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideContine_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CDelayHideNextInfo_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBattleStylePlayerStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideNextInfo_003Ed__27(int _003C_003E1__state)
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

	private const float m_CircleExpBarOffsetDegrees = 36f;

	private const float m_CircleExpBarFillAmountMin = 0.1f;

	private const float m_CircleExpBarFillAmountMax = 0.9f;

	private const float m_LevelUpVfxLifetime = 5f;

	private UIHudBattleStylePlayerStatsView m_View;

	private UIClickMask m_PopupClickMask;

	private VisualInstanceHolder m_LevelUpVfxHolder;

	private UIHudBattleStyleDetailTipsPopupWndController m_DetailTipPopoverCtrl;

	private UIModelLoadout m_ModelLoadout;

	private GKNHKOFFCPG m_BindPlayerModule;

	private Coroutine m_CreateClickMaskCoroutine;

	private float m_NextLvlShowPro;

	private bool m_NextLvlShowFlag;

	private Coroutine m_ShowNextCoroutine;

	private Coroutine m_ShowRewardCoroutine;

	private bool m_PlayingMaxAni;

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

	private void ShowNextLevelInfo()
	{
	}

	private IEnumerator DelayHideNextInfo()
	{
		return null;
	}

	private void ResetAnimation()
	{
	}

	private void StopNextInfoCor()
	{
	}

	private void StopRewardCor()
	{
	}

	private void PlayLevelUpVfx()
	{
	}

	private void SetNextBuildIcon(byte nextLevel)
	{
	}

	private void RefreshLevelMaxVfx()
	{
	}

	private IEnumerator DelayHideContine()
	{
		return null;
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

	private void AddEventDelegates()
	{
	}

	private void OnPopoverPressBtnPress(GameObject go)
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
