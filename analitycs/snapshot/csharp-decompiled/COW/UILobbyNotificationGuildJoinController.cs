using GCommon;
using tcp;

namespace COW;

public class UILobbyNotificationGuildJoinController : UILobbyNotificationPopUpContentBaseController, IUIModelDataChangeObserver
{
	private UILobbyNotificationGuildJoinView m_View;

	private RequestJoinClanNtf m_RequestJoinClanNtf;

	private UIModelFriends m_ModelFriends;

	private bool m_NeedAddDataToAssist;

	private UIBaseProfileInfoController m_ProfileCtrl;

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	private UIBaseProfileInfoController ProfileCtrl => null;

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

	private void OnSetViewData(RequestJoinClanNtf data)
	{
	}

	protected override void OnInteractionBtnClick()
	{
	}

	public override void OnOutAnimFinished()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOutAnimFinished()
	{
	}
}
