using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class UIRematchGroupMemberInfoController : UIBaseController
{
	private sealed class _003CRematchCountDownCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRematchGroupMemberInfoController _003C_003E4__this;

		private UIModelGroup _003CmodelGroup_003E5__2;

		private float _003CtotalTime_003E5__3;

		private float _003CelapsedTime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRematchCountDownCoroutine_003Ed__18(int _003C_003E1__state)
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

	private static readonly float[] m_FakeMemberScale;

	private static readonly float[] m_PentaFakeMemberScale;

	private UIRematchGroupMemberInfoView m_View;

	private GroupReservationShowInfo m_Info;

	private RematchPlayer m_RematchPlayer;

	private GameObject m_FakeMemberObj;

	private Coroutine m_RematchCountDownCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	public void RefreshView(GroupReservationShowInfo info, int idx, Vector3 fakeMemberTrans)
	{
	}

	public void RefreshViewWithRematchPlayer(RematchPlayer rematchPlayer, int idx, Vector3 fakeMemberTrans)
	{
	}

	private void RefreshRematchStatus()
	{
	}

	private void StartRematchCountDown()
	{
	}

	private void StopRematchCountDown()
	{
	}

	private IEnumerator RematchCountDownCoroutine()
	{
		return null;
	}

	private void OnAddFriendBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
