using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_ShopController : UIHUDUGC_InternalHudController
{
	public enum AskPurchaseType
	{
		Fobidden = 1,
		Team,
		Faction
	}

	private sealed class _003CDelayedRepositionTable_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDUGC_ShopController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayedRepositionTable_003Ed__25(int _003C_003E1__state)
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

	private UIHUDUGC_ShopView m_View;

	private UGCUGCShopHudRepItem m_ViewData;

	private UGCShopRepItem m_BindUGCShopRepItem;

	private UGCEntityRepItem m_BindEntityComponent;

	private UGCWalletRepItem m_BindUGCWalletRepItem;

	private UGCShopItemRepItem m_BindSelectedShopItemRepItem;

	private string m_SelectedItemEntityID;

	private UIHudUGCAskPurchaseListController m_AskListCtrl;

	private List<UIHUDUGC_ShopShelfController> m_CachedShopShelfCtrls;

	private List<UIHUDUGC_MoneyController> m_CachedMoneyCtrls;

	private Dictionary<int, string> m_Wallet;

	private Coroutine m_RepositionCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnBindShopIDChanged(string cur)
	{
	}

	private void RefreshUI(string shopEntityID)
	{
	}

	private void RefreshName(string name)
	{
	}

	private void RefreshEntityName(string name)
	{
	}

	private void RefreshShelf(List<object> shelves)
	{
	}

	private void ScheduleTableReposition()
	{
	}

	private IEnumerator DelayedRepositionTable()
	{
		return null;
	}

	private void RefreshAskBuyBtn(object[] data = null)
	{
	}

	private void OnBindMoneyEntityChangeEvent(string cur)
	{
	}

	private void OnBindMoneyListChangeEvent(List<object> cur)
	{
	}

	private void BindMoneyList()
	{
	}

	private void OnBindWalletChangeEvent(string cur)
	{
	}

	private void OnRequestTypeChange(int requestType)
	{
	}

	private void OnAskListChangeEvent(List<object> askedList)
	{
	}

	private void OnWalletContentChanged(List<object> cur)
	{
	}

	public void RefreshBuyBtn(bool canPurchase)
	{
	}

	private void OnSelectItemCanPurchasChangeEvent(bool canBuy)
	{
	}

	private void OnSelectItemCurToLimitChangeEvent(int limit)
	{
	}

	private void OnBGBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void CloseHud()
	{
	}

	private void OnCoinBtnClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnCapacityBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnAskBtnClick()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
