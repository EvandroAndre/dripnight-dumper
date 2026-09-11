using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRoomParamsPopMenuController : UIBaseController, IRoomParamsBase
{
	private UIRoomParamsPopMenuView m_View;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_PopMenuList;

	private int m_CurrentSelection;

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

	public void SetPopMenuDepth(int depth)
	{
	}

	public void SetViewData(KDPGIMNMLFE data, Dictionary<string, string> dict)
	{
	}

	public string GetDefaultText(int id)
	{
		return null;
	}

	public string GetLabelKey(int id)
	{
		return null;
	}

	public int GetCurrentSelection()
	{
		return 0;
	}

	private void GeneratePopList()
	{
	}

	protected virtual void SelectItemCallback(object data)
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
