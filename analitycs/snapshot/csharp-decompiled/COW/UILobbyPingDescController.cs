using GCommon;

namespace COW;

public class UILobbyPingDescController : UIBaseController, IUIModelDataChangeObserver
{
	private const string Title = "IDCname   Address              Ping\n";

	private string Content;

	private string GroupState;

	private UIModelLobbyPing m_ModelLobbyPing;

	private UILobbyPingDescView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void RefreshUI()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
