using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentIAPController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver, ITipsDelegate
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public List<PayItemData> firstPayBonusDiamondProducts;

		public int index;

		internal bool _003CRefreshPayItemControllers_003Eb__0(uint productId)
		{
			return false;
		}

		internal bool _003CRefreshPayItemControllers_003Eb__1(uint productId)
		{
			return false;
		}
	}

	private UIPaymentIAPView m_View;

	private UIPaymentIAPActivityView m_ActivityView;

	private UICenterOnChild m_CenterOnChild;

	private UIModelPayment m_ModelPayment;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private string m_ProductIdentifier;

	private Transform[] m_PayItemSlots;

	private UICountDownController m_CountDownCtrl;

	private List<UIPayItemController> _PayItemControllerList;

	private List<AdvertDesc> m_CdnAds;

	private List<UIPaymentIAPCDNItemController> m_CDNAdItems;

	private List<UILobbyDotController> m_CDNAdDots;

	private int m_CDNAdIndex;

	private uint m_AutoScrollDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private UIPaymentIAPActivityView ActivityView()
	{
		return null;
	}

	private void ActivityViewSetActive(bool active)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void RefreshContent()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void UpdatePaymentActivityRedDot()
	{
	}

	private void OnBtnPaymentActivityClick()
	{
	}

	public override void Show()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ClearPayItemControllers()
	{
	}

	private void RefreshCdnAds()
	{
	}

	private void RefreshCdnAdsUI()
	{
	}

	private void OnCDNAdItemsAutoScroll()
	{
	}

	private void GetCdnAdsCenterItem(GameObject centerGo)
	{
	}

	private void RefreshPayItemControllers()
	{
	}

	private void OnPayItemClick(object[] parameters)
	{
	}

	private void RefreshFirstPayBonusContainer()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshScrollViewSize(AdType type)
	{
	}

	private void _003CRefreshFirstPayBonusContainer_003Eb__32_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
