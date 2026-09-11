using GCommon;

namespace COW;

public class UISeasonReplaySocialSocialTagPopUpItemController : UIBaseController
{
	private UISeasonReplaySocialSocialTagPopUpItemView m_View;

	private SeasonReplayFriendData m_FriendData;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectButtonClick()
	{
	}

	public void ResetSelectedState()
	{
	}

	public void SetViewData(SeasonReplayFriendData data, bool selected, bool left, bool isBR)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
