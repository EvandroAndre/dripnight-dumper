using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisGuideController : UIBaseController
{
	private sealed class _003CPlayAnim_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisGuideController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnim_003Ed__13(int _003C_003E1__state)
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

	private UIHudMetropolisGuideView m_View;

	private uint m_LastGuideMissionId;

	private UIHudMetropolisNewMissionGuideController m_HudNewMissionGuide;

	private Coroutine m_EffectCoroutine;

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

	public void ShowContent(bool isShow)
	{
	}

	public Vector3 GetTokenFlyStartPos()
	{
		return default(Vector3);
	}

	private void OnClickMissionBtn()
	{
	}

	private void OnClickGuideBtn()
	{
	}

	private void OnRefreshGuideMission()
	{
	}

	private void OnUpdateGuideMissionData(uint missionId)
	{
	}

	private IEnumerator PlayAnim()
	{
		return null;
	}

	private void UpdateMissionData(LIFOHNKCMKF mission)
	{
	}

	private void OnUpdateBonus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
