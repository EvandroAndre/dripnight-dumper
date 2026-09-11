using GCommon;

namespace COW;

internal class UIHudBuffEcaKillNotificationController : UIHUDFeedbackItemBaseController
{
	private UIHudBuffEcaKillNotificationView m_View;

	private UIHudBuffEcaKillNotificationItem m_Item;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void ShowIcon(NotificationData data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
