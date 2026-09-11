using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgressHelpTipController : UIBaseController
{
	private sealed class _003CResetTip_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_PersonalProgressHelpTipController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetTip_003Ed__15(int _003C_003E1__state)
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

	private UIBigEvent_PersonalProgressHelpTipView m_View;

	private Vector3 m_BasePos;

	private Vector3 m_CurrentPos;

	private Vector3 m_Offset;

	private TweenPosition m_ParentTP;

	private TweenAlpha m_ParentTA;

	private Coroutine m_ResetTip;

	private float m_HoldShowTime;

	private float m_MoveUpOffsetY;

	private float m_MoveUpTime;

	private float m_AlphaChangeTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void MoveUp()
	{
	}

	public void ShowHelpTip(string helpTip)
	{
	}

	public IEnumerator ResetTip()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
