using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudWhiteScreenController : UIBaseController
{
	private sealed class _003CDoShowWhiteScreen_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudWhiteScreenController _003C_003E4__this;

		public float whiteSecs;

		public float fadeSecs;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoShowWhiteScreen_003Ed__17(int _003C_003E1__state)
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

	private const bool ReleaseTexOnHide = true;

	private const bool TmpRenderTex = false;

	private UIHudWhiteScreenView m_View;

	private TweenAlpha m_TweenAlpha;

	private TweenAlpha m_TweenScreenAlpha;

	private IEnumerator m_Coroutine;

	private EventDelegate m_Delegate;

	private float m_EndTime;

	private AudioResource m_AudioRes;

	private RenderTexture m_RenderTexture;

	private Camera m_RenderCam;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void ShowWhiteScreen(float secs)
	{
	}

	private float CalcEndTime(float secs)
	{
		return 0f;
	}

	private void StopUnfinishedCoroutine()
	{
	}

	private IEnumerator DoShowWhiteScreen(float whiteSecs, float fadeSecs)
	{
		return null;
	}

	private void StopWhiteScreenSound()
	{
	}

	private void Fade(ref TweenAlpha tween, GameObject go, float secs)
	{
	}

	private void CaptureScreenTexture(bool colored = false)
	{
	}

	private void CreateRenderTexInNeed()
	{
	}

	private void ReleaseRenderTexInNeed()
	{
	}

	private void DoHide()
	{
	}

	private void OnObserverChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
