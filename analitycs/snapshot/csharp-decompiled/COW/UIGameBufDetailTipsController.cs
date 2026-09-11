using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGameBufDetailTipsController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameBufDetailTipsController _003C_003E4__this;

		public Vector3 itemPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__9(int _003C_003E1__state)
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

	private UIGameBufDetailTipsView m_View;

	private UICountDownController m_CountDownCtrl;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(Vector3 itemPos, bool isShow, ulong timeStamp = 0uL)
	{
	}

	public void SetGroupData(List<string> playerNames)
	{
	}

	private void GotoFriendTokenMall()
	{
	}

	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	private void _003CSetData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
