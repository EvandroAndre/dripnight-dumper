using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_AddScoreVFXController : UIHUDUGC_InternalHudController
{
	private sealed class _003CHideScores_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDUGC_AddScoreVFXController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideScores_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CShowVfxArc_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDUGC_AddScoreVFXController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowVfxArc_003Ed__10(int _003C_003E1__state)
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

	private UIHUDUGC_AddScoreVFXView m_View;

	private UGCAddScoreVFXHudRepItem m_ViewData;

	private GameObject m_VFX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnScoreNumChanged(int cur)
	{
	}

	private IEnumerator ShowVfxArc()
	{
		return null;
	}

	private IEnumerator HideScores()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
