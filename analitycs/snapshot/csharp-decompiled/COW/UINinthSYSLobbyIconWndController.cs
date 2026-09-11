using GCommon;

namespace COW;

public class UINinthSYSLobbyIconWndController : UIBigEventLobbyIconWndController
{
	private UINinthSYSLobbyIconWndView m_View;

	protected override int EventId => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void PlayFlySound()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayFlySound()
	{
	}
}
