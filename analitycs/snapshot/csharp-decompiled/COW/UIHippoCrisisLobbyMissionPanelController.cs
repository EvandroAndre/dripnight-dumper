using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHippoCrisisLobbyMissionPanelController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHippoCrisisLobbyMissionPanelView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private ClientActivityDesc m_ShowDesc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetMissionView(List<ClientActivityDesc> taskList)
	{
	}

	private void GotoAvtivity()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
