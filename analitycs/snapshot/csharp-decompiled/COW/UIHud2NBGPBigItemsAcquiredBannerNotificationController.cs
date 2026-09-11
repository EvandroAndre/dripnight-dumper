using GCommon;

namespace COW;

public class UIHud2NBGPBigItemsAcquiredBannerNotificationController : UIBaseController, IScheduledNotification
{
	private const string m_LoadNotificationVfxEventName = "LoadNotificationUIFX";

	private UIHud2NBGPBigItemsAcquiredBannerNotificationView m_View;

	private NBGP2BigItemsConfig m_ViewData;

	private VisualInstanceHolder m_VfxHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAnimEventOccurred(object[] data)
	{
	}

	private void TryReleaseVfxHolder(bool warning)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void Populate(NBGP2BigItemsConfig configData)
	{
	}

	private void LoadNotificationVFX()
	{
	}

	public void Play(object viewData)
	{
	}

	public void Finish(bool interrupted)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
