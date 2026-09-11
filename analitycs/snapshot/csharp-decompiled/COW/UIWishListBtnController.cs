using GCommon;
using UnityEngine;

namespace COW;

public class UIWishListBtnController : UIBaseController, IUIModelDataChangeObserver
{
	private UIWishListBtnView m_View;

	private UIModelWishList m_ModelWishList;

	private uint m_ItemId;

	private string m_Source;

	private ItemStateInWishList m_WishListNodeState;

	private bool IsWishNumShow;

	private bool NeedSimplify;

	private bool CurrentShowState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemIdAndSource(uint itemId, string source, bool needSimplify = true, bool useBigBtn = false)
	{
	}

	private void RefreshWishNumUI()
	{
	}

	private GameObject GetCurrentWishHot()
	{
		return null;
	}

	private void OnWishListNodeClick()
	{
	}

	public void SetWishListNodeActive(bool v)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
