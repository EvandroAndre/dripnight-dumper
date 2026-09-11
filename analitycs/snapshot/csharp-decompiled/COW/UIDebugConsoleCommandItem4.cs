using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandItem4 : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public string arg1Name;

		public string arg2Name;

		public string arg3Name;

		public string arg4Name;

		public string arg1Value;

		public string arg2Value;

		public string arg3Value;

		public string arg4Value;

		public Dictionary<string, uint> popMenuMap;
	}

	public delegate void OnRunCmd(string cmd, string arg1, string arg2, string arg3, string arg4);

	private UIDebugConsoleCommandItem4View m_View;

	private UIPopMenuSmallControler m_PopMenu;

	private Data m_Data;

	private string m_CurValue;

	public OnRunCmd OnRunCmdHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void OnPopupClick()
	{
	}

	private void UpdateArg1Type(object targetArg1Type)
	{
	}

	private void OnCmdClick()
	{
	}

	private PopMenuData _003COnPopupClick_003Eb__12_0(string item)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
