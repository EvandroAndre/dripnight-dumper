using GCommon;

namespace COW;

public class UILuckyWheelPreviewRewardPoolItemController : UIEasyListItemController
{
	private UILuckyWheelPreviewRewardPoolItemView m_View;

	private BaseItemInfo m_Data;

	private UIModelLuckyWheel m_Model;

	private UIModelGacha m_ModelGacha;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BaseItemInfo data)
	{
	}

	public void SetHotFlag(bool flag)
	{
	}

	public void SetOwnedFlag(bool flag)
	{
	}

	public void SetBuyedFlag(bool flag)
	{
	}

	private void ShowFullScreenPreview()
	{
	}

	private void SetStandItemMiniData(BaseItemInfo data, bool hasTween = true)
	{
	}

	public void RefreshView()
	{
	}

	public UIDragScrollView GetItemDragView()
	{
		return null;
	}

	public void UpdateQuantityLabel(string newCount)
	{
	}

	public void SetFlowLightEnable(bool b)
	{
	}

	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	public void SetCustomBtnClickEvent(EventDelegate.Callback action)
	{
	}

	public void EnableItemBtn()
	{
	}

	public void DisableItemBtn()
	{
	}

	private void ShowItemPreview()
	{
	}

	public void SetQuantityIgnoreOne(bool ignore)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetQualityBg()
	{
	}

	public void SetDisountLabel(UIModelLuckyWheel.DiscountType discountType, uint discount)
	{
	}

	public void PlayAniamtion()
	{
	}

	public void SkipAnimation()
	{
	}

	private void SetIPTag()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
