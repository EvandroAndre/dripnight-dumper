using GCommon;

namespace COW;

public class UIAntiAddictionBRMinorBindWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIAntiAddictionBRMinorBindWndView m_View;

	private FriendAccountInfo m_SelectedFriendInfo;

	private UIModelAntiAddiction m_AntiAddictionModel;

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

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void SearchFriend(ulong accountId)
	{
	}

	private void CheckAndShowSearchResult()
	{
	}

	private void ShowSearchResult(FriendAccountInfo friend)
	{
	}

	private void ShowNormalResult()
	{
	}

	private void ShowNotFoundResult()
	{
	}

	private void ShowSearchingResult()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
