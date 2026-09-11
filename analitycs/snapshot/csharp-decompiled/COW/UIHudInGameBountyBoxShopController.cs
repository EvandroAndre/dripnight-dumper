using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudInGameBountyBoxShopController : UIHudInGameShopBaseController
{
	private sealed class _003CInitShopItems_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInGameBountyBoxShopController _003C_003E4__this;

		public int cntPerFrame;

		private Dictionary<int, List<BGMFPPDLCBB>>.Enumerator _003C_003E7__wrap1;

		private UIHudInGameShopCategoryController _003CcatCtrl_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitShopItems_003Ed__14(int _003C_003E1__state)
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

	private bool m_ShopItemInited;

	private BGMFPPDLCBB m_ChoosedItemInfo;

	private Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

	private int m_CurBagCapacity;

	private int m_MaxBagCapacity;

	private bool m_HasSendReq;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ClearSelected()
	{
	}

	protected void stopCoroutines()
	{
	}

	private void InitShopItems()
	{
	}

	private IEnumerator InitShopItems(int cntPerFrame)
	{
		return null;
	}

	private void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	private void UpdateBagCapacityText()
	{
	}

	private void OnBagCapacityChanged(bool data)
	{
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	protected void OnShowHud(object[] data)
	{
	}

	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}
}
