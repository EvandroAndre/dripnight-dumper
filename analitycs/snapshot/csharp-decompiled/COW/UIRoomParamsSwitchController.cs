using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRoomParamsSwitchController : UIBaseController, IRoomParamsBase
{
	private UIRoomParamsSwitchView m_View;

	private KDPGIMNMLFE m_Data;

	private Dictionary<string, string> m_LocDict;

	public KDPGIMNMLFE ParamData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, string> LocDict => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(KDPGIMNMLFE data, Dictionary<string, string> dict)
	{
	}

	private void OnToggle(UIToggleButton btn)
	{
	}

	public void RefreshLocKey()
	{
	}

	public string GetRoomParamsLoc(string key, string defaultText = "")
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
