using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAgentUIHighLightRect : MonoBehaviour
{
	private sealed class _003CDelayHide_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BotAgentUIHighLightRect _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHide_003Ed__11(int _003C_003E1__state)
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

	public UIWidget effectWidget;

	public UIWidget effectSprite;

	private UIButton button;

	private UIWidget itemWidget;

	private bool m_Started;

	private bool m_ShowHandGuide;

	private float m_PanelBottomPosY;

	private Coroutine m_CoroutineDelay;

	private void Awake()
	{
	}

	public void BindButton(UIButton btn, UIWidget widget, float panelBottomPosY)
	{
	}

	public void Update()
	{
	}

	private IEnumerator DelayHide()
	{
		return null;
	}

	public void UnBindButton()
	{
	}

	private void OnButtonClick()
	{
	}
}
