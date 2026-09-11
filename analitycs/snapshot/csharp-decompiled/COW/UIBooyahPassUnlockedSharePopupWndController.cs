using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassUnlockedSharePopupWndController : UIPopupWindowController
{
	public enum Style
	{
		None,
		Premium,
		PremiumPlus
	}

	private sealed class _003CShowAnimAfterBack_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassUnlockedSharePopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowAnimAfterBack_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CShowUnlockNewAnim_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassUnlockedSharePopupWndController _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowUnlockNewAnim_003Ed__13(int _003C_003E1__state)
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

	private const string POPUP_WND_TITLE = "UnlockedSharePopup";

	private UIBooyahPassUnlockedSharePopupWndView m_View;

	private Coroutine m_ShowUnlockNewAnim;

	private bool m_HasShowAnim;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetupDefaultState()
	{
	}

	public void ShowNewUnlock()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private IEnumerator ShowAnimAfterBack()
	{
		return null;
	}

	private IEnumerator ShowUnlockNewAnim()
	{
		return null;
	}

	private void SetUnlockOldNodeState(bool show)
	{
	}

	private void RefreshCdnBackground()
	{
	}

	private void RefreshRecordGroup(Style style)
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnPopToMainBtn()
	{
	}

	private void OnClickContinueBtn()
	{
	}

	private void AddEventDelegate()
	{
	}

	public void SetStyle(Style style)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
