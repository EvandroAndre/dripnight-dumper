using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLuckyDrawBoxItemController : UIBaseController
{
	private sealed class _003CPressCheckCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLuckyDrawBoxItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPressCheckCoroutine_003Ed__12(int _003C_003E1__state)
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

	private UIHudLuckyDrawBoxItemView m_View;

	private DOCPOKGMOGB m_Item;

	private LevelLuckyDrawBox m_Box;

	private bool m_PressState;

	private float m_PressTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(DOCPOKGMOGB levelLuckyDrawGridItem, LevelLuckyDrawBox box)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnPress(GameObject go, bool state)
	{
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	private void ChangePressState(bool state)
	{
	}

	private IEnumerator PressCheckCoroutine()
	{
		return null;
	}

	private void RefreshNewTagUI(uint itemID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
