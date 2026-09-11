using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDetailTipsIPTagController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDetailTipsIPTagController _003C_003E4__this;

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

	private UIDetailTipsIPTagView m_View;

	private uint m_ItemID;

	private UIRoot m_UIRoot;

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

	public void SetData(string text, uint itemid, Vector3 pos)
	{
	}

	private void OnBtnClick()
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
