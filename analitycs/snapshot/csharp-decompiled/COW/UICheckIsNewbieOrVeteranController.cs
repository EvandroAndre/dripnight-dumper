using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UICheckIsNewbieOrVeteranController : UIBaseController
{
	private sealed class _003CCloseUICoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UICheckIsNewbieOrVeteranController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseUICoroutine_003Ed__15(int _003C_003E1__state)
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

	private UICheckIsNewbieOrVeteranView m_View;

	private EAccount.NewbieChoice m_Choice;

	private const string m_EnterAnimName = "FF_Newandveteran_Admission_ani";

	private const string m_ExitAnimName = "FF_Newandveteran_Appearance_ani";

	private const int m_ChosenBtnSpriteWidth = 610;

	private const int m_UnchosenBtnSpriteWidth = 590;

	private const uint m_ChosenColor = 4290380031u;

	private const uint m_UnChosenColor = uint.MaxValue;

	private const uint m_UnChosenColorStripe = 1869574143u;

	private string UnSelectAni;

	private string SelectAni;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PlayEnterAnim()
	{
	}

	public void PlayExitAnim()
	{
	}

	private IEnumerator CloseUICoroutine(float delay)
	{
		return null;
	}

	private void OnChooseNewbie()
	{
	}

	private void OnChooseVeteran()
	{
	}

	private void OnChooseMaster()
	{
	}

	private void OnChooseChange(EAccount.NewbieChoice choice)
	{
	}

	private void OnConfirmClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
