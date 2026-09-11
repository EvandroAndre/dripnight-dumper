using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudInGameShopBaseController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__36_0;

		public static Action _003C_003E9__36_1;

		internal void _003CSetControllerCursorEvent_003Eb__36_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__36_1()
		{
		}
	}

	protected UIHudInGameShopView m_View;

	protected int m_TokenCount;

	protected UITimeLabelHelper m_TimeHelper;

	private UIHudCSShopWeaponDetailController m_WeaponDetail;

	protected Dictionary<int, int> m_ShopTableIndexDic;

	private List<ResourceID> m_Rids;

	private int m_DetailTouchFrame;

	public bool PurchaseCountDownFinish => false;

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
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

	protected virtual void RefreshCoinBtnStyle()
	{
	}

	protected virtual void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static void ShowBuyResult(JMHFAMKMIOB buyResult)
	{
	}

	protected void SetToTop()
	{
	}

	protected virtual void OnTokenChanged(int data)
	{
	}

	public void SetTokenType(UIHudInGameShopItemViewExt.CoinIconType coinType)
	{
	}

	private void OnLongPress(object[] param)
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

	protected void InitBRShopTableIndex()
	{
	}

	protected int GetBRShopIndex(int category)
	{
		return 0;
	}

	protected int OnBRShopTableSort(Transform item1, Transform item2)
	{
		return 0;
	}

	public void SetCountdownTime(float secs, float showRedSec = -1f, EUITimeUpdateStyle style = EUITimeUpdateStyle.Simple)
	{
	}

	protected virtual void OverrideCountDownColor()
	{
	}

	private void Update()
	{
	}

	protected void TryCache1pWeaponOnBuy(uint itemId)
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

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
