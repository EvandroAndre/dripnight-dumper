using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2LimitedEventStartController : UIPopupWindowController
{
	private sealed class _003CCreateBgVFX_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanWarV2LimitedEventStartController _003C_003E4__this;

		private GameObject _003Cres_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateBgVFX_003Ed__19(int _003C_003E1__state)
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

	private UIClanWarV2LimitedEventStartView m_View;

	private UIModelGroup m_ModelGroup;

	private ulong m_CurrentTimeStamp;

	private ulong m_EndTimeStamp;

	private uint m_DelayCall;

	private GameObject m_BgVfx;

	private ResourceID m_BgVfxRes;

	private Coroutine m_Cor;

	private UIModelClanWarV2 m_ModelWar;

	private const string GO_TO_CLANWAR_MODE_PARAMS = "V2_Team_4_Match_13_Map_99_Game_1";

	private const string GO_TO_CLANWAR_CSMODE_PARAMS = "V2_Team_4_Match_13_Map_99_Game_15";

	private const int EFFECT_WIDGET_DEPTH = 1;

	private uint m_Season;

	private uint m_Round;

	private bool m_IsReady;

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

	public void SetViewData(uint season, uint round)
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
