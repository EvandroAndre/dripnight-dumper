using GCommon;

namespace COW;

public class UIBM26_SYSLobbyIconWndController : UIBigEventLobbyIconWndController
{
	protected uint m_AnimTwenOutKey;

	private UIBM26SysLobbyIconWndView m_View;

	protected string m_PrefKey;

	protected override int EventId => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
