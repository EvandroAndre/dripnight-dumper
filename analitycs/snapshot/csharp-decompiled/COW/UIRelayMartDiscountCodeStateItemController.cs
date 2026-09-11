using GCommon;
using proto;

namespace COW;

public class UIRelayMartDiscountCodeStateItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIRelayMartDiscountCodeStateItemView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private UIModelFriends m_ModelFriends;

	private bool m_IsDefaultOpen;

	private RelayMartDiscountCodeInfo m_ItemData;

	private UIBaseProfileInfoController m_BaseProfile;

	private string m_OccupanterRegion;

	private bool m_IsProfileReady;

	private ulong m_AppliedOccupantId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnRefreshAccountInfo(object[] data)
	{
	}

	private void OnHeadClick()
	{
	}

	private void ApplyOccupantProfile(BaseProfileInfo baseProfile)
	{
	}

	private void RefreshProfileInfo()
	{
	}

	private void OnIsPublicCheckBoxClick()
	{
	}

	private void RefreshPublictate()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnCopyBtnClick()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	public void ShowCheckNoticeBubble()
	{
	}

	public void HideCheckNoticeBubble()
	{
	}

	public bool IsUnpublishedCode(ulong selfId)
	{
		return false;
	}

	public string GetDiscountCode()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
