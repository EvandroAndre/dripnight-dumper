using GCommon;
using UnityEngine;

namespace COW;

public class UIWishBriefBoxController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIWishBriefBoxView m_View;

	private UIModelWishList m_ModelWishList;

	private ulong m_AccountId;

	private UIClickMask m_ClickMask;

	private uint m_ParentBriefBoxId;

	private bool m_IsPengdingDestroy;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateTransformAndBriefData(Vector3 containerPos = default(Vector3), uint briefBoxIndex = 0u)
	{
	}

	public void GetAccountOutfitData(ulong accountId)
	{
	}

	public void SetViewData(ulong account_id)
	{
	}

	private UIWishBriefBoxItemController GetItemController()
	{
		return null;
	}

	private void OnReturnButtonClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
