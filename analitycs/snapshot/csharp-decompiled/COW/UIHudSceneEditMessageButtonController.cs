using GCommon;

namespace COW;

internal class UIHudSceneEditMessageButtonController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudSceneEditMessageButtonView m_View;

	private UIHudSceneEditMessageController m_MsgController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnNewMessageReceived(object[] data)
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnMessageVisibleChanged(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
