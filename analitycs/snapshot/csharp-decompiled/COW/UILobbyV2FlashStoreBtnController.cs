using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2FlashStoreBtnController : UIBaseController
{
	public enum EntranceLocation
	{
		None = 0,
		BigEvent = 2,
		RevBtn = 3
	}

	private sealed class _003CHideIntroBubbleCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public UILobbyV2FlashStoreBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideIntroBubbleCoroutine_003Ed__31(int _003C_003E1__state)
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

	private const string FLASH_STORE_ACTIVITY_ENTRANCE_DISPLAYED_KEY = "FlashStore{0}_EntranceDisplayed_{1}";

	private const string AWARD_TIPS_BUBBLE_DISPLAYED_KEY = "FlashStore{0}_AwardTipsDisplayed_{1}";

	private const string NEW_ACTIVITY_BUBBLE_DISPLAYED_KEY = "FlashStore{0}_NewActivityBubbleDisplayed_{1}";

	private const string HAS_FINISHED_ACTIVITY_BUBBLE_KEY = "T_35_LC_FLASHSTORE_BUBBLE2";

	private const string NEW_FLASH_STORE_ACTIVITY_BUBBLE_KEY = "T_35_LC_FLASHSTORE_BUBBLE1";

	private Coroutine m_HideIntroBubbleCoroutine;

	private UIFlashStoreLobbyEntranceView m_View;

	private UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	private uint m_FlashStoreActivityID;

	private bool m_IsAwardBubbleDisplaying;

	private EntranceLocation m_EntranceLocation;

	private bool IsReady => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetCDNIcon()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint flashStoreActivityID, int entranceLocation)
	{
	}

	private void RefreshCountdownLabel()
	{
	}

	private void OnFlashStoreBtnClick()
	{
	}

	private void SetCurrentFlashStoreActivityBubbleDisplayedIfShown()
	{
	}

	private void SetCurrentFlashStoreActivityDisplayed()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	public void ResetIntorGroup()
	{
	}

	public bool RefreshIntroBubble()
	{
		return false;
	}

	private bool IsAwardBubbleDisplayedToday()
	{
		return false;
	}

	private bool IsCurrentFlashStoreActivityBubbleDisplayed()
	{
		return false;
	}

	private void SetAwardTipsDisplayedTodayIfShown()
	{
	}

	private void StartHideIntroBubbleCoroutine(float duration)
	{
	}

	private IEnumerator HideIntroBubbleCoroutine(float duration)
	{
		return null;
	}

	private void RefreshTips()
	{
	}

	private bool IsCurrentFlashStoreActivityDisplayed()
	{
		return false;
	}

	private void _003CSetCDNIcon_003Eb__17_0()
	{
	}

	private void _003CRefreshCountdownLabel_003Eb__20_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
