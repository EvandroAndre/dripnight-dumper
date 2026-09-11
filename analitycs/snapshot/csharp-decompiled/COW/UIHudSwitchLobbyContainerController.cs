using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIHudSwitchLobbyContainerController : UIBaseController
{
	private sealed class _003CSetButtonCoolDown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UIHudSwitchLobbyContainerController _003C_003E4__this;

		public bool needHide;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonCoolDown_003Ed__12(int _003C_003E1__state)
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

	private UIHudSwitchLobbyContainerView m_View;

	private bool m_IsShowLobbyContainer;

	private Coroutine m_ShowQuickBtnCoroutine;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

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

	private void SetState(bool state)
	{
	}

	private void OnGetRemind(object[] data)
	{
	}

	private void OnQuickBtnClick()
	{
	}

	private void SetQuickBtnView(EGroup.RemindType remindType)
	{
	}

	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime, bool needHide)
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
