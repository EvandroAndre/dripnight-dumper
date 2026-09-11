using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_CSRoundResultController : UIHUDUGC_InternalHudController
{
	private sealed class _003CDelayHide_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public UIHUDUGC_CSRoundResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHide_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CDelayShowScore_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitSeconds;

		public GameObject[] objs;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowScore_003Ed__10(int _003C_003E1__state)
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

	private UIHUDUGC_CSRoundResultView m_View;

	private UGCCSRoundResultHudRepItem m_RepItem;

	private UGCEntityRepItem m_EntityRepItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ResetUI()
	{
	}

	private IEnumerator DelayHide(float seconds)
	{
		return null;
	}

	private IEnumerator DelayShowScore(float waitSeconds, GameObject[] objs)
	{
		return null;
	}

	private void OnActiveSelfChanged(bool value)
	{
	}

	private void OnLeftColorChanged(int value)
	{
	}

	private void OnRightColorChanged(int value)
	{
	}

	private void OnLeftScoreChanged(string value)
	{
	}

	private void OnRightScoreChanged(string value)
	{
	}

	private void OnLeftScoreAfterChanged(string value)
	{
	}

	private void OnRightScoreAfterChanged(string value)
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
