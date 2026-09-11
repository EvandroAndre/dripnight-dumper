using GCommon;
using UnityEngine;

namespace COW;

internal class UIDebugConsoleCommandItem3 : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string cmd;

		public string argName;

		public string defaultValue;
	}

	public delegate void OnRunCmd(string cmd, string arg);

	private UIDebugConsoleCommandItem3View m_View;

	private Data m_Data;

	private string m_CurArgValue;

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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
