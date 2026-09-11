using System;
using GCommon;

namespace COW;

internal class UIHudTakeTurnsShopGrandBaseController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_0;

		public static Action _003C_003E9__22_1;

		internal void _003CSetControllerCursorEvent_003Eb__22_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__22_1()
		{
		}
	}

	protected UIHudTakeTurnsShopView m_View;

	protected int m_TokenCount;

	private UITimeLabelHelper m_TimeHelper;

	public bool PurchaseCountDownFinish => false;

	protected override void OnUIInit()
	{
	}

	protected virtual void RecordDefaultSkinInfo()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected virtual void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnTokenChanged(int data)
	{
	}

	public void SetTokenType(UIHudTakeTurnsShopItemViewExt.CoinIconType coinType)
	{
	}

	protected virtual void OnItemSelected(object[] data)
	{
	}

	protected virtual void OnPurchaseBtnClick()
	{
	}

	protected virtual void OnBuySameBtnClick()
	{
	}

	protected virtual void OnCloseBtnClick()
	{
	}

	public void SetCountdownTime(float secs)
	{
	}

	private void Update()
	{
	}

	protected virtual void OnPurchaseTimeOut()
	{
	}

	public bool IsAutoHideFinished()
	{
		return false;
	}

	public void ManullyStopTimerTick()
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
