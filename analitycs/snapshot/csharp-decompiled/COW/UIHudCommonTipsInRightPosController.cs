using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCommonTipsInRightPosController : UIPopupWindowController
{
	private sealed class _003CSetRealPosition_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCommonTipsInRightPosController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetRealPosition_003Ed__13(int _003C_003E1__state)
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

	private UIHudCommonTipsInRightPosView m_View;

	private Vector3 m_RPos;

	private Vector3 m_LPos;

	private Coroutine m_Coroutine;

	private uint m_DelayHideId;

	private float m_DelayHideTime;

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

	public override void Hide()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetData(Vector3 rPos, Vector3 lPos, string tipsLabel)
	{
	}

	private IEnumerator SetRealPosition()
	{
		return null;
	}

	private void _003CSetData_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
