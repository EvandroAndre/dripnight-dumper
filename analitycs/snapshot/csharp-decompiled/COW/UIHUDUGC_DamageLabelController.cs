using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_DamageLabelController : UIBaseController
{
	private sealed class _003CDelayStay_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIHUDUGC_DamageLabelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayStay_003Ed__17(int _003C_003E1__state)
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

	private UIHUDUGC_DamageLabelView m_View;

	private UITweener[] m_Tweeners;

	private TweenPosition m_TweenPosition;

	private Camera m_GameCamera;

	private Camera m_UICamera;

	private Vector3 m_Position;

	private Vector2 m_RandomOffset;

	private bool m_DoTween;

	private bool m_IsInited;

	private bool m_CanUpdate;

	public static UIHUDUGC_DamageLabelController Create(string value, int fontSize, int color, int timeOfStay, UGCLogicEntity target, Vector3 offset, Vector2 randomRange, bool doTween)
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCameras()
	{
	}

	public void SetViewData(string value, int fontSize, int color, int timeOfStay, UGCLogicEntity target, Vector3 offset, Vector2 randomRange, bool doTween)
	{
	}

	private Vector2 GetPosition(Vector3 postion)
	{
		return default(Vector2);
	}

	private void LateUpdate()
	{
	}

	private IEnumerator DelayStay(float delay)
	{
		return null;
	}

	public void ResetUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
