using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimeMainPageController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIPrimeMainPageController _003C_003E4__this;

		public int levelNeedPoint;

		internal void _003CUpdateProgressByAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003CPlayProgressAnimationCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPrimeMainPageController _003C_003E4__this;

		public int levelNeedPoint;

		private float _003CelapsedTime_003E5__2;

		private float _003CprogressAnimationStartValue_003E5__3;

		private float _003CprogressAnimationTargetValue_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressAnimationCoroutine_003Ed__29(int _003C_003E1__state)
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

	private UIPrimeMainPageView m_View;

	private UIModelPrime m_ModelPrime;

	private uint m_CurrentShowLevel;

	private List<UIPrimePrivilegeNormalItemController> m_PrivilegeCtrls;

	private uint m_NextLevelPrivilegeId;

	private UIPrimePrivilegeBadgeController m_BadgeController;

	private const float PROGRESS_ANIMATION_DURATION = 1f;

	private float m_ProgressAnimationDuration;

	private Coroutine m_ProgressAnimationCoroutine;

	private uint m_ProgressAnimationTimerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void InitMainPageInfo()
	{
	}

	private void RefreshMainPage()
	{
	}

	private void RefreshLeftBadge()
	{
	}

	private void RefreshLevelInfo()
	{
	}

	private void UpdateProgress()
	{
	}

	private void SetMaxLevelLabel()
	{
	}

	private void RefreshPrimePointsLabelStyle(bool isMax)
	{
	}

	private int GetLevelNeedPoint()
	{
		return 0;
	}

	private void UpdateProgressDirectly(int levelNeedPoint)
	{
	}

	private void RefreshChargeDesc()
	{
	}

	private void RefreshPrivileges()
	{
	}

	private void RefreshSwitchBtn()
	{
	}

	private bool CheckShouldPlayProgressAnimation(int levelNeedPoint)
	{
		return false;
	}

	private void UpdateProgressByAnimation(int levelNeedPoint)
	{
	}

	private IEnumerator PlayProgressAnimationCoroutine(int levelNeedPoint)
	{
		return null;
	}

	private void ResetProgressUpdateState()
	{
	}

	private void OnSwitchLeftBtnClick()
	{
	}

	private void OnSwitchRightBtnClick()
	{
	}

	private void OnGotoTopupClick()
	{
	}

	private void OnNextLevelBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
