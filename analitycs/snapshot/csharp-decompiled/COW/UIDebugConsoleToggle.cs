using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleToggle : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public bool defaultValue;
	}

	public delegate void OnRunCmd(string cmd, bool toggleValue);

	private UIDebugConsoleToggleView m_View;

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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
