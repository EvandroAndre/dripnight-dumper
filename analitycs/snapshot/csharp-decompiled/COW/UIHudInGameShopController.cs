using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudInGameShopController : UIHudInGameShopBaseController
{
	private sealed class _003CInitShopItems_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInGameShopController _003C_003E4__this;

		public int cntPerFrame;

		private Dictionary<int, List<BGMFPPDLCBB>>.Enumerator _003C_003E7__wrap1;

		private UIHudInGameShopCategoryController _003CcatCtrl_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitShopItems_003Ed__18(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected bool m_ShopItemInited;

	protected BGMFPPDLCBB m_ChoosedItemInfo;

	private int m_CurBagCapacity;

	private int m_MaxBagCapacity;

	protected Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

	private uint m_TipDelayCall;

	private UIHudInGameShopItemViewExt.CoinIconType coinType;

	protected virtual Dictionary<int, List<BGMFPPDLCBB>> ShopItems => null;

	protected virtual HEOJAGLBHLJ ShopType => HEOJAGLBHLJ.EShopType_Common;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void InitSpecialEvent()
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnTokenChanged(int data)
	{
	}

	protected void OnShowHud(object[] data)
	{
	}

	protected void stopCoroutines()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitShopItems()
	{
	}

	private IEnumerator InitShopItems(int cntPerFrame)
	{
		return null;
	}

	protected virtual int GetShowCoinValue()
	{
		return 0;
	}

	protected void RefreshShopItems(bool isAddItem)
	{
	}

	protected virtual void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected virtual void OnBuyReqBuild(EDPFGIMHEPM req)
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	protected virtual void OnBgClick()
	{
	}

	private void OnCoinBtnClick()
	{
	}

	private void OnCapacityBtnClick()
	{
	}

	private void ClearSelected()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerKnockDown(object[] data)
	{
	}

	private void OnBuyResultSync(int ret)
	{
	}

	private void OnBagCapacityChanged(bool data)
	{
	}

	private void UpdateBagCapacityText()
	{
	}

	private void OnShopDiscount()
	{
	}

	private void _003COnCoinBtnClick_003Eb__30_0()
	{
	}

	private void _003COnCapacityBtnClick_003Eb__31_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTokenChanged(int P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
