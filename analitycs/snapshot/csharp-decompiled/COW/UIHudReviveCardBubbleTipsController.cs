using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudReviveCardBubbleTipsController : UIBaseController
{
	private sealed class _003CPlayAnim_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReviveCardBubbleTipsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnim_003Ed__12(int _003C_003E1__state)
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

	private const string TipsInAnimName = "UIFX_UIHudReviveCardBubbleTips_In";

	private const string TipsOutAnimName = "UIFX_UIHudReviveCardBubbleTips_Out";

	private const string FreeVfxInAnimName = "UIFX_UIHudReviveCardBubbleTips_free_kuang_In";

	private const string FreeVfxOutAnimName = "UIFX_UIHudReviveCardBubbleTips_free_kuang_Out";

	private Coroutine m_AnimCor;

	private UIHudReviveCardBubbleTipsView m_View;

	private VisualInstanceHolder m_FreeVfx;

	private Animation m_FreeVfxAnim;

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

	public void PlayNotice(IEHIFJNIKNK msg)
	{
	}

	private IEnumerator PlayAnim()
	{
		return null;
	}

	private void PlayOutAnimation()
	{
	}

	private void OnReviveCardDiscountChanged(object[] param)
	{
	}

	private void OnHudEmojiShow()
	{
	}

	private void HideNotice()
	{
	}

	private void StopNoticeCoroutine()
	{
	}

	private float GetAnimationLength(Animation animation, string clipName)
	{
		return 0f;
	}

	private int GetShowTokenValue(int tokenCount)
	{
		return 0;
	}

	private void _003COnUIInit_003Eb__9_0(GameObject instance)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
