using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaELS_TT53PreviewPopWndController : UIPopupWindowController
{
	private sealed class _003CCoCenterOnTarget_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53PreviewPopWndController _003C_003E4__this;

		public Transform trans;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCenterOnTarget_003Ed__14(int _003C_003E1__state)
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

	private UIGachaELS_TT53PreviewPopWndView m_View;

	private UIModelGacha m_Model;

	private List<GachaShowItem> m_ItemList;

	private List<UIGachaShowRewardItemController> m_ItemCtrlList;

	private uint m_GachaID;

	private const int MAXTOKENCOUNT = 5;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetGachaID(uint gachaID)
	{
	}

	private void SetCDN()
	{
	}

	private void ShowView()
	{
	}

	public void CenterOnTarget(uint itemId)
	{
	}

	private IEnumerator CoCenterOnTarget(Transform trans)
	{
		return null;
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
