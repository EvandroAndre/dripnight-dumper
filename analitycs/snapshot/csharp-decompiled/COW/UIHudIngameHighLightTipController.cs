using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudIngameHighLightTipController : UIBaseController
{
	private sealed class _003CDoShowHint_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudIngameHighLightTipController _003C_003E4__this;

		public Vector3 targetPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoShowHint_003Ed__13(int _003C_003E1__state)
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

	private UIHudIngameHighLightTipView m_View;

	private BoxCollider m_BindBoxCollider;

	private Vector3 m_hintPos;

	private Coroutine m_coroutine;

	private bool m_noHint;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Bind(BoxCollider bindBoxCollider, bool isCircle, string hintTxt, bool noHint = false)
	{
	}

	public void Bind(BoxCollider bindBoxCollider, string hintTxt)
	{
	}

	public new void Show()
	{
	}

	public void ShowTip()
	{
	}

	public override void Hide()
	{
	}

	public void HideTip()
	{
	}

	private IEnumerator DoShowHint(Vector3 targetPos)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
