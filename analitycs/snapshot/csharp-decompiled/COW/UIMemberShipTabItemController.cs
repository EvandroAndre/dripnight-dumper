using GCommon;
using proto;

namespace COW;

public class UIMemberShipTabItemController : UIBaseController
{
	private const string PRICE_TEMPLATE = "${0}";

	private UIMemberShipTabItemView m_View;

	private UIModelMemberShip m_Model;

	private ClientMemberShipCardData m_MemberShipCardData;

	private EVipCard.VipCardType m_VipCardType;

	private UITipsNormalController m_TipsNormalCtrl;

	private UICountDownController m_CDController;

	private bool m_IsPreferSubscription;

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

	public void SetViewData(EVipCard.VipCardType vipCardType)
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshUnSubscriptionTitle()
	{
	}

	private void RefreshSubscription()
	{
	}

	private void RefreshUnSubscriptionDesc()
	{
	}

	private void RefreshPrice(bool IsPreferSubscription)
	{
	}

	private void RefreshSubscriptionDesc()
	{
	}

	private void CountDownRefresh()
	{
	}

	private void RefreshRedDot()
	{
	}

	private ETipsType GetCurrentTabTipsType()
	{
		return ETipsType.None;
	}

	private void RefreshMembershipTabPrice(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
