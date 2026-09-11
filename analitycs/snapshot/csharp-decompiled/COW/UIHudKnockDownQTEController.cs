using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudKnockDownQTEController : UIBaseController
{
	private sealed class _003CHideClickVFX_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudKnockDownQTEController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideClickVFX_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CPlayEffect_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudKnockDownQTEController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayEffect_003Ed__23(int _003C_003E1__state)
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

	private UIHudKnockDownQTEView m_View;

	private bool IsPendingRequest;

	private bool IsPlayBreaking;

	private int ClickCnt;

	private List<uint> BuffEcaIdList;

	private float m_TotalTime;

	private float m_CurrentTime;

	private int m_MaxQteNum;

	private float m_QtePerTime;

	private VisualInstanceHolder m_AnimVFXForInHolder;

	private VisualInstanceHolder m_AnimVFXForClickHolder;

	private VisualInstanceHolder m_AnimVFXForBrokenHolder;

	private Coroutine m_Coroutine;

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

	private void AsyncInitAnimVFX()
	{
	}

	private void OnBtnClick()
	{
	}

	private IEnumerator HideClickVFX()
	{
		return null;
	}

	private void ReqestUnFreeze()
	{
	}

	public void EnterFreezeView(List<uint> ecaList, Vector3 pos, float totalTime, float qteMaxNum, float qtePerTime)
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnUnFreeze()
	{
	}

	private IEnumerator PlayEffect()
	{
		return null;
	}

	private void OnEventHide(object[] data)
	{
	}

	private void OnMatchEndV()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
