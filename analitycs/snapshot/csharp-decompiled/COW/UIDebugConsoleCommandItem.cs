using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandItem : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public bool changeNameColor;
	}

	public delegate void OnRunCmd(string cmd);

	private UIDebugConsoleCommandItemView m_View;

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

	public void ChangeNameColor(bool enable)
	{
	}

	private void OnCmdClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
