using GCommon;

namespace COW;

internal class UILobbyAvatarTransformerEntryController : UIBaseController
{
	protected UIMaleAvatar m_CurAvatar;

	private UILobbyAvatarTransformerEntryView m_View;

	private UILobbyAvatarTransformerController m_LobbyAvatarTransformerCtrl;

	private UILobbyAvatarTransformerFreeMultiController[] m_LobbyAvatarTransformerFreeMultiCtrls;

	private int m_ClickIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void Init(uint transformerId)
	{
	}

	public void SetCurAvatar(UIMaleAvatar avatar)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
