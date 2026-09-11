using GCommon;
using proto;

namespace COW;

internal class UIVirtualBrandProgressItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIVirtualBrandProgressItemView m_View;

	private UIModelVirtualBrand m_Model;

	private uint m_CurBrandID;

	private ConditionNode m_CurCondition;

	private UIStandardItemMiniController m_ItemCtrl;

	private bool m_IsClaimed;

	private bool m_Claimable;

	private VirtualBrandCollectionValueRewardDesc m_RewardDesc;

	public VirtualBrandCollectionValueRewardDesc RewardDesc => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandID, ConditionNode condition, bool isFirstNode)
	{
	}

	public void RefreshState()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshProgressBar()
	{
	}

	private void RefreshBtnState()
	{
	}

	private void RefreshObtainBtn()
	{
	}

	private void RefreshClaimedState()
	{
	}

	private void RefreshLabelStyle()
	{
	}

	private void OnBtnObtainClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
