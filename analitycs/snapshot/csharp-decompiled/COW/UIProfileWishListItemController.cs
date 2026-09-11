using GCommon;

namespace COW;

public class UIProfileWishListItemController : UIEasyListItemController
{
	private UIProfileWishListItemView m_View;

	private UIStandardItemMAXBController m_StandardItemCtrl;

	private WishListItem m_Data;

	private new int m_Index;

	private UIModelGift m_modelGift;

	private UIProfileWishListController m_parent;

	private UIModelWishList m_modelWishList;

	private UIProfileWishListController ParentCtrl => null;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshTopRightLabelGroup()
	{
	}

	public void RefreshGiftIcon()
	{
	}

	public bool CanGiftIconShow()
	{
		return false;
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void _003CRefreshTopRightLabelGroup_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
