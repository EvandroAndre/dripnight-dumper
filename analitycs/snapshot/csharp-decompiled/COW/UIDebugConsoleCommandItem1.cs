using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandItem1 : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public string argName;

		public string argValue;

		public string arg1ValueChangeCmd;
	}

	public delegate void OnRunCmd(string cmd, string arg);

	private UIDebugConsoleCommandItem1View m_View;

	private Data m_Data;

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

	private void OnCmdClick()
	{
	}

	private void OnArg1Change()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
