using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRelayMartRewardPoolItemController : UIBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	protected UIRelayMartRewardPoolItemView m_View;

	protected Transform m_RewardItemContainer;

	protected UIButton m_BtnCartAction;

	protected GameObject m_NormalState;

	protected GameObject m_GrayState;

	protected GameObject m_DiamondPriceGridContainer;

	protected UILabel m_ActualPrice;

	protected UILabel m_OriginalPrice;

	protected UILabel m_DiscountLabel;

	protected GameObject m_CoreItemVFX;

	protected GameObject m_OwnedState;

	protected GameObject m_PreviewFemale;

	protected GameObject m_PreviewMale;

	protected GameObject m_PreviewCommon;

	protected GameObject m_LimitedTitle;

	protected GameObject m_OwnedTitle;

	protected GameObject m_AddedState;

	protected RelayMartShopDesc m_RewardItem;

	protected UIModelRelayMart m_ModelRelayMart;

	protected UIModelMall m_ModelMall;

	protected UIModelInventory m_ModelInventory;

	protected UIRelayMartItemMidController m_UIRelayMartItemMidController;

	protected CSSharedItemData m_ItemData;

	protected bool m_HavePurchaseTimes;

	private ResourceID m_CoreItemVFXResId;

	private GameObject m_CoreItemVFXObj;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void InitializeViewElements()
	{
	}

	protected virtual void InitClickEvent()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData(object data, int data_index)
	{
	}

	protected virtual void RefreshHighLightState()
	{
	}

	public virtual void OnItemBtnClick()
	{
	}

	public void OnRelayMartRewardPoolItemClick(object[] args)
	{
	}

	protected virtual void SetHighLightState(bool isSelected)
	{
	}

	protected virtual void RefreshItem()
	{
	}

	protected virtual void RepositionItemIcon()
	{
	}

	private void RefreshButtonState()
	{
	}

	private void SafeSetActive(GameObject gameObject, bool active)
	{
	}

	private void RefreshRewardDiamondPrice()
	{
	}

	private void RefreshDiscountLabel()
	{
	}

	private void RefreshCoreItemVFX()
	{
	}

	private void RefreshOwnedStatus()
	{
	}

	protected virtual void SetPreviewTitle()
	{
	}

	private void SetLimitedTitleState()
	{
	}

	private void OnItemBtnCartAction()
	{
	}

	private void InstantCoreItemVFXObj()
	{
	}

	private void DestroyCoreItemVFXObj()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
