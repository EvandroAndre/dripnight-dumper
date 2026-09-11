using GCommon;

namespace COW;

public class UILobbyNotificationGuildRecommendController : UILobbyNotificationPopUpContentBaseController
{
	private UILobbyNotificationGuildRecommendView m_View;

	private UIModelFriends m_ModelFriends;

	private UIModelClan m_ModelClan;

	private ClanInfo m_ClanInfo;

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override UIButton InitInteractionButton()
	{
		return null;
	}

	protected override void OnReset()
	{
	}

	protected override void OnSetViewData(object data)
	{
	}

	private void OnSetViewData(ClanInfo data)
	{
	}

	protected override void OnInteractionBtnClick()
	{
	}

	private void _003COnSetViewData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}
}
