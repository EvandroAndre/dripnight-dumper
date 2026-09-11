using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRoomParamsMainController : UIBaseController
{
	private UIRoomParamsMainView m_View;

	private List<IRoomParamsBase> m_Ctrls;

	private DKPCAEMALDP m_Params;

	private Dictionary<string, string> m_LocDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(DKPCAEMALDP data, Dictionary<string, string> dict)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void RefreshLocKey()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
