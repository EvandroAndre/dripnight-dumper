using GCommon;

namespace COW;

public class UIHudCameraEntryController : UIBaseController
{
	public const uint VISIBILITY_STATE_FULLCAMERAMODE = 1073741824u;

	private UIHudCameraEntryView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshVisible()
	{
	}

	private bool IsPlayerInSkyDiving()
	{
		return false;
	}

	private void OnPlayerPhysXStateChange(uint playerId)
	{
	}

	private void OnBtnCameraEntryClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
