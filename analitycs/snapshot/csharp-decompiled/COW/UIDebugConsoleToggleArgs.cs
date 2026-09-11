using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleToggleArgs : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public int index;

		public string name;

		public string cmd;

		public bool defaultValue;

		public string arg0Name;

		public string arg0Values;
	}

	public delegate void OnRunCmd(string cmd, bool togglevalue, object[] args);

	private UIDebugConsoleToggleArgsView m_View;

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

	public void OnToggleValueChange()
	{
	}

	public void OnArg0Submit()
	{
	}

	private void RunCmd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
