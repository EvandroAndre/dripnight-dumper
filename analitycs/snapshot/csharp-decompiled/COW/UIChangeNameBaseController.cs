using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChangeNameBaseController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UINavigationUtil.UINavigationFrom from;

		internal void _003CShowRenameDiamondShortHint_003Eb__0()
		{
		}
	}

	private sealed class _003COnLostFocusCoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChangeNameBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnLostFocusCoroutine_003Ed__20(int _003C_003E1__state)
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

	protected UIModelCheckNameValid m_ModelCheckNameValid;

	protected UIChangeNameView m_View;

	protected bool m_BtnEnable;

	private Coroutine m_LostFocusActionCorotine;

	private float m_LostFocusActionCorotineTime;

	private Rect m_ClearBtnRectRegion;

	private bool m_InitClearBtn;

	protected bool m_IsSpaceAllowed;

	protected string m_CurName;

	protected bool m_IgnoreNullName;

	protected bool m_CheckDirtyWord;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected virtual void RefreshBtnView(bool isShowEnable)
	{
	}

	protected virtual bool CheckNicknameValid(string newName)
	{
		return false;
	}

	protected void ShowRenameDiamondShortHint(UINavigationUtil.UINavigationFrom from)
	{
	}

	protected void InitClearBtnClickRegion()
	{
	}

	private void OnUICameraCustomInput()
	{
	}

	private void OnGetFocus()
	{
	}

	private void OnLostFocus()
	{
	}

	private IEnumerator OnLostFocusCoroutine()
	{
		return null;
	}

	private void OnInputChange()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
