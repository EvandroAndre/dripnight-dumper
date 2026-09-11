using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRoomParamsMultiChooseController : UIBaseController, IRoomParamsBase
{
	private UIRoomParamsMultiChooseView m_View;

	private KDPGIMNMLFE m_Data;

	private Dictionary<string, string> m_LocDict;

	private List<UIRoomParamsMultiChooseItemController> m_Ctrls;

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

	public void RefreshLocKey()
	{
	}

	public void RefreshValue()
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
