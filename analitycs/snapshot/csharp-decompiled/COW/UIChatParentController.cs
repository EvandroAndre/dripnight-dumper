using GCommon;
using tcp;

namespace COW;

public class UIChatParentController : UIPopupWindowController
{
	private UIChatParentView m_View;

	private UIChatController m_ChatController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0uL)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnClose()
	{
	}

	private void CloseChatWindow(object[] objs)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
