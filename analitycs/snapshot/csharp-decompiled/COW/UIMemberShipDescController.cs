using GCommon;
using proto;

namespace COW;

public class UIMemberShipDescController : UIBaseController, IUIModelDataChangeObserver
{
	private const string PRICE_TEMPLATE = "${0}";

	private const string DAILY_TIME = "03:00";

	private EVipCard.VipCardType m_MemberShipType;

	private ClientMemberShipCardData m_ClientMemberShipCardData;

	private UIMemberShipDescView m_View;

	private UIModelMemberShip m_Model;

	private bool m_PreferSubscription;

	private bool m_HasOwned;

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

	private void InitView()
	{
	}

	private void RefreshDefaultSubscription()
	{
	}

	private void SetStaticData()
	{
	}

	private bool HasSubscribed()
	{
		return false;
	}

	private void UpdatePurchaseButton()
	{
	}

	private void ShowHideDiscountTags(bool active)
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void OnSubscriptionDone()
	{
	}

	private void UpdateSubscription()
	{
	}

	private void SyncSubscriptionToggleStatus()
	{
	}

	private void RefreshPurchaseBtnByPackageType()
	{
	}

	private void RefreshPrice()
	{
	}

	private void RefreshMemberShipCompliance()
	{
	}

	private void UpdateSubscriptionBonus()
	{
	}

	private bool IsInGracePeriod()
	{
		return false;
	}

	private bool OnHold()
	{
		return false;
	}

	private void LogSubscriptionStatus()
	{
	}

	private void OnSubscriptionToggleBoxClick()
	{
	}

	private void OnSubscriptionHintButtonClick()
	{
	}

	private void OnBtnPurchaseClick()
	{
	}

	private void OnBtnThirdPartyPurchaseClick()
	{
	}

	private void GotoSubscription()
	{
	}

	private void OnGracePeriodButtonClick()
	{
	}

	private void OnFixOnHoldButtonClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData(EVipCard.VipCardType vipType)
	{
	}

	public void PlayTitleClampInVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
