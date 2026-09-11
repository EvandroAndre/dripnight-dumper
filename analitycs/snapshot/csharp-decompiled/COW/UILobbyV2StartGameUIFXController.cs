using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UILobbyV2StartGameUIFXController : MonoBehaviour
{
	public enum EAnimationType
	{
		UIFX_UILobbyV2StartGame_1,
		UIFX_UILobbyV2StartGame_2
	}

	private sealed class _003CPlayUIFXCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2StartGameUIFXController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayUIFXCoroutine_003Ed__6(int _003C_003E1__state)
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

	public Animation StartGameUIFX;

	public GameObject FlyUIFX;

	public int DelayFrame;

	private EAnimationType m_AnimationType;

	public void PlayUIFX(EAnimationType type)
	{
	}

	private IEnumerator PlayUIFXCoroutine()
	{
		return null;
	}

	private void PlayUIFX()
	{
	}
}
