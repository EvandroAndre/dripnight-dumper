using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMemberShipCheckInDetailTipsController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMemberShipCheckInDetailTipsController _003C_003E4__this;

		public Vector3 itemPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__8(int _003C_003E1__state)
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

	private UIMemberShipCheckInDetailTipsView m_View;

	private UIRoot m_UIRoot;

	private UIModelMemberShip m_Model;

	private const float m_HeightSpace = 40f;

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

	public void SetViewData(Vector3 itemPos, uint mini, uint weekly, uint monthly, List<EVipCard.VipCardType> types)
	{
	}

	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
