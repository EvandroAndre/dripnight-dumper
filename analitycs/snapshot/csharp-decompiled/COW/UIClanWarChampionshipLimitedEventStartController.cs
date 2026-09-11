using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarChampionshipLimitedEventStartController : UIPopupWindowController
{
	private sealed class _003CCreateBgVFX_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanWarChampionshipLimitedEventStartController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateBgVFX_003Ed__13(int _003C_003E1__state)
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

	private UIClanWarChampionshipLimitedEventStartView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelCDNAd m_ModelCdn;

	private ulong m_CurrentTimeStamp;

	private ulong m_EndTimeStamp;

	private uint m_DelayCall;

	private Coroutine m_Cor;

	private const string GO_TO_TOURNAMENT_MODE_PARAMS = "V2_Team_4_Match_15_Map_99_Game_1";

	private bool m_IsReady;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(int roundId)
	{
	}

	private IEnumerator CreateBgVFX()
	{
		return null;
	}

	private void OnJumpBtnClick()
	{
	}

	private void OnFunctionalBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void CountDown()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
