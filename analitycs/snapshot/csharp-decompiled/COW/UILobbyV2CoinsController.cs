using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyV2CoinsController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__16_0;

		public static Action _003C_003E9__16_1;

		public static Action _003C_003E9__17_0;

		internal void _003COnBtnMonthCardClick_003Eb__16_0()
		{
		}

		internal void _003COnBtnMonthCardClick_003Eb__16_1()
		{
		}

		internal void _003COnClickPayDiamondButton_003Eb__17_0()
		{
		}
	}

	private sealed class _003CScrollCoinCount_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2CoinsController _003C_003E4__this;

		private int _003CFinalCount_003E5__2;

		private int _003CdeltaCount_003E5__3;

		private int _003CNowCount_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollCoinCount_003Ed__21(int _003C_003E1__state)
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

	private UITipsNormalController m_DiamondTipsCtrl;

	private UITipsNormalController m_RebateCardTipsCtrl;

	private UITipsNormalController m_PrimeTipsCtrl;

	private UILobbyV2CoinsView m_View;

	private UIModelPayment m_Payment;

	private UIModelMemberShip m_ModelMembership;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelPrime m_ModelPrime;

	private int m_CurCount;

	private bool m_OnlyShowCoins;

	private UICommonGuideController m_CommonGuideCtrl;

	private uint m_PrimeActivityTipsDelayCall;

	private GameObject m_PrimeLevelUpVFXObj;

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

	private void OnBtnMonthCardClick()
	{
	}

	public void OnClickPayDiamondButton()
	{
	}

	public void OnClickCoinButton()
	{
	}

	public void UpdateCoinsData()
	{
	}

	private void RefreshCoinsAndDiamonds(bool bOpenUI)
	{
	}

	private IEnumerator ScrollCoinCount()
	{
		return null;
	}

	private void RefreshRebateCards()
	{
	}

	private void UpdateRebateCardTips()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnCoinsUpdate(object[] data)
	{
	}

	private void TryInitTips()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void UpdatePaymentRedDot()
	{
	}

	private void UpdateMemberShipTips()
	{
	}

	private void OnRefreshGroupModeUI(object[] data)
	{
	}

	public void SetRebateCardVFXState(bool state)
	{
	}

	private void InitPrimeEntrance()
	{
	}

	private void RefreshPrimeEntrance()
	{
	}

	private void RefreshPrimeLevelUpVFX(bool Show)
	{
	}

	private void OnPrimeBtnClick()
	{
	}

	public void UpdatePrimeLevelTips(bool show)
	{
	}

	public bool CheckDoublePointsActivityTipsOpen()
	{
		return false;
	}

	public bool IsPrimeActivityTipsOpen()
	{
		return false;
	}

	private void HidePrimeActivityTips()
	{
	}

	public void UpdateCommonGuide(bool show)
	{
	}

	public void UpdatePrimeRedTips()
	{
	}

	private void OnShowPrimeGuide(object[] data)
	{
	}

	private bool PrimeGuideShowing()
	{
		return false;
	}

	private void OnShowTakePhoto(object[] objects)
	{
	}

	private void OnCloseTakePhoto(object[] objects)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
