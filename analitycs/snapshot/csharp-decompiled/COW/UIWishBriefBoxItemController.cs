using GCommon;
using UnityEngine;

namespace COW;

public class UIWishBriefBoxItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIWishBriefBoxItemView m_View;

	private UIModelWishList m_ModelWishList;

	private UIModelInventory m_ModelInventory;

	private UIStandardItemMAXBController m_StandardItemCtrl;

	private BaseItemInfo m_CurrentItem;

	private uint m_ItemId;

	private ItemStateInWishList m_WishState;

	private GameObject WishListContainer;

	private bool IsWishNumOpenShow;

	private float WishIconDefaultPosX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(int index, uint ItemId)
	{
	}

	private void HideAll()
	{
	}

	private void RefreshWishView()
	{
	}

	private void RefreshWishNum()
	{
	}

	private void OnBtnWishButtonClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
